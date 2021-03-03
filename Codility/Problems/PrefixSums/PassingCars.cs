namespace Codility.Problems.PrefixSums
{
    public static class PassingCars
    {
        public static int Execute(int[] a)
        {
            int count = 0;
            int multiply = 0;
            foreach (int car in a)
            {
                if (car == 0)
                {
                    multiply = multiply + 1;
                }
                if (multiply > 0)
                {
                    if (car == 1)
                    {
                        count = count + multiply;
                        if (count > 1000000000)
                        {
                            return -1;
                        }
                    }
                }
            }
            return count;
        }
    }
}