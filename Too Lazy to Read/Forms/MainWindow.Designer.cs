using System.ComponentModel;
using System.Windows.Forms;

namespace TooLazyToRead.Forms
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.richText = new System.Windows.Forms.RichTextBox();
			this.contextFormsSucks = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.playPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playFromHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trackVoiceSpeed = new System.Windows.Forms.TrackBar();
			this.comboVoices = new System.Windows.Forms.ComboBox();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recordToWAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolImportFilter = new System.Windows.Forms.ToolStripMenuItem();
			this.toolExportFilter = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolConfiguration = new System.Windows.Forms.ToolStripMenuItem();
			this.toolCheckMonitorClipboard = new System.Windows.Forms.ToolStripMenuItem();
			this.toolCheckIgnoreURLs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolCheckReadFromCursor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolCheckRestoreSelection = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.manageFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.saveRecordingDialog = new System.Windows.Forms.SaveFileDialog();
			this.openTextFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.buttonPlayClipboard = new System.Windows.Forms.Button();
			this.buttonPlayFrom = new System.Windows.Forms.Button();
			this.buttonPlayPause = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.toolQueueClipboard = new System.Windows.Forms.ToolStripMenuItem();
			this.contextFormsSucks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackVoiceSpeed)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// richText
			// 
			this.richText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.richText.ContextMenuStrip = this.contextFormsSucks;
			this.richText.HideSelection = false;
			this.richText.Location = new System.Drawing.Point(12, 54);
			this.richText.Name = "richText";
			this.richText.Size = new System.Drawing.Size(344, 241);
			this.richText.TabIndex = 2;
			this.richText.Text = "Gee, it sure is boring around here.";
			// 
			// contextFormsSucks
			// 
			this.contextFormsSucks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.playPauseToolStripMenuItem,
			this.playFromHereToolStripMenuItem,
			this.stopToolStripMenuItem,
			this.toolStripSeparator4,
			this.undoToolStripMenuItem,
			this.toolStripSeparator1,
			this.cutToolStripMenuItem,
			this.copyToolStripMenuItem,
			this.pasteToolStripMenuItem,
			this.deleteToolStripMenuItem,
			this.toolStripSeparator2,
			this.selectAllToolStripMenuItem,
			this.filterToolStripMenuItem});
			this.contextFormsSucks.Name = "contextFormsSucks";
			this.contextFormsSucks.Size = new System.Drawing.Size(152, 242);
			// 
			// playPauseToolStripMenuItem
			// 
			this.playPauseToolStripMenuItem.Image = global::TooLazyToRead.Properties.Resources.Play_PNG;
			this.playPauseToolStripMenuItem.Name = "playPauseToolStripMenuItem";
			this.playPauseToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.playPauseToolStripMenuItem.Text = "Play/Pause";
			this.playPauseToolStripMenuItem.Click += new System.EventHandler(this.buttonPlayPause_Click);
			// 
			// playFromHereToolStripMenuItem
			// 
			this.playFromHereToolStripMenuItem.Image = global::TooLazyToRead.Properties.Resources.PlayFrom_PNG;
			this.playFromHereToolStripMenuItem.Name = "playFromHereToolStripMenuItem";
			this.playFromHereToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.playFromHereToolStripMenuItem.Text = "Play from here";
			this.playFromHereToolStripMenuItem.Click += new System.EventHandler(this.buttonPlayFrom_Click);
			// 
			// stopToolStripMenuItem
			// 
			this.stopToolStripMenuItem.Image = global::TooLazyToRead.Properties.Resources.Stop_PNG;
			this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
			this.stopToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.stopToolStripMenuItem.Text = "Stop";
			this.stopToolStripMenuItem.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(148, 6);
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.undoToolStripMenuItem.Text = "Undo";
			this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.cutToolStripMenuItem.Text = "Cut";
			this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.selectAllToolStripMenuItem.Text = "Select All";
			this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
			// 
			// filterToolStripMenuItem
			// 
			this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.selectedToolStripMenuItem,
			this.lastToolStripMenuItem,
			this.allToolStripMenuItem});
			this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
			this.filterToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.filterToolStripMenuItem.Text = "Run Filters";
			// 
			// selectedToolStripMenuItem
			// 
			this.selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
			this.selectedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.selectedToolStripMenuItem.Text = "Selected...";
			this.selectedToolStripMenuItem.Click += new System.EventHandler(this.selectedToolStripMenuItem_Click);
			// 
			// lastToolStripMenuItem
			// 
			this.lastToolStripMenuItem.Name = "lastToolStripMenuItem";
			this.lastToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.lastToolStripMenuItem.Text = "Last Filters";
			this.lastToolStripMenuItem.Click += new System.EventHandler(this.lastToolStripMenuItem_Click);
			// 
			// allToolStripMenuItem
			// 
			this.allToolStripMenuItem.Name = "allToolStripMenuItem";
			this.allToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.allToolStripMenuItem.Text = "All Eanbled";
			this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
			// 
			// trackVoiceSpeed
			// 
			this.trackVoiceSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.trackVoiceSpeed.Location = new System.Drawing.Point(12, 301);
			this.trackVoiceSpeed.Minimum = -10;
			this.trackVoiceSpeed.Name = "trackVoiceSpeed";
			this.trackVoiceSpeed.Size = new System.Drawing.Size(160, 45);
			this.trackVoiceSpeed.TabIndex = 3;
			this.toolTip.SetToolTip(this.trackVoiceSpeed, "Changes voice speed.");
			this.trackVoiceSpeed.Scroll += new System.EventHandler(this.trackVoiceSpeed_Scroll);
			this.trackVoiceSpeed.ValueChanged += new System.EventHandler(this.trackVoiceSpeed_ValueChanged);
			// 
			// comboVoices
			// 
			this.comboVoices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.comboVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboVoices.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboVoices.FormattingEnabled = true;
			this.comboVoices.Location = new System.Drawing.Point(12, 27);
			this.comboVoices.Name = "comboVoices";
			this.comboVoices.Size = new System.Drawing.Size(344, 21);
			this.comboVoices.TabIndex = 1;
			this.comboVoices.SelectedIndexChanged += new System.EventHandler(this.comboVoices_SelectedIndexChanged);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.optionsToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(368, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openToolStripMenuItem,
			this.saveSettingsToolStripMenuItem,
			this.recordToWAVToolStripMenuItem,
			this.toolStripSeparator5,
			this.toolImportFilter,
			this.toolExportFilter,
			this.toolStripSeparator3,
			this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveSettingsToolStripMenuItem
			// 
			this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
			this.saveSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.saveSettingsToolStripMenuItem.Text = "Save Settings";
			this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem_Click);
			// 
			// recordToWAVToolStripMenuItem
			// 
			this.recordToWAVToolStripMenuItem.Name = "recordToWAVToolStripMenuItem";
			this.recordToWAVToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.recordToWAVToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.recordToWAVToolStripMenuItem.Text = "Record to WAV";
			this.recordToWAVToolStripMenuItem.Click += new System.EventHandler(this.recordToWAVToolStripMenuItem_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(191, 6);
			// 
			// toolImportFilter
			// 
			this.toolImportFilter.Name = "toolImportFilter";
			this.toolImportFilter.Size = new System.Drawing.Size(194, 22);
			this.toolImportFilter.Text = "Import Filters";
			this.toolImportFilter.Click += new System.EventHandler(this.toolImportFilter_Click);
			// 
			// toolExportFilter
			// 
			this.toolExportFilter.Name = "toolExportFilter";
			this.toolExportFilter.Size = new System.Drawing.Size(194, 22);
			this.toolExportFilter.Text = "Export Filters";
			this.toolExportFilter.Click += new System.EventHandler(this.toolExportFilter_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(191, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolConfiguration,
			this.toolCheckMonitorClipboard,
			this.toolQueueClipboard,
			this.toolCheckIgnoreURLs,
			this.toolCheckReadFromCursor,
			this.toolCheckRestoreSelection,
			this.toolStripMenuItem1,
			this.manageFiltersToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.optionsToolStripMenuItem.Text = "Edit";
			// 
			// toolConfiguration
			// 
			this.toolConfiguration.Enabled = false;
			this.toolConfiguration.Name = "toolConfiguration";
			this.toolConfiguration.Size = new System.Drawing.Size(206, 22);
			this.toolConfiguration.Text = "Configuration";
			this.toolConfiguration.Visible = false;
			// 
			// toolCheckMonitorClipboard
			// 
			this.toolCheckMonitorClipboard.CheckOnClick = true;
			this.toolCheckMonitorClipboard.Name = "toolCheckMonitorClipboard";
			this.toolCheckMonitorClipboard.Size = new System.Drawing.Size(206, 22);
			this.toolCheckMonitorClipboard.Text = "Monitor Clipboard";
			this.toolCheckMonitorClipboard.ToolTipText = "Monitors the clipboard for text and automatically reads it";
			this.toolCheckMonitorClipboard.CheckedChanged += new System.EventHandler(this.toolCheckMonitorClipboard_CheckedChanged);
			// 
			// toolCheckIgnoreURLs
			// 
			this.toolCheckIgnoreURLs.Checked = true;
			this.toolCheckIgnoreURLs.CheckOnClick = true;
			this.toolCheckIgnoreURLs.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolCheckIgnoreURLs.Name = "toolCheckIgnoreURLs";
			this.toolCheckIgnoreURLs.Size = new System.Drawing.Size(206, 22);
			this.toolCheckIgnoreURLs.Text = "Ignore URLs";
			this.toolCheckIgnoreURLs.ToolTipText = "When Monitor Clipboard is enabled, attempt to ignore URLs.";
			// 
			// toolCheckReadFromCursor
			// 
			this.toolCheckReadFromCursor.CheckOnClick = true;
			this.toolCheckReadFromCursor.Name = "toolCheckReadFromCursor";
			this.toolCheckReadFromCursor.Size = new System.Drawing.Size(206, 22);
			this.toolCheckReadFromCursor.Text = "Read from cursor";
			this.toolCheckReadFromCursor.ToolTipText = "Always reads from the cursor offset instead of the beginning.";
			// 
			// toolCheckRestoreSelection
			// 
			this.toolCheckRestoreSelection.Checked = true;
			this.toolCheckRestoreSelection.CheckOnClick = true;
			this.toolCheckRestoreSelection.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolCheckRestoreSelection.Name = "toolCheckRestoreSelection";
			this.toolCheckRestoreSelection.Size = new System.Drawing.Size(206, 22);
			this.toolCheckRestoreSelection.Text = "Restore original selection";
			this.toolCheckRestoreSelection.ToolTipText = "Restores original selection after reading it";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
			// 
			// manageFiltersToolStripMenuItem
			// 
			this.manageFiltersToolStripMenuItem.Name = "manageFiltersToolStripMenuItem";
			this.manageFiltersToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.manageFiltersToolStripMenuItem.Text = "Manage Filters...";
			this.manageFiltersToolStripMenuItem.Click += new System.EventHandler(this.manageFiltersToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Enabled = false;
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Visible = false;
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Enabled = false;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// saveRecordingDialog
			// 
			this.saveRecordingDialog.DefaultExt = "wav";
			this.saveRecordingDialog.Filter = "WAV File|*.wav|All files|*.*";
			this.saveRecordingDialog.SupportMultiDottedExtensions = true;
			this.saveRecordingDialog.Title = "Save Speech Recording";
			// 
			// openTextFileDialog
			// 
			this.openTextFileDialog.DefaultExt = "txt";
			this.openTextFileDialog.Filter = "Text Files|*.txt";
			this.openTextFileDialog.Multiselect = true;
			// 
			// buttonPlayClipboard
			// 
			this.buttonPlayClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPlayClipboard.AutoSize = true;
			this.buttonPlayClipboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonPlayClipboard.Image = global::TooLazyToRead.Properties.Resources.PlayClipboard_PNG;
			this.buttonPlayClipboard.Location = new System.Drawing.Point(234, 301);
			this.buttonPlayClipboard.Name = "buttonPlayClipboard";
			this.buttonPlayClipboard.Padding = new System.Windows.Forms.Padding(2);
			this.buttonPlayClipboard.Size = new System.Drawing.Size(26, 26);
			this.buttonPlayClipboard.TabIndex = 4;
			this.buttonPlayClipboard.UseVisualStyleBackColor = true;
			this.buttonPlayClipboard.Click += new System.EventHandler(this.buttonPlayClipboard_Click);
			// 
			// buttonPlayFrom
			// 
			this.buttonPlayFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPlayFrom.AutoSize = true;
			this.buttonPlayFrom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonPlayFrom.Image = global::TooLazyToRead.Properties.Resources.PlayFrom_PNG;
			this.buttonPlayFrom.Location = new System.Drawing.Point(266, 301);
			this.buttonPlayFrom.Name = "buttonPlayFrom";
			this.buttonPlayFrom.Padding = new System.Windows.Forms.Padding(2);
			this.buttonPlayFrom.Size = new System.Drawing.Size(26, 26);
			this.buttonPlayFrom.TabIndex = 5;
			this.buttonPlayFrom.UseVisualStyleBackColor = true;
			this.buttonPlayFrom.Click += new System.EventHandler(this.buttonPlayFrom_Click);
			// 
			// buttonPlayPause
			// 
			this.buttonPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPlayPause.AutoSize = true;
			this.buttonPlayPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonPlayPause.Image = global::TooLazyToRead.Properties.Resources.Play_PNG;
			this.buttonPlayPause.Location = new System.Drawing.Point(298, 301);
			this.buttonPlayPause.Name = "buttonPlayPause";
			this.buttonPlayPause.Padding = new System.Windows.Forms.Padding(2);
			this.buttonPlayPause.Size = new System.Drawing.Size(26, 26);
			this.buttonPlayPause.TabIndex = 6;
			this.buttonPlayPause.UseVisualStyleBackColor = true;
			this.buttonPlayPause.Click += new System.EventHandler(this.buttonPlayPause_Click);
			// 
			// buttonStop
			// 
			this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStop.AutoSize = true;
			this.buttonStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonStop.Image = global::TooLazyToRead.Properties.Resources.Stop_PNG;
			this.buttonStop.Location = new System.Drawing.Point(330, 301);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Padding = new System.Windows.Forms.Padding(2);
			this.buttonStop.Size = new System.Drawing.Size(26, 26);
			this.buttonStop.TabIndex = 7;
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// queueClipboardToolStripMenuItem
			// 
			this.toolQueueClipboard.CheckOnClick = true;
			this.toolQueueClipboard.Enabled = false;
			this.toolQueueClipboard.Name = "toolQueueClipboard";
			this.toolQueueClipboard.Size = new System.Drawing.Size(206, 22);
			this.toolQueueClipboard.Text = "Queue Clipboard";
			// 
			// MainWindow
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 336);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.buttonPlayPause);
			this.Controls.Add(this.buttonPlayFrom);
			this.Controls.Add(this.buttonPlayClipboard);
			this.Controls.Add(this.comboVoices);
			this.Controls.Add(this.trackVoiceSpeed);
			this.Controls.Add(this.richText);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(384, 374);
			this.Name = "MainWindow";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Too Lazy to Read";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.onDragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.onDragEnter);
			this.contextFormsSucks.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackVoiceSpeed)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RichTextBox richText;
		private TrackBar trackVoiceSpeed;
		private ComboBox comboVoices;
		private MenuStrip menuStrip;
		private ToolStripMenuItem optionsToolStripMenuItem;
		private ToolStripMenuItem toolCheckMonitorClipboard;
		private ToolStripMenuItem toolCheckRestoreSelection;
		private ToolTip toolTip;
		private ToolStripMenuItem toolCheckIgnoreURLs;
		private ContextMenuStrip contextFormsSucks;
		private ToolStripMenuItem cutToolStripMenuItem;
		private ToolStripMenuItem copyToolStripMenuItem;
		private ToolStripMenuItem pasteToolStripMenuItem;
		private ToolStripMenuItem selectAllToolStripMenuItem;
		private ToolStripMenuItem deleteToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem undoToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem filterToolStripMenuItem;
		private ToolStripMenuItem manageFiltersToolStripMenuItem;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem saveSettingsToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripMenuItem allToolStripMenuItem;
		private ToolStripMenuItem selectedToolStripMenuItem;
		private ToolStripMenuItem lastToolStripMenuItem;
		private ToolStripMenuItem toolCheckReadFromCursor;
		private ToolStripMenuItem playFromHereToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripMenuItem playPauseToolStripMenuItem;
		private ToolStripMenuItem stopToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private ToolStripMenuItem toolConfiguration;
		private ToolStripMenuItem recordToWAVToolStripMenuItem;
		private SaveFileDialog saveRecordingDialog;
		private OpenFileDialog openTextFileDialog;
		private ToolStripSeparator toolStripSeparator5;
		private ToolStripMenuItem toolImportFilter;
		private ToolStripMenuItem toolExportFilter;
		private ToolStripSeparator toolStripMenuItem1;
		private Button buttonPlayClipboard;
		private Button buttonPlayFrom;
		private Button buttonPlayPause;
		private Button buttonStop;
		private ToolStripMenuItem toolQueueClipboard;
	}
}

