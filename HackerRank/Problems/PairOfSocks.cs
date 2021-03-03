using System.Linq;

namespace HackerRank.Problems
{
    public static class PairOfSocks
    {
        public static int Execute(int n, int[] ar)
        {
            int count = 0;

            var groupedSocks = ar.GroupBy(x => x);

            foreach (var item in groupedSocks)
            {
                if (item.Count() > 1)
                    count += item.Count() / 2;
            }

            return count;
        }
    }
}
