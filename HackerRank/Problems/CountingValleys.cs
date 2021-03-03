namespace HackerRank.Problems
{
    public static class CountingValley
    {
        public static int Execute(int n, string path)
        {
            int valleyCount = 0;
            int count = 0;
            bool isFromUpToDown = false;

            var itemsInPath = path.ToCharArray();
            foreach (var item in itemsInPath)
            {
                if (count == 0 && !isFromUpToDown && item == 'U')
                {
                    isFromUpToDown = true;
                }

                if (item == 'U')
                    count += 1;

                if (item == 'D')
                    count -= 1;

                if (count == 0)
                {
                    if (!isFromUpToDown)
                    {
                        valleyCount += 1;
                    }

                    isFromUpToDown = false;
                }
            }

            return valleyCount;
        }
    }
}
