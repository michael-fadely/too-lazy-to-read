using System;
using System.Collections.Generic;
using System.Linq;

namespace TooLazyToRead
{
	internal static class Extensions
	{
		public static List<T> Clone<T>(this IEnumerable<T> listToClone) where T : ICloneable
		{
			return listToClone.Select(item => (T)item.Clone()).ToList();
		}
	}
}