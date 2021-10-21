using System;
using HackerRank.Problems.Interviews.Tessian;

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
                int result = Problem02.Execute("* - + 2 3 x * y 4", "{ \"x\": 1, \"y\": 3, \"4\": 5 }");
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                // 1 2 3 4 5 6 7
            }
        }
    }
}
