using System;

namespace HackerRank.Problems.Sorting
{
    public static class MaximumToys
    {
        public static int Execute(int[] prices, int k)
        {
            Array.Sort(prices);

            int i = 0;
            int n = prices.Length;
            int totalPrice = 0;
            int toyCount = 0;

            while (i < n)
            {
                if (totalPrice + prices[i] <= k)
                {
                    totalPrice = totalPrice + prices[i];
                    toyCount += 1;
                }
                else
                {
                    break;
                }

                i++;
            }

            return toyCount;
        }
    }
}
