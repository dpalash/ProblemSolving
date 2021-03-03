using System.Collections.Generic;

namespace Codility.Problems.PrefixSums
{
    public static class GenomicRangeQuery
    {
        class LinkedValue
        {
            public int Value;
            public int? NextMinimum;
        }

        public static int[] Execute(string s, int[] p, int[] q)
        {
            //Dictionary<string, int> dnaSequenceDictionary = new Dictionary<string, int>
            //{
            //    {"A", 1},
            //    {"C", 2},
            //    {"G", 3},
            //    {"T", 4}
            //};

            //var stringAsCharArray = S.ToCharArray();
            //int[] result = new int[P.Length];

            //for (int i = 0; i < P.Length; i++)
            //{

            //    var key1 = stringAsCharArray[P[i]];
            //    var key2 = stringAsCharArray[Q[i]];

            //    var difference = dnaSequenceDictionary[$"{key1}"] > dnaSequenceDictionary[$"{key2}"] ? dnaSequenceDictionary[$"{key2}"] : dnaSequenceDictionary[$"{key1}"];
            //    result[i] = difference;
            //}

            //return result;

            var impactMap = new Dictionary<char, int> {
            { 'A', 1 },
            { 'C', 2 },
            { 'G', 3 },
            { 'T', 4 },
        };
            var impact = new LinkedValue[s.Length];
            var stack = new Stack<LinkedValue>();
            for (var i = -1; ++i < s.Length;)
            {
                impact[i] = new LinkedValue
                {
                    Value = impactMap[s[i]],
                    NextMinimum = null
                };
                while (stack.Count > 0 && impact[i].Value < stack.Peek().Value)
                    stack.Pop().NextMinimum = i;
                if (impact[i].Value > 1)
                    stack.Push(impact[i]);
            }
            var r = new int[p.Length];
            for (var i = -1; ++i < p.Length;)
            {
                var current = impact[p[i]];
                if (current.Value > 1)
                    while ((current.NextMinimum ?? q[i] + 1) <= q[i])
                        current = impact[current.NextMinimum.Value];
                r[i] = current.Value;
            }
            return r;
        }
    }
}