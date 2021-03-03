namespace HackerRank.Problems.Arrays
{
    public static class HourGlass
    {
        public static int Execute(int[][] arr)
        {
            int result = -1000;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    var sum = 0;
                    int skipCount = 0;

                    for (int k = j; k < j + 3; k++)
                    {
                        if (skipCount == 1)
                        {
                            sum += arr[k][i + 1];
                            skipCount = 0;
                            continue;
                        }

                        skipCount += 1;

                        for (int l = i; l < i + 3; l++)
                        {
                            sum += arr[k][l];
                        }
                    }

                    if (sum >= result)
                        result = sum;
                }
            }

            return result;
        }
    }
}
