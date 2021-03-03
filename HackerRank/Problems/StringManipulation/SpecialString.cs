namespace HackerRank.Problems.StringManipulation
{
    public static class SpecialString
    {
        public static long Execute(int n, string s)
        {
            // Accepted one
            long specialStringCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var startChar = s[i];
                int diffCharIdx = -1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    var currentChar = s[j];
                    if (startChar == currentChar)
                    {
                        if (diffCharIdx == -1 || j - diffCharIdx == diffCharIdx - i)
                            specialStringCount++;
                    }
                    else
                    {
                        if (diffCharIdx == -1)
                            diffCharIdx = j;
                        else
                            break;
                    }
                }
            }

            specialStringCount += s.Length;

            return specialStringCount;

            // My Code

            //long specialStringCount = 0;
            //var median = (double)n / 2;
            //int trial = (int)Math.Ceiling(median);

            //int takeCount = 2;
            //for (int i = 1; i <= trial; i++)
            //{
            //    for (int j = 0; j <= n - takeCount; j++)
            //    {
            //        if (takeCount % 2 == 0 && takeCount / 2 > 1)
            //            break;

            //        var subString = s.Substring(j, takeCount);
            //        if (takeCount % 2 == 0 && takeCount / 2 == 1)
            //        {
            //            int spCount = takeCount / 2;
            //            if (subString.Substring(0, spCount) == subString.Substring(spCount, spCount))
            //                specialStringCount += 1;
            //        }
            //        else
            //        {
            //            var mid = (takeCount / 2 + 1);
            //            var midChar = subString[mid - 1];
            //            var split = subString.Split(midChar);
            //            if (split[0] == split[1])
            //                specialStringCount += 1;
            //        }
            //    }

            //    takeCount += 1;
            //}

            //specialStringCount += s.Length;

            //if (s.Distinct().Count() == 1)
            //    specialStringCount += 1;

            //return specialStringCount;
        }
    }
}
