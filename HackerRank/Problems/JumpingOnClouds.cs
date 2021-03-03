using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Problems
{
    public static class JumpingOnClouds
    {
        public static int Execute(int[] c)
        {
            int jumpCount = 0;
            List<int> indexArray = new List<int>();

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 0)
                    indexArray.Add(i);
            }

            for (int i = 0; i < indexArray.Count;)
            {
                var value = indexArray[i];

                var nextValue = indexArray.FirstOrDefault(x => x == value + 2);
                if (nextValue == 0)
                    nextValue = indexArray.FirstOrDefault(x => x == value + 1);

                if (nextValue == 0)
                    break;

                i = indexArray.IndexOf(nextValue);

                jumpCount += 1;

            }
            
            return jumpCount;
        }
    }
}
