using System;
using System.Collections.Generic;
using System.Text;

namespace BasicStructures
{
    public static class StringUtils
    {
        public static string Clean(string input) => 
            string.Join(' ', input.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries));

        public static int CountVowels(string input)
        {
            var temp = input
                .Replace("a", "")
                .Replace("e", "")
                .Replace("o", "")
                .Replace("u", "")
                .Replace("i", "")
                .Replace("y", "");

            return input.Length - temp.Length;
        }
    }
}
