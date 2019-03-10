using System.Collections.Generic;
using IniFile;

namespace TooLazyToRead
{
	public class ProgramSettings
	{
		public ProgramSettings()
		{
			ProgramConfig = new ProgramConfig();
			VoiceConfig   = new VoiceConfig();
			Filters       = new List<Filter>();
		}

		[IniAlwaysInclude, IniName("Program")] public ProgramConfig ProgramConfig;
		[IniAlwaysInclude, IniName("Voice")]   public VoiceConfig   VoiceConfig;
		[IniAlwaysInclude, IniName("Filters")] public List<Filter>  Filters;
	}

	public class ProgramConfig
	{
		[IniAlwaysInclude] public bool MonitorClipboard;
		[IniAlwaysInclude] public bool QueueClipboard;
		[IniAlwaysInclude] public bool ReadClipboardOnToggle;
		[IniAlwaysInclude] public bool IgnoreURLs;
		[IniAlwaysInclude] public bool ReadFromCursor;
		[IniAlwaysInclude] public bool RestoreSelection;
	}

	public class VoiceConfig
	{
		[IniAlwaysInclude] public string Name;
		[IniAlwaysInclude] public int    Speed;
	}
}