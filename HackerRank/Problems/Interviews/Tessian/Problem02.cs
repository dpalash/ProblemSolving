using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Problems.Interviews.Tessian
{
    public static class Problem02
    {
        public static int Execute(string expression, string variables)
        {
            int result = 0;

            var varDictionary = new Dictionary<string, string>();

            var expressionSplits = expression.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            int invalidCount = expressionSplits.Count(x => x == "0");

            if (invalidCount > 0)
                throw new Exception();

            int operatorCount = expressionSplits.Count(x => x == "+" || x == "-" || x == "*" || x == "/");

            int valueCount = expressionSplits.Count(x => x != "+" && x != "-" && x != "*" && x != "/");

            if (operatorCount > 0 && expressionSplits.Length < 3)
                throw new Exception();

            if (operatorCount + 1 != valueCount)
                throw new Exception();


            if (!string.IsNullOrWhiteSpace(variables))
            {
                varDictionary = variables
                    .Replace(" ", "")
                    .Replace("{", "")
                    .Replace("}", "")
                    .Replace(@"\", "")
                    .Replace(@"""", "")
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(part => part.Split(':'))
                    .ToDictionary(split => split[0], split => split[1]);
            }

            for (int i = expressionSplits.Length - 1; i >= 0; i--)
            {
                if (string.IsNullOrWhiteSpace(expressionSplits[i]))
                    continue;

                if (int.TryParse(expressionSplits[i], out var currentValue))
                {
                    if (varDictionary.Any() && varDictionary.ContainsKey(currentValue.ToString()))
                    {
                        expressionSplits[i] = varDictionary[expressionSplits[i]];
                        continue;
                    }

                    result = currentValue;
                    continue;
                }

                if (expressionSplits[i] == "+")
                    result = int.Parse(expressionSplits[i + 1]) + int.Parse(expressionSplits[i + 2]);

                else if (expressionSplits[i] == "-")
                    result = int.Parse(expressionSplits[i + 1]) - int.Parse(expressionSplits[i + 2]);

                else if (expressionSplits[i] == "*")
                    result = int.Parse(expressionSplits[i + 1]) * int.Parse(expressionSplits[i + 2]);

                else if (expressionSplits[i] == "/")
                    result = int.Parse(expressionSplits[i + 1]) / int.Parse(expressionSplits[i + 2]);

                else
                {
                    if (varDictionary.Any() && varDictionary.ContainsKey(expressionSplits[i]))
                    {
                        expressionSplits[i] = varDictionary[expressionSplits[i]];
                        continue;
                    }

                    throw new Exception();
                }

                expressionSplits[i] = result.ToString();
                expressionSplits = expressionSplits.RemoveAt(i + 1);
                expressionSplits = expressionSplits.RemoveAt(i + 1);
            }

            return result;
        }

        public static T[] RemoveAt<T>(this T[] source, int index)
        {
            T[] dest = new T[source.Length - 1];
            if (index > 0)
                Array.Copy(source, 0, dest, 0, index);

            if (index < source.Length - 1)
                Array.Copy(source, index + 1, dest, index, source.Length - index - 1);

            return dest;
        }
    }
}
