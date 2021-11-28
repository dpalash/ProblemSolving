using System;
using System.Collections.Generic;
using HackerRank.Problems.Interviews.Prestatech;

namespace HackerRank
{
    static class Program
    {
        static void Main(string[] args)
        {
            //string expression = Console.ReadLine().Trim();
            //string variables = Console.ReadLine().Trim();

            try
            {
                //int result = ProfileTarget.Execute(new List<int>() { 6, 1, 3, 46, 1, 3, 9 }, 47);
                //Console.ReadKey();

                int result = ParkingDilemma.Execute(new List<int>() { 6, 2, 12, 7 }, 3);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                // 1 2 3 4 5 6 7
            }
        }
    }
}
