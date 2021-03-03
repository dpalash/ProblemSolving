using System.Linq;

namespace Codility.Problems.CountingElements
{
    public static class PermCheck
    {
        public static int Execute(int[] a)
        {
            int permutation = 1;

            int[] newA = a.ToArray();
            newA = newA.Distinct().ToArray();

            if (newA.Length != a.Length)
                return 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (!a.Contains(i + 1))
                {
                    permutation = 0;
                    break;
                }
            }


            return permutation;
        }
    }
}