using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.Problems.Iterations
{
    public static class BinaryGap
    {
        public static int Execute(int n)
        {
            char[] binaryArray = Convert.ToString(n, 2).ToCharArray();

            int oneInArray = binaryArray.Distinct().Count();
            if (oneInArray == 1)
                return 0;

            List<int> indexList = new List<int>();
            for (int i = 0; i < binaryArray.Length; i++)
            {
                if (binaryArray[i] == 49)
                {
                    indexList.Add(i);
                }
            }

            int maxGap = 1;
            int[] indexArray = indexList.ToArray();
            for (int i = 0; i < indexArray.Length - 1; i++)
            {
                int diff = indexList[i + 1] - indexList[i];
                if (diff > maxGap)
                    maxGap = diff;
            }

            return maxGap > 1 ? maxGap - 1 : 0;
        }
    }
}
