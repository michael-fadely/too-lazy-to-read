using System;
using System.Text.RegularExpressions;
using IniFile;

namespace TooLazyToRead
{
	public enum FilterType
	{
		Plain,
		Wildcard,
		Regex
	}

	public class Filter : ICloneable
	{
		[IniAlwaysInclude] public string Name;
		[IniAlwaysInclude] public bool Enabled;
		[IniAlwaysInclude] public string Description;
		[IniAlwaysInclude] public FilterType Type;
		[IniAlwaysInclude] public bool CaseSensitive;
		[IniAlwaysInclude] public string MatchText;
		[IniAlwaysInclude] public string ReplaceText;
		[IniAlwaysInclude] public bool EscapeReplace;

		[IniIgnore] public bool CachedRegex;
		[IniIgnore] private string cachedMatchText;

		public string DoFilter(string input, bool forceRun = false)
		{
			// TODO: Benchmark regex match checking and string replacement

			if (!forceRun && !Enabled)
			{
				return input;
			}

			string result = input;
			RegexOptions regexOptions = CaseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase;

			switch (Type)
			{
				case FilterType.Plain:
					if (Regex.IsMatch(input, MatchText, regexOptions))
					{
						result = Regex.Replace(input, Regex.Escape(MatchText), !EscapeReplace ? Regex.Unescape(ReplaceText) : ReplaceText, regexOptions);
					}

					break;

				case FilterType.Wildcard:
					if (!CachedRegex)
					{
						cachedMatchText = GlobToRegex(MatchText);
						CachedRegex = true;
					}

					if (Regex.IsMatch(input, cachedMatchText, regexOptions))
					{
						result = Regex.Replace(input, cachedMatchText, !EscapeReplace ? Regex.Unescape(ReplaceText) : ReplaceText, regexOptions);
					}

					break;

				case FilterType.Regex:
					if (Regex.IsMatch(input, MatchText, regexOptions))
					{
						result = Regex.Replace(input, MatchText, !EscapeReplace ? Regex.Unescape(ReplaceText) : ReplaceText, regexOptions);
					}

					break;

				default:
					throw new ArgumentOutOfRangeException();
			}

			return result;
		}

		public static string GlobToRegex(string input)
		{
			string result = input;

			result = Regex.Replace(result, @"([\\\+\|\{\}\[\]\^\$\.\#])", @"\$1");
			result = result.Replace("*", ".*");
			result = result.Replace("?", ".");

			return result;
		}

		public object Clone()
		{
			return MemberwiseClone();
		}
	}
}