namespace HackerRank.Problems.StringManipulation
{
    public static class Anagrams
    {
        public static int Execute(string a, string b)
        {
            int deletionCount = 0;
            int similarCharCount = 0;

            string tempA = a;
            string tempB = b;

            for (int i = 0; i < a.Length; i++)
            {
                var matchFound = false;

                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        matchFound = true;
                        b = b.Remove(j, 1);

                        similarCharCount += 1;

                        break;
                    }

                }

                if (!matchFound)
                {
                    a = a.Remove(i, 1);
                    i = i - 1;
                }
            }

            deletionCount += (tempA.Length - similarCharCount) + (tempB.Length - similarCharCount);

            return deletionCount;
        }
    }
}
