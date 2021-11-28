using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Problems.Interviews.Prestatech
{
    public static class ProfileTarget
    {
        public static int Execute(List<int> stocksProfit, long target)
        {
            Dictionary<int, int> outDictionary = new Dictionary<int, int>();

            for (int i = 0; i < stocksProfit.Count; i++)
            {
                for (int j = i + 1; j < stocksProfit.Count; j++)
                {
                    if (stocksProfit[i] + stocksProfit[j] == target)
                    {
                        if (!outDictionary.ContainsKey(stocksProfit[i]))
                        {
                            outDictionary.Add(stocksProfit[i], stocksProfit[j]);
                            continue;
                        }
                    }

                    if (stocksProfit[i] == stocksProfit[j] && stocksProfit[i] + stocksProfit[j] != target)
                        stocksProfit[j] = 0;
                }
            }

            return outDictionary.Count;
        }
    }
}
