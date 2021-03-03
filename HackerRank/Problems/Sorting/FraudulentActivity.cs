using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Problems.Sorting
{
    public static class FraudulentActivity
    {
        public static int Execute(int[] expenditure, int d)
        {
            //int fraudCount = 0;
            //int skipCount = 0;

            //for (int i = d; i < expenditure.Length; i++)
            //{
            //    var median = expenditure.Skip(skipCount).Take(d).Average();
            //    if (median * 2 <= expenditure[i])
            //        fraudCount += 1;

            //    skipCount += 1;
            //}

            //return fraudCount;

            //Random rnd = new Random();
            //int[] intArr = new int[100];

            //for (int i = 0; i < intArr.Length; i++)
            //{
            //    int num = rnd.Next(1, 1000);
            //    intArr[i] = num;
            //    Console.WriteLine(num);
            //}


            int fraudCount = 0;
            Queue<int> summationArray = new Queue<int>();
            int summation = 0;

            //expenditure = intArr;
            for (int i = d; i < expenditure.Length; i++)
            {
                int current = expenditure[i];
                if (i == d)
                {
                    var items = expenditure.Take(d).ToArray();
                    foreach (var item in items)
                    {
                        summationArray.Enqueue(item);
                    }
                }

                if (summation == 0)
                {
                    summation = summationArray.Sum();
                }
                else
                {
                    summation = summation - summationArray.First() + expenditure[i - 1];

                    summationArray.Dequeue();
                    summationArray.Enqueue(current);
                }

                var median = Math.Ceiling((double)summation / d);

                if (median * 2 <= current)
                    fraudCount += 1;
            }

            return fraudCount;
        }
    }
}
