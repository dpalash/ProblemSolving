using System.Linq;

namespace HackerRank.Problems
{
    public static class RepeatedString
    {
        public static long Execute(string s, long n)
        {
            if (s.Contains("a") && s.Distinct().Count() == 1)
                return n;

            var countInActual = s.Count(x => x == 'a') * (n / s.Length);

            bool needExtra = n % s.Length != 0;
            if (needExtra)
            {
                var extraLength = n % s.Length;

                var js = s.ToCharArray(0, (int)extraLength);

                countInActual = countInActual + js.Count(x => x == 'a');
            }

            return countInActual;
        }
    }
}
