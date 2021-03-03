using System;

namespace HackerRank.Problems.Sorting
{
    public static class BubbleSort
    {
        public static void Execute(int[] a)
        {
            int swapCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        var temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;

                        swapCount += 1;
                    }
                }
            }

            Console.WriteLine($"Array is sorted in {swapCount} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[a.Length - 1]}");
        }
    }
}
