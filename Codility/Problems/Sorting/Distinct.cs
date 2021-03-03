using System.Linq;

namespace Codility.Problems.Sorting
{
    public static class Distinct
    {
        public static int Execute(int[] a)
        {
            return a.Distinct().Count();
        }
    }
}