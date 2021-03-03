namespace HackerRank.Problems.Arrays
{
    public static class MinimumSwap
    {
        public static int Execute(int[] arr)
        {
            int i = 0;
            int swapCount = 0;
            int n = arr.Length;

            while (i < n)
            {
                if (arr[i] != i + 1)
                {
                    var temp = arr[i];
                    arr[i] = arr[temp - 1];
                    arr[temp - 1] = temp;
                    swapCount++;
                }
                else
                {
                    i++;
                }
            }

            return swapCount;
        }
    }
}
