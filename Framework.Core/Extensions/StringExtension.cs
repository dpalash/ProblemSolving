using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Core.Extensions
{
    public static class StringExtension
    {
        public static bool ContainsAny(this string str, params string[] items)
        {
            foreach (string item in items)
            {
                if (str.IndexOf(item, StringComparison.OrdinalIgnoreCase) >= 0)
                    return true;
            }

            return false;
        }

        public static string ReplaceFirst(this string text, string search, string replace)
        {
            int pos = text.IndexOf(search, StringComparison.CurrentCultureIgnoreCase);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }

        static IEnumerable<string> Split(this string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize).Select(i => str.Substring(i * chunkSize, chunkSize));
        }
    }
}
