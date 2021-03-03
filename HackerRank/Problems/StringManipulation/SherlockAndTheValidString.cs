using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HackerRank.Problems.StringManipulation
{
    public static class SherlockAndTheValidString
    {
        public static string Execute(string s)
        {
            string result = "YES";
            int duplicateOccurrenceCount = 0;

            var distinctCharacters = s.Distinct().ToList();
            if (distinctCharacters.Count == s.Length)
                return result;

            Dictionary<int, string> frequencyDictionary = new Dictionary<int, string>();

            foreach (var item in distinctCharacters)
            {
                var itemAsString = item.ToString();
                var occurenceCount = Regex.Matches(s, itemAsString).Count;
                if (!frequencyDictionary.ContainsKey(occurenceCount))
                    frequencyDictionary.Add(occurenceCount, itemAsString);
                else
                {
                    var valueInDic = frequencyDictionary[occurenceCount];
                    frequencyDictionary[occurenceCount] = valueInDic + itemAsString;
                }
            }


            if (frequencyDictionary.Count > 2)
                result = "NO";

            if (frequencyDictionary.Count > 1)
            {
                for (int i = 0; i < frequencyDictionary.Count - 1; i++)
                {
                    var currentItem = frequencyDictionary.ElementAt(i);
                    var nextItem = frequencyDictionary.ElementAt(i + 1);
                    if (Math.Abs(currentItem.Key - nextItem.Key) >= 2)
                    {
                        if (currentItem.Key == 1)
                        {
                            if (currentItem.Value.Length != 1)
                            {
                                result = "NO";
                                break;
                            }
                        }
                        if (nextItem.Key == 1)
                        {
                            if (nextItem.Value.Length != 1)
                            {
                                result = "NO";
                                break;
                            }
                        }
                        if (currentItem.Value.Length == 1)
                        {
                            if (currentItem.Key > 1)
                            {
                                result = "NO";
                                break;
                            }
                        }
                        if (nextItem.Value.Length == 1)
                        {
                            if (nextItem.Key > 1)
                            {
                                result = "NO";
                                break;
                            }
                        }
                    }
                }

                foreach (var item in frequencyDictionary)
                {
                    if (item.Value.Length >= 2)
                        duplicateOccurrenceCount += 1;

                    if (duplicateOccurrenceCount > 1)
                    {
                        result = "NO";
                        break;
                    }
                }
            }

            return result;
        }
    }
}
