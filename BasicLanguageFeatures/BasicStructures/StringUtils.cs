using System;
using System.Collections.Generic;
using System.Text;

namespace BasicStructures
{
    public static class StringUtils
    {
        public static int CountVowels(string input) // Military -> Militry -> Militry -> Militry -> Militry -> Mltry -> Mltr
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
