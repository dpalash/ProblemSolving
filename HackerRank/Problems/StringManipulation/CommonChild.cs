namespace HackerRank.Problems.StringManipulation
{
    public static class CommonChild
    {
        public static int Execute(string s1, string s2)
        {
            var c = new int[s1.Length + 1, s2.Length + 1];

            for (int i = 0; i < s1.Length; i++) //1 to m
            {
                for (int j = 0; j < s2.Length; j++) //1 to n
                {
                    if (s1[i] == s2[j]) //Xm == Yn
                    {
                        c[i + 1, j + 1] = c[i, j] + 1;
                    }
                    else if (c[i, j + 1] >= c[i + 1, j]) //compare Xm-1 to Yn
                    {
                        c[i + 1, j + 1] = c[i, j + 1];
                    }
                    else
                    {
                        c[i + 1, j + 1] = c[i + 1, j];
                    }
                }
            }

            return c[s1.Length, s2.Length];

            //int maxLengthCc = 0;
            //int retryCount = 0;

            //do
            //{
            //    var ccCount = 0;
            //    var previousMatchedIndex = 0;
            //    for (int i = retryCount; i < s1.Length; i++)
            //    {
            //        if (previousMatchedIndex == s2.Length - 1)
            //            break;

            //        for (int j = previousMatchedIndex; j < s2.Length; j++)
            //        {
            //            if (s1[i] == s2[j])
            //            {
            //                ccCount += 1;
            //                previousMatchedIndex = j + 1;
            //                break;
            //            }
            //        }
            //    }

            //    if (ccCount > maxLengthCc)
            //        maxLengthCc = ccCount;

            //    retryCount += 1;

            //} while (s1.Length > retryCount);


            //return maxLengthCc;
        }
    }
}
