using System;
using System.Linq;

namespace HackerRank.Problems.StringManipulation
{
    public static class SuperReducedString
    {
        public static string Execute(string s)
        {
            var array = s.ToArray();
            Array.Sort(array);
            s = string.Join("", array);
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    s = s.Remove(i, 2);
                    i = -1;
                }
            }


            return string.IsNullOrWhiteSpace(s) ? "Empty String" : s;

        }
    }
}
