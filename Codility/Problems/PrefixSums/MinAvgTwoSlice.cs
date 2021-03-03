namespace Codility.Problems.PrefixSums
{
    public static class MinAvgTwoSlice
    {
        public static int Execute(int[] a)
        {
            int minI = 0;
            double minValue = 100001.0;

            for (int i = 0; i < a.Length - 1; i++)
            {

                if ((a[i] + a[i + 1]) / 2.0 < minValue)
                {
                    minI = i;
                    minValue = (a[i] + a[i + 1]) / 2.0;

                }
                if (i < a.Length - 2)
                {
                    if ((a[i] + a[i + 1] + a[i + 2]) / 3.0 < minValue)
                    {
                        minI = i;
                        minValue = (a[i] + a[i + 1] + a[i + 2]) / 3.0;
                    }
                }
            }

            return minI;
        }
    }
}