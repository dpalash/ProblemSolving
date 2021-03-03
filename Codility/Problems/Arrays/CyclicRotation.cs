using System.Linq;

namespace Codility.Problems.Arrays
{
    public static class CyclicRotation
    {
        public static int[] Execute(int[] a, int k)
        {
            if (k <= 0 || a.Length <= 1 || a.Length == k)
                return a;

            if (k > a.Length)
                k = k % a.Length;

            var firstPart = a.Skip(a.Length - k).Take(k).ToArray();
            var lastPart = a.Take(a.Length - k).ToArray();

            return firstPart.Concat(lastPart).ToArray();
        }
    }
}