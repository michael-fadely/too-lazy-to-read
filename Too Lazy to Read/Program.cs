using System;
using System.IO;
using System.Windows.Forms;
using IniFile;
using TooLazyToRead.Forms;

namespace TooLazyToRead
{
	internal static class Program
	{
		public static bool TaskbarSupported;

		public static  ProgramSettings Settings;
		private static string          ConfigPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Too Lazy to Read");
		private static string          ConfigFile = "config.ini";
		private static string          Config; // This is set later to take command-line parameters into account.
		//public static bool FirstRun = false;

		#region Default Filters

		public static readonly Filter[] DefaultFilters =
		{
			new Filter
			{
				Name          = "Simplified Newline",
				Enabled       = true,
				Description   = "Replaces \\r\\n with \\n to simplify newline detection with Regular Expression.",
				Type          = FilterType.Regex,
				CaseSensitive = false,
				MatchText     = "\\r\\n",
				ReplaceText   = "\\n",
				EscapeReplace = false
			},
			new Filter
			{
				Name          = "Wikipedia",
				Enabled       = true,
				Description   = "Removes [edit], [show], [hide], and references (e.g [1], up to 9999) from Wikipedia articles while retaining [citation needed].",
				Type          = FilterType.Regex,
				CaseSensitive = false,
				MatchText     = @"\[(show|hide|edit|[0-9]+)\]",
				ReplaceText   = string.Empty,
				EscapeReplace = false
			},
			new Filter
			{
				Name          = "Quote/End Quote",
				Enabled       = true,
				Description   = "Replaces quote blocks with:\r\nquote: \"my quote\", end quote;",
				Type          = FilterType.Regex,
				CaseSensitive = false,
				MatchText     = "[\"“]([^\"”“]+)[”\"]",
				ReplaceText   = "quote: \"$1\", end quote;",
				EscapeReplace = false
			},
			new Filter
			{
				Name          = "Strip HTTP",
				Enabled       = true,
				Description   = "Cleans URLs to be easier to listen to.\r\n(e.g http://www.google.com -> www.google.com)",
				Type          = FilterType.Wildcard,
				CaseSensitive = false,
				MatchText     = "http*://(*)",
				ReplaceText   = "$1",
				EscapeReplace = false
			},
			new Filter
			{
				Name          = "Cloud to Butt",
				Enabled       = false,
				Description   = "Do you hate The Cloud? Do you much prefer The Butt? Then do we have the filter for you!",
				Type          = FilterType.Plain,
				CaseSensitive = false,
				MatchText     = "Cloud",
				ReplaceText   = "Butt",
				EscapeReplace = false
			}
		};

		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			#region Command-line parameters

			for (uint i = 0; i < args.Length; i++)
			{
				string s = args[i].ToUpper();

				switch (s)
				{
					case "--PORTABLE":
					case "-P":
						ConfigPath = Application.StartupPath;
						ConfigFile = "TooLazyToRead.ini";
						break;

					case "--DIRECTORY":
					case "--DIR":
					case "-D":
						ConfigPath = args[++i];
						break;

					case "--CONFIGURATION":
					case "--CONFIG":
					case "-C":
						ConfigFile = args[++i];
						break;

					default:
						continue;
				}
			}

			#endregion

			if (CreateConfigPath() != DialogResult.Ignore)
			{
				return;
			}

			TaskbarSupported = Environment.OSVersion.Version.Major >= 6 && Environment.OSVersion.Version.Minor >= 1;

			Config = Path.Combine(ConfigPath, ConfigFile);

			Settings = new ProgramSettings();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}

		public static DialogResult CreateConfigPath()
		{
			DialogResult result;

			do
			{
				try
				{
					if (!Directory.Exists(ConfigPath))
					{
						Directory.CreateDirectory(ConfigPath);
						result = DialogResult.OK;
					}
					else
					{
						result = DialogResult.Ignore;
					}
				}
				catch (Exception ex)
				{
					result = MessageBox.Show("The following error occurred while setting up the configuration directory:\n\n"
					                         + ex.Message,
					                         "Error creating directory", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
				}
			} while (result == DialogResult.Retry);

			return result;
		}

		/// <summary>
		/// Attempts to load settings from ConfigFile.
		/// </summary>
		/// <returns>DialogResult.OK on success, DialogResult.Ignore if the file doesn't exist,
		/// and whatever is returned by the input from MessageBox if an error occurs.</returns>
		public static DialogResult LoadSettings()
		{
			DialogResult result;

			do
			{
				try
				{
					if (File.Exists(Config))
					{
						Settings = IniSerializer.Deserialize<ProgramSettings>(Config);
						result   = DialogResult.OK;
					}
					else
					{
						Settings.Filters.AddRange(DefaultFilters);
						result = DialogResult.Ignore;
					}
				}
				catch (Exception ex)
				{
					result = MessageBox.Show("Too Lazy to Read was unable to load your settings?!\n\n"
					                         + ex.Message,
					                         "Error loading configuration", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
				}
			} while (result == DialogResult.Retry);

			return result;
		}

		public static DialogResult SaveSettings()
		{
			DialogResult result;

			do
			{
				try
				{
					IniSerializer.Serialize(Settings, Config);
					result = DialogResult.OK;
				}
				catch (Exception ex)
				{
					result = MessageBox.Show("Too Lazy to Read was unable to save your settings for some reason!\n\n"
					                         + ex.Message,
					                         "Error saving configuration", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
				}
			} while (result == DialogResult.Retry);

			return result;
		}
	}
}