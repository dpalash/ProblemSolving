using System.Collections.Generic;

namespace Codility.Problems.CountingElements
{
    public static class MissingInteger
    {
        public static int Execute(int[] a)
        {
            int min = 1;
            HashSet<int> numbers = new HashSet<int>();
            foreach (int n in a)
            {
                if (!numbers.Contains(n))
                {
                    numbers.Add(n);
                    if (n == min)
                        while (numbers.Contains(++min)) ;
                }
            }
            return min;
        }
    }
}