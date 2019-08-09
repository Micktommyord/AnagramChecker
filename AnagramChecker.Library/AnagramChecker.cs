using System;
using System.Collections.Generic;

namespace AnagramChecker.Library
{
    public class AnagramChecker
    {
        public static bool CheckLengthEqual(string v1, string v2)
        {
            return v1.Length == v2.Length;
        }

        public static Dictionary<char, int> CalculateFrequency(string input)
        {
            var frequency = new Dictionary<char, int>();

            foreach (var c in input)
            {
                if(!frequency.ContainsKey(c))
                {
                    frequency.Add(c, 0);
                }
                ++frequency[c];
            }

            return frequency;
        }

        public static bool IsAnagram(string input)
        {
            if (!StringSplitIntoTwoWords(input))
                return false;

            var splitStrings = input.Split(" ");
            if (!CheckLengthEqual(splitStrings[0], splitStrings[1]))
                return false;

            var aFrequency = CalculateFrequency(splitStrings[0]);
            var bFrequency = CalculateFrequency(splitStrings[1]);

            foreach (var key in aFrequency.Keys)
            {
                if (!bFrequency.ContainsKey(key)) return false;
                if (aFrequency[key] != bFrequency[key]) return false;
            }

            return true;
        }

        public static bool StringSplitIntoTwoWords(string input)
        {
            var splitStrings = input.Split(" ");

            return splitStrings.Length == 2;
        }
    }
}
