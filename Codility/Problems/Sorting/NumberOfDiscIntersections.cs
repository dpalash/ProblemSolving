namespace Codility.Problems.Sorting
{
    public static class NumberOfDiscIntersections
    {
        public static int Execute(int[] a)
        {
            int result = 0;
            int[] dps = new int[a.Length];
            int[] dpe = new int[a.Length];

            int t;
            var i = 0;
            for (t = a.Length - 1; i < a.Length; i++)
            {
                int s = i > a[i] ? i - a[i] : 0;
                int e = t - i > a[i] ? i + a[i] : t;
                dps[s]++;
                dpe[e]++;
            }

            t = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (dps[i] > 0)
                {
                    result += t * dps[i];
                    result += dps[i] * (dps[i] - 1) / 2;
                    if (10000000 < result) return -1;
                    t += dps[i];
                }
                t -= dpe[i];
            }

            return result;
        }
    }
}