using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Problems
{
    public static class HashTablesRansomNote
    {
        public static void Execute(string[] magazine, string[] note)
        {
            Array.Sort(magazine);

            Array.Sort(note);

            List<string> magList = magazine.ToList();

            foreach (string item in note)
            {
                if (!magList.Remove(item))
                {
                    Console.WriteLine("No");
                    break;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
