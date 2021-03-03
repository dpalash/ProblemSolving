namespace Codility.Problems.PrefixSums
{
    public static class CountDiv
    {
        public static int Execute(int a, int b, int k)
        {
            var mod = a % k;

            int range = (b + mod - a);

            int result = range / k;

            if (mod == 0)
                result += 1;

            return result;

            //int count = (B / K - A / K) + (A % K == 0 ? 1 : 0);
            //return count;

            //var mod = A % K;
            //return (mod == 0 ? 1 : 0) + (B + mod - A) / K;
        }
    }
}