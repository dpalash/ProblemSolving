using System;

namespace Codility.Problems.TimeComplexity
{
    public static class PermMissingElem
    {
        public static int Execute(int[] a)
        {
            if (a.Length == 0)
                return 1;

            Array.Sort(a);

            int startCount = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != startCount)
                {
                    break;
                }

                startCount += 1;
            }

            return startCount;
        }
    }
}