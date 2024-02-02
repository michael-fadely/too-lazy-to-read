using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using IniFile;

using Microsoft.WindowsAPICodePack.Taskbar;

using TooLazyToRead.Properties;

// TODO: Taskbar configuration, function wrappers
// TODO: Handle taskbar buttons and icons more cleanly.
// TODO: Handle enabling and disabling of controls more cleanly.
// TODO: Advanced voice configuration (output device etc)
// TODO: Shortcut keys for applying filters.
// TODO: Clipboard queue viewer dialog

namespace TooLazyToRead.Forms
{
	public partial class MainWindow : Form
	{
		private readonly List<int>               lastFilters = new List<int>();
		private          ConcurrentQueue<string> clipQueue   = new ConcurrentQueue<string>();
		private          SpeechSynthesizer       speech;

		private int lastSelectionOffset;
		private int lastSelectionLength;
		private int textLength;

		private readonly bool enableTaskbar = Program.TaskbarSupported;
		private          bool isReadingFromCursor;

		private TaskbarManager           taskbar;
		private ThumbnailToolBarButton   taskbarPlayPause;
		private ThumbnailToolBarButton   taskbarStop;
		private ThumbnailToolBarButton   taskbarClipboard;
		private ThumbnailToolBarButton[] taskbarButtons;
		private string                   lastClipboard;

		private enum HotkeyID : uint
		{
			ReadClipboard
		}

		public MainWindow()
		{
			InitializeComponent();
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			// TODO: Make configurable
			WinApi.RegisterHotKey(Handle, (int)HotkeyID.ReadClipboard, WinApi.MOD_CONTROL | WinApi.MOD_ALT, (uint)Keys.C);

			speech = new SpeechSynthesizer();

			speech.SpeakStarted   += OnSpeakStart;
			speech.SpeakCompleted += OnSpeakComplete;
			speech.SpeakProgress  += OnSpeakProgress;

			foreach (InstalledVoice voice in speech.GetInstalledVoices())
			{
				comboVoices.Items.Add(voice.VoiceInfo.Name);
			}

			if (!LoadSettings())
			{
				Close();
			}

			InitTaskbar(enableTaskbar);

			richText.AllowDrop =  true;
			richText.DragDrop  += onDragDrop;
			richText.DragEnter += onDragEnter;
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			WinApi.UnregisterHotKey(Handle, (int)HotkeyID.ReadClipboard);
			UnregisterClipboard();
			StopSpeaking();
			speech.Dispose();

			SaveSettings();
		}

		private void InitTaskbar(bool init)
		{
			if (init)
			{
				taskbar = TaskbarManager.Instance;

				taskbarPlayPause = new ThumbnailToolBarButton(Resources.Play, "Play");                    // TODO: Translatable
				taskbarStop      = new ThumbnailToolBarButton(Resources.Stop, "Stop");                    // TODO: Translatable
				taskbarClipboard = new ThumbnailToolBarButton(Resources.PlayClipboard, "Play Clipboard"); // TODO: Translatable

				taskbarClipboard.Click += buttonPlayClipboard_Click;
				taskbarPlayPause.Click += onTaskbarPlayPause_Click;
				taskbarStop.Click      += buttonStop_Click;

				taskbarButtons = new ThumbnailToolBarButton[]
				{
					taskbarClipboard,
					taskbarPlayPause,
					taskbarStop
				};

				taskbar.ThumbnailToolBars.AddButtons(Handle, taskbarButtons);
			}
			else
			{
				taskbar = null;

				taskbarPlayPause = null;
				taskbarStop      = null;
				taskbarClipboard = null;

				taskbarButtons = null;
			}
		}

		#region Configuration

		/// <summary>
		/// Calls <see cref="Program.LoadSettings"/> and applies the loaded settings.
		/// If <see cref="Program.LoadSettings"/> returns <see cref="DialogResult.Ignore"/>, it uses the default Form settings
		/// and calls <see cref="StoreSettings"/>.
		/// </summary>
		/// <returns><c>true</c> on success.</returns>
		private bool LoadSettings()
		{
			switch (Program.LoadSettings())
			{
				case DialogResult.Ignore:
					comboVoices.SelectedIndex = comboVoices.FindStringExact(speech.Voice.Name);
					StoreSettings();
					return true;

				case DialogResult.Abort:
					return false;

				default:
					ApplySettings();
					return true;
			}
		}

		/// <summary>
		/// Calls <see cref="StoreSettings"/> and <see cref="Program.SaveSettings"/> to save the configuration to disk.
		/// </summary>
		private void SaveSettings()
		{
			StoreSettings();
			Program.SaveSettings();
		}

		/// <summary>
		/// Stores configuration from the Form in the Settings class.
		/// </summary>
		private void StoreSettings()
		{
			Program.Settings.ProgramConfig.MonitorClipboard = toolCheckMonitorClipboard.Checked;
			Program.Settings.ProgramConfig.QueueClipboard   = toolQueueClipboard.Checked;
			Program.Settings.ProgramConfig.IgnoreURLs       = toolCheckIgnoreURLs.Checked;
			Program.Settings.ProgramConfig.ReadFromCursor   = true;
			Program.Settings.ProgramConfig.ReadFromCursor   = toolCheckReadFromCursor.Checked;
			Program.Settings.ProgramConfig.RestoreSelection = toolCheckRestoreSelection.Checked;

			Program.Settings.VoiceConfig.Name  = comboVoices.Text;
			Program.Settings.VoiceConfig.Speed = trackVoiceSpeed.Value;
		}

		/// <summary>
		/// Applies the settings stored in the Settings class to the Form
		/// </summary>
		private void ApplySettings()
		{
			int voiceIndex = comboVoices.FindStringExact(Program.Settings.VoiceConfig.Name);

			if (voiceIndex < 0)
			{
				MessageBox.Show(string.Format(Resources.MainWindow_ApplySettings_ConfiguredVoiceNotFound_Message, Program.Settings.VoiceConfig.Name),
				                Resources.MainWindow_ApplySettings_ConfiguredVoiceNotFound_Title,
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Error);

				voiceIndex = 0;
			}

			comboVoices.SelectedIndex = voiceIndex;
			trackVoiceSpeed.Value     = Program.Settings.VoiceConfig.Speed;

			toolCheckMonitorClipboard.Checked = Program.Settings.ProgramConfig.MonitorClipboard;
			toolQueueClipboard.Checked        = Program.Settings.ProgramConfig.QueueClipboard;
			toolCheckIgnoreURLs.Checked       = Program.Settings.ProgramConfig.IgnoreURLs;
			toolCheckReadFromCursor.Checked   = Program.Settings.ProgramConfig.ReadFromCursor;
			toolCheckRestoreSelection.Checked = Program.Settings.ProgramConfig.RestoreSelection;
		}

		#endregion

		#region Speech

		private void OnSpeakStart(object sender, SpeakStartedEventArgs e)
		{
			if (enableTaskbar)
			{
				taskbarPlayPause.Icon    = Resources.Pause;
				taskbarPlayPause.Tooltip = "Pause"; // TODO: Translatable

				taskbar.SetProgressState(TaskbarProgressBarState.Normal);
			}

			buttonPlayPause.Image            = Resources.Pause_PNG;
			playPauseToolStripMenuItem.Image = Resources.Pause_PNG;

			comboVoices.Enabled                   = false;
			buttonStop.Enabled                    = true;
			buttonPlayFrom.Enabled                = false;
			stopToolStripMenuItem.Enabled         = true;
			playFromHereToolStripMenuItem.Enabled = false;
		}

		private void OnSpeakComplete(object sender, SpeakCompletedEventArgs e)
		{
			if (toolQueueClipboard.Checked && clipQueue.Count > 0)
			{
				string text = string.Empty;

				while (!clipQueue.IsEmpty && !clipQueue.TryDequeue(out text))
				{
					Thread.Sleep(1);
				}

				ReadText(text);
				return;
			}

			if (enableTaskbar)
			{
				taskbarPlayPause.Icon    = Resources.Play;
				taskbarPlayPause.Tooltip = "Play"; // TODO: Translatable

				taskbar.SetProgressState(TaskbarProgressBarState.NoProgress);
			}

			if (toolCheckRestoreSelection.Checked && lastSelectionLength > 0)
			{
				richText.Select(lastSelectionOffset, lastSelectionLength);
			}
			else if (toolCheckReadFromCursor.Checked || isReadingFromCursor)
			{
				richText.Select(lastSelectionOffset, 0);
			}
			else
			{
				richText.DeselectAll();
			}

			buttonPlayPause.Image            = Resources.Play_PNG;
			playPauseToolStripMenuItem.Image = Resources.Play_PNG;

			comboVoices.Enabled                   = true;
			buttonStop.Enabled                    = false;
			buttonPlayFrom.Enabled                = true;
			stopToolStripMenuItem.Enabled         = false;
			playFromHereToolStripMenuItem.Enabled = true;

			isReadingFromCursor = false;
		}

		private void OnSpeakProgress(object sender, SpeakProgressEventArgs args)
		{
			// With Cortana, this event can be fired for two different words
			// simultaneously while the first is still being read.
			richText.Select(args.CharacterPosition + lastSelectionOffset, args.CharacterCount);

			if (enableTaskbar)
			{
				taskbar.SetProgressValue(args.CharacterPosition + args.CharacterCount, textLength);
			}
		}

		private string GetSubstring(bool readFromCursor, bool enableReadSelection)
		{
			if (enableReadSelection && ((lastSelectionLength = richText.SelectionLength) > 0))
			{
				lastSelectionOffset = richText.SelectionStart;
				textLength          = richText.SelectedText.Length;

				return richText.SelectedText;
			}

			if (readFromCursor && richText.SelectionStart > 0 && richText.SelectionStart != richText.Text.Length)
			{
				lastSelectionOffset = richText.SelectionStart;
				textLength          = richText.Text.Length - richText.SelectionStart;
			}
			else
			{
				lastSelectionOffset = 0;
				textLength          = richText.Text.Length;
			}

			return lastSelectionOffset == 0 ? richText.Text : richText.Text.Substring(lastSelectionOffset);
		}

		private void StartSpeaking(bool readFromCursor = false, bool enableReadSelection = true)
		{
			isReadingFromCursor = readFromCursor;
			speech.SpeakAsync(GetSubstring(readFromCursor, enableReadSelection));
		}

		private void PauseSpeech(bool pause)
		{
			if (pause && speech.State == SynthesizerState.Speaking)
			{
				if (enableTaskbar)
				{
					taskbarPlayPause.Icon    = Resources.Play;
					taskbarPlayPause.Tooltip = "Play"; // TODO: Translatable

					taskbar.SetProgressState(TaskbarProgressBarState.Paused);
				}

				buttonPlayPause.Image            = Resources.Play_PNG;
				playPauseToolStripMenuItem.Image = Resources.Play_PNG;
				speech.Pause();
			}
			else if (!pause && speech.State == SynthesizerState.Paused)
			{
				if (enableTaskbar)
				{
					taskbarPlayPause.Icon    = Resources.Pause;
					taskbarPlayPause.Tooltip = "Pause"; // TODO: Translatable

					taskbar.SetProgressState(TaskbarProgressBarState.Normal);
				}

				buttonPlayPause.Image            = Resources.Pause_PNG;
				playPauseToolStripMenuItem.Image = Resources.Pause_PNG;
				speech.Resume();
			}
		}

		private void StopSpeaking()
		{
			if (speech.State == SynthesizerState.Paused)
			{
				PauseSpeech(false);
			}

			speech.SpeakAsyncCancelAll();
			clipQueue = new ConcurrentQueue<string>();
		}

		#endregion

		#region Clipboard

		private void RegisterClipboard()
		{
			WinApi.AddClipboardFormatListener(Handle);
		}

		private void UnregisterClipboard()
		{
			WinApi.RemoveClipboardFormatListener(Handle);
			lastClipboard = string.Empty;
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			switch ((WinApi.WM)m.Msg)
			{
				case WinApi.WM.CLIPBOARDUPDATE:
					if (toolCheckMonitorClipboard.Checked)
					{
						string str = GetClipboard();

						if (string.IsNullOrEmpty(str) || str == lastClipboard)
						{
							return;
						}

						lastClipboard = str;

						if (toolQueueClipboard.Checked && speech.State != SynthesizerState.Ready)
						{
							clipQueue.Enqueue(str);
						}
						else
						{
							ReadText(str);
						}
					}

					break;

				case WinApi.WM.HOTKEY:
					if ((HotkeyID)m.WParam == HotkeyID.ReadClipboard)
					{
						ReadText(GetClipboard());
					}

					break;
			}
		}

		private string GetClipboard()
		{
			IDataObject iData = Clipboard.GetDataObject();
			string result = string.Empty;

			if (iData == null || !iData.GetDataPresent(DataFormats.UnicodeText))
			{
				return result;
			}

			for (int i = 0; i < 10;)
			{
				try
				{
					result = iData.GetData(DataFormats.UnicodeText).ToString();

					// Sometimes the call above will succeed but still produce an empty string.
					// The condition below will cause it to continue polling until it produces a non-empty string.
					if (!string.IsNullOrEmpty(result))
					{
						break;
					}
				}
				catch
				{
					// ignored
				}

				if (++i == 10)
				{
					DialogResult input = MessageBox.Show(this,
					                                     Resources.MainWindow_GetClipboard_OpenClipboardFailed_Message,
					                                     Resources.MainWindow_GetClipboard_OpenClipboardFailed_Title,
					                                     MessageBoxButtons.RetryCancel,
					                                     MessageBoxIcon.Error);

					if (input != DialogResult.Retry)
					{
						return result;
					}

					i = 0;
					continue;
				}

				Thread.Sleep(10);
			}

			if (toolCheckIgnoreURLs.Checked && (result.StartsWith("http", StringComparison.Ordinal) || result.StartsWith("www", StringComparison.Ordinal)))
			{
				return string.Empty;
			}

			return result;
		}

		private void ReadText(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				return;
			}

			richText.ClearUndo();
			richText.Text = RunFilters(text);

			if (speech.State != SynthesizerState.Ready)
			{
				StopSpeaking();
			}

			StartSpeaking();
		}

		#endregion

		#region Filters

		private static string RunFilters(string input)
		{
			string result = input;

			foreach (Filter f in Program.Settings.Filters)
			{
				try
				{
					result = f.DoFilter(result);
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format(Resources.MainWindow_RunFilters_FilterError_Message, f.Name, f.Type, ex.Message),
					                Resources.MainWindow_RunFilters_FilterError_Title,
					                MessageBoxButtons.OK,
					                MessageBoxIcon.Error);
				}
			}

			return result;
		}

		private static string RunFilters(IEnumerable<int> indices, string input)
		{
			string result = input;

			foreach (int i in indices)
			{
				Filter f = Program.Settings.Filters[i];

				try
				{
					result = f.DoFilter(result, true);
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format(Resources.MainWindow_RunFilters_FilterError_Message, f.Name, f.Type, ex.Message),
					                Resources.MainWindow_RunFilters_FilterError_Title,
					                MessageBoxButtons.OK,
					                MessageBoxIcon.Error);
				}
			}

			return result;
		}

		private void ApplyFilters(bool useIndices)
		{
			int selectStart  = richText.SelectionStart;
			int selectLength = richText.SelectionLength;

			if (selectLength != richText.Text.Length && selectLength > 0)
			{
				string text = richText.Text;
				string substr = text.Substring(selectStart, selectLength);

				substr = useIndices ? RunFilters(lastFilters, substr) : RunFilters(substr);

				text = text.Remove(selectStart, selectLength);
				text = text.Insert(selectStart, substr);

				richText.Text = text;
				richText.Select(selectStart, substr.Length);
			}
			else
			{
				richText.Text = useIndices ? RunFilters(lastFilters, richText.Text) : RunFilters(richText.Text);
				richText.Select(Math.Min(selectStart, richText.Text.Length), 0);
			}
		}

		private void RunSelectedFilters(bool selectFirst)
		{
			var result = DialogResult.OK;

			if (selectFirst)
			{
				using (var window = new FilterSelect(Program.Settings.Filters, lastFilters))
				{
					result = window.ShowDialog();

					if (result == DialogResult.OK && window.FiltersModified)
					{
						Program.Settings.Filters = window.FilterList;
						SaveSettings();
					}
				}
			}

			if (result != DialogResult.OK)
			{
				return;
			}

			ApplyFilters(true);
		}

		#endregion

		#region Text box context menu

		private void undoToolStripMenuItem_Click(object sender, EventArgs e) => richText.Undo();

		private void cutToolStripMenuItem_Click(object sender, EventArgs e) => richText.Cut();

		private void copyToolStripMenuItem_Click(object sender, EventArgs e) => richText.Copy();

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e) => richText.Paste();

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richText.Text = richText.Text.Remove(richText.SelectionStart, richText.SelectionLength);
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) => richText.SelectAll();

		private void allToolStripMenuItem_Click(object sender, EventArgs e) => ApplyFilters(useIndices: false);

		private void selectedToolStripMenuItem_Click(object sender, EventArgs e) => RunSelectedFilters(selectFirst: true);

		private void lastToolStripMenuItem_Click(object sender, EventArgs e) => RunSelectedFilters(selectFirst: false);

		private void buttonPlayFrom_Click(object sender, EventArgs e) => StartSpeaking(readFromCursor: true, enableReadSelection: false);

		#endregion

		#region Taskbar

		private void onTaskbarPlayPause_Click(object sender, EventArgs e)
		{
			switch (speech.State)
			{
				case SynthesizerState.Ready:
					StartSpeaking(readFromCursor: false, enableReadSelection: false);
					break;

				case SynthesizerState.Speaking:
					PauseSpeech(true);
					break;

				case SynthesizerState.Paused:
					PauseSpeech(false);
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		#endregion

		#region Controls

		private void comboVoices_SelectedIndexChanged(object sender, EventArgs e)
		{
			string voice = comboVoices.SelectedItem.ToString();

			try
			{
				speech.SelectVoice(voice);
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format(Resources.MainWindow_comboVoices_SelectedIndexChanged_ErrorLoadingVoice_Message, voice, ex.Message),
				                Resources.MainWindow_comboVoices_SelectedIndexChanged_ErrorLoadingVoice_Title,
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Error);

				comboVoices.Items.RemoveAt(comboVoices.SelectedIndex);
				comboVoices.SelectedIndex = 0;
			}
		}

		private void buttonPlayClipboard_Click(object sender, EventArgs e)
		{
			ReadText(GetClipboard());
		}

		private void buttonPlayPause_Click(object sender, EventArgs e)
		{
			switch (speech.State)
			{
				case SynthesizerState.Ready:
					StartSpeaking(toolCheckReadFromCursor.Checked);
					break;

				case SynthesizerState.Speaking:
					PauseSpeech(true);
					break;

				case SynthesizerState.Paused:
					PauseSpeech(false);
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			StopSpeaking();
		}

		private void trackVoiceSpeed_ValueChanged(object sender, EventArgs e)
		{
			speech.Rate = trackVoiceSpeed.Value;
		}

		private void trackVoiceSpeed_Scroll(object sender, EventArgs e)
		{
			toolTip.SetToolTip(trackVoiceSpeed, string.Format(Resources.MainWindow_trackVoiceSpeed_Scroll_VoiceSpeedToolTip, trackVoiceSpeed.Value));
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = openTextFileDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				ReadTextFile(openTextFileDialog.FileNames);
			}
		}

		private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveSettings();
		}

		private void recordToWAVToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = saveRecordingDialog.ShowDialog();

			if (result != DialogResult.OK)
			{
				return;
			}

			string filename = saveRecordingDialog.FileName;

			try
			{
				speech.SetOutputToWaveFile(filename);
				speech.Speak(GetSubstring(toolCheckReadFromCursor.Checked, true));
			}
			catch (Exception ex)
			{
				if (enableTaskbar)
				{
					taskbar.SetProgressState(TaskbarProgressBarState.Error);
				}

				MessageBox.Show(string.Format(Resources.MainWindow_recordToWAVToolStripMenuItem_Click_ErrorSavingRecording_Message, ex.Message),
				                Resources.MainWindow_recordToWAVToolStripMenuItem_Click_ErrorSavingRecording_Title,
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Error);

				if (enableTaskbar)
				{
					taskbar.SetProgressState(TaskbarProgressBarState.NoProgress);
				}

				speech.SetOutputToDefaultAudioDevice();
				return;
			}

			speech.SetOutputToDefaultAudioDevice();

			result = MessageBox.Show(Resources.MainWindow_recordToWAVToolStripMenuItem_Click_RecordingComplete_Message,
			                         Resources.MainWindow_recordToWAVToolStripMenuItem_Click_RecordingComplete_Title,
			                         MessageBoxButtons.YesNo,
			                         MessageBoxIcon.Information);

			OnSpeakComplete(speech, null);

			if (result == DialogResult.Yes)
			{
				Process.Start(filename);
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = DialogResult.Yes;

			if (speech.State == SynthesizerState.Speaking)
			{
				result = MessageBox.Show(Resources.MainWindow_exitToolStripMenuItem_Click_ConfirmExit_Message,
				                         Resources.MainWindow_exitToolStripMenuItem_Click_ConfirmExit_Title,
				                         MessageBoxButtons.YesNo,
				                         MessageBoxIcon.Information);
			}

			if (result == DialogResult.Yes)
			{
				Close();
			}
		}

		private void toolCheckMonitorClipboard_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = ((ToolStripMenuItem)sender).Checked;
			toolQueueClipboard.Enabled = @checked;

			if (@checked)
			{
				RegisterClipboard();

				if (Program.Settings.ProgramConfig.ReadClipboardOnToggle)
				{
					ReadText(GetClipboard());
				}
			}
			else
			{
				UnregisterClipboard();
			}
		}

		private void manageFiltersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var window = new FilterManager(Program.Settings.Filters))
			{
				if (window.ShowDialog() != DialogResult.OK)
				{
					return;
				}

				SaveSettings();
				Program.Settings.Filters = window.NewFilters;
			}
		}

		#endregion

		// Read all text files and join their text separated by empty lines.
		private void ReadTextFile(IEnumerable<string> filePaths)
		{
			var allText = new StringBuilder();

			foreach (string filePath in filePaths)
			{
				string extension = Path.GetExtension(filePath);

				if (string.IsNullOrEmpty(extension) || extension.ToUpper() != ".TXT")
				{
					continue;
				}

				string fileText = File.ReadAllText(filePath).Trim();

				if (string.IsNullOrEmpty(fileText))
				{
					continue;
				}

				allText.Append(allText.Length == 0 ? fileText : $"\n\n{fileText}");
			}

			richText.Text = allText.ToString();
		}

		private void onDragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				ReadTextFile((string[])e.Data.GetData(DataFormats.FileDrop, false));
			}
		}

		private void onDragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
		}

		private void toolImportFilter_Click(object sender, EventArgs e)
		{
			using (var open = new OpenFileDialog { Filter = @"INI File|*.ini" })
			{
				if (open.ShowDialog() != DialogResult.OK)
				{
					return;
				}

				var import = IniSerializer.Deserialize<List<Filter>>(open.FileName);

				if (import.Count == 0)
				{
					MessageBox.Show(Resources.MainWindow_toolImportFilter_Click_NoFiltersInFile_Message,
					                Resources.MainWindow_toolImportFilter_Click_NoFiltersInFile_Title,
					                MessageBoxButtons.OK,
					                MessageBoxIcon.Information);
					return;
				}

				using (var window = new FilterSelect(import))
				{
					if (window.ShowDialog() != DialogResult.OK)
					{
						return;
					}

					foreach (int i in window.SelectedFilters)
					{
						Program.Settings.Filters.Add(window.FilterList[i]);
					}
				}
			}
		}

		private void toolExportFilter_Click(object sender, EventArgs e)
		{
			using (var window = new FilterSelect(Program.Settings.Filters))
			{
				DialogResult result = window.ShowDialog();

				if (result != DialogResult.OK)
				{
					return;
				}

				using (var save = new SaveFileDialog { Filter = @"INI File|*.ini" })
				{
					if (save.ShowDialog() != DialogResult.OK || window.SelectedFilters.Count <= 0)
					{
						return;
					}

					if (window.FiltersModified)
					{
						Program.Settings.Filters = window.FilterList;
					}

					List<Filter> export = window.SelectedFilters.Select(i => Program.Settings.Filters[i]).ToList();

					IniSerializer.Serialize(export, save.FileName);
				}
			}
		}
	}
}
