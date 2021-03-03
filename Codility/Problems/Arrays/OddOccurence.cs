using System.Collections.Generic;
using System.Linq;

namespace Codility.Problems.Arrays
{
    public static class OddOccurence
    {
        public static int Execute(int[] a)
        {
            if (a.Length == 1)
                return a[0];

            if (a.Length % 2 == 0)
                return 0;

            var has = new HashSet<int>();

            foreach (var i in a)
                if (has.Contains(i))
                    has.Remove(i);
                else
                    has.Add(i);

            return has.Count > 0 ? has.First() : 0;
        }
    }
}