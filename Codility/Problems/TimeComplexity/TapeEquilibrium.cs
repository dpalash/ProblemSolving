using System;
using System.Linq;

namespace Codility.Problems.TimeComplexity
{
    public static class TapeEquilibrium
    {
        public static int Execute(int[] a)
        {
            //int left = A[0], right = A[1];
            //for (var i = 1; ++i < A.Length; right += A[i])
            //    ;
            //int min = Math.Abs(left - right);

            //for (var P = 1; ++P < A.Length;)
            //{
            //    int sum = Math.Abs((left += A[P - 1]) - (right -= A[P - 1]));
            //    if (sum < min)
            //        min = sum;
            //}
            //return min;


            int minSum = -1;

            for (int i = 0; i < a.Length; i++)
            {
                var firstPartSum = a.Take(i).Sum();
                var secondPartSum = a.Skip(i).Sum();

                if (firstPartSum == 0 || secondPartSum == 0)
                    continue;

                var sum = Math.Abs(firstPartSum - secondPartSum);

                if (minSum == -1)
                    minSum = sum;

                if (sum < minSum)
                    minSum = sum;
            }

            return minSum;
        }
    }
}