using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Problems.Interviews.Prestatech
{
    public static class ParkingDilemma
    {
        public static int Execute(List<int> cars, int k)
        {
            int result = 0;
            var sortedCars = cars.OrderBy(x => x).ToList();

            for (int i = 0; i < k; i++)
            {
                var batch = sortedCars.Skip(i).Take(k).ToList();
                if (batch.Count < k)
                    continue;

                var first = batch.First();
                var last = batch.Last();

                if (result == 0)
                    result = last - first + 1;
                else if (last - first < result)
                    result = last - first + 1;
            }

            return result;
        }
    }
}
