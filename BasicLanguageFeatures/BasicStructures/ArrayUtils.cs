using System;
using System.Collections.Generic;
using System.Text;

namespace BasicStructures
{
    public static class ArrayUtils
    {
        public static void Reverse1(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
        }

        public static int[] Round(decimal[] inputArray)
        {
            var result = new int[inputArray.Length];

            for (var i = 0; i < inputArray.Length; i++) 
                result[i] = (int) inputArray[i];

            return result;
        }

        public static int[] Round(int[] inputArray, int threshold)
        {
            var result = new List<int>();

            foreach (var element in inputArray)
                if (element >= threshold)
                    result.Add(element);

            return result.ToArray();
        }

        public static int[] Diagonal(int[,] inputArray)
        {
            var result = new int[inputArray.GetLength(0)];

            for (var i = 0; i < result.Length; i++) 
                result[i] = inputArray[i, i];

            return result;
        }
    }
}
