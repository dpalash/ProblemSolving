using System;

namespace Codility.Problems.Sorting
{
    public static class MaxProductOfThree
    {
        public static int Execute(int[] a)
        {
            Array.Sort(a);

            return a[a.Length - 1] * a[a.Length - 2] * a[a.Length - 3];
        }
    }
}