namespace Codility.Problems.TimeComplexity
{
    public static class FrogJump
    {
        public static int Execute(int x, int y, int d)
        {
            int jumpCount = (y - x) % d == 0 ? (y - x) / d : (y - x) / d + 1;

            return jumpCount;
        }
    }
}