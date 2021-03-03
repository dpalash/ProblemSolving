using System;
using System.Linq;

namespace HackerRank.Problems.Arrays
{
    public static class NewYearChaos
    {
        public static string Execute(int[] q)
        {
            int bribeCount = 0;
            var sortedArray = q.ToArray();
            Array.Sort(sortedArray);

            for (int i = 0; i < q.Length; i++)
            {
                var index1 = Array.IndexOf(sortedArray, q[i]);

                if (index1 == i)
                    continue;

                var atATimeBribeDifference = Math.Abs(i - index1);

                if (atATimeBribeDifference > 2)
                    return "Too chaotic";

                bribeCount += atATimeBribeDifference;


                for (int j = index1; j > i; j--)
                {
                    var temp = sortedArray[j - 1];
                    sortedArray[j - 1] = sortedArray[j];
                    sortedArray[j] = temp;
                }
            }

            return bribeCount.ToString();
        }
    }
}
