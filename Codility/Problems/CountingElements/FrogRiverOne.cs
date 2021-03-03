namespace Codility.Problems.CountingElements
{
    public static class FrogRiverOne
    {
        public static int Execute(int x, int[] a)
        {
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] == X)
            //        return i;
            //}

            //return -1;

            bool[] has = new bool[x];
            int count = 0;
            for (var i = -1; ++i < a.Length;)
            {
                if (!has[a[i] - 1])
                {
                    has[a[i] - 1] = true;
                    if (++count == x)
                        return i;
                }
            }

            return -1;
        }
    }
}