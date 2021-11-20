using System.Collections.Generic;
using IniFile;

namespace TooLazyToRead
{
	public class ProgramSettings
	{
		public ProgramSettings()
		{
			ProgramConfig                  = new ProgramConfig();
			VoiceConfig                    = new VoiceConfig();
			Filters                        = new List<Filter>();
			MonitorClipboard_ProgramFilter = new List<ProgramFilter>();
		}

		[IniAlwaysInclude, IniName("Program")] public ProgramConfig ProgramConfig;
		[IniAlwaysInclude, IniName("Voice")]   public VoiceConfig   VoiceConfig;
		[IniAlwaysInclude, IniName("Filters")] public List<Filter>  Filters;
		[IniAlwaysInclude, IniName("ProgramFilters")] public List<ProgramFilter> MonitorClipboard_ProgramFilter;

		public bool ProgramInClipboardFilter(string proc_name)
        {
			if (MonitorClipboard_ProgramFilter.Count == 0)
            {
				return true;
            }

			foreach (ProgramFilter filter_entry in MonitorClipboard_ProgramFilter)
			{
				if (filter_entry.Filename == proc_name)
                {
					return true;
                }
			}

			return false;
		}
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