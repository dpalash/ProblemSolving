using System.Linq;
using System.Text.RegularExpressions;

namespace HackerRank.Problems.StringManipulation
{
    public static class AlternatingCharacters
    {
        public static int Execute(string s)
        {
            int deletionCount = 0;

            var distinctCharacters = s.Distinct();
            foreach (var item in distinctCharacters)
            {
                var doubleString = $"{item}{item}";
                var itemAsString = item.ToString();

                while (s.Contains(doubleString))
                {
                    var occurenceCount = Regex.Matches(s, doubleString).Count;
                    s = s.Replace(doubleString, itemAsString);

                    deletionCount += occurenceCount;
                }
            }

            return deletionCount;
        }
    }
}
