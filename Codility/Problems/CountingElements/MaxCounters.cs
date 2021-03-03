using System;

namespace Codility.Problems.CountingElements
{
    public static class MaxCounters
    {
        public static int[] Execute(int n, int[] a)
        {
			var counters = new int[n];
            int max = 0, min = 0;
            foreach (var item in a)
                if (n == item + 1)
                    min = max;
                else
                {
                    var v = counters[n - 1];
                    if ((counters[n - 1] = Math.Max(v, min) + 1) > max)
                        max = counters[n - 1];
                }

            for (int i = counters.Length; --i >= 0;)
                if (counters[i] < min)
                    counters[i] = min;

            return counters;
		}
    }
}