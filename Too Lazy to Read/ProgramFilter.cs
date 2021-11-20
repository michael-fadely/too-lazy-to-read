using System;
using System.Text.RegularExpressions;
using IniFile;

namespace TooLazyToRead
{
    public class ProgramFilter : ICloneable
    {
        [IniAlwaysInclude] public string Filename;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
