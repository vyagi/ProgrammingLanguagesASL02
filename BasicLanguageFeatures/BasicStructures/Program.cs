using System;
using System.Collections.Generic;

namespace BasicStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringUtils.Clean("      The    lord    of the    rings  "));
        }

        private static void CountVowelsExample()
        {
            var name = "Marcin Jagiela";
            Console.WriteLine(StringUtils.CountVowels(name));
        }

        private static void ZipExample()
        {
            int[] array1 = {1, 2, 3};
            int[] array2 = {3, 2, 1, 5};

            foreach (var element in ArrayUtils.Zip(array1, array2))
            {
                Console.WriteLine(element);
            }
        }

        private static void AccumulateExample()
        {
            int[] arr = {1, 5, 9}; // expect 1, 6, 15
            var result = ArrayUtils.Accumulate(arr);
            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
        }

        private static void DiagonalExample()
        {
            int[,] array = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            var result = ArrayUtils.Diagonal(array);

            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
        }

        private static void Round2Example()
        {
            int[] array = {4, 1, 2, 6, 1};
            var result = ArrayUtils.Round(array, 1);

            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
        }

        private static void ReverseAndRoundExample()
        {
            int[] myArray = { 5, 8, 9, 1, 10 };
            ArrayUtils.Reverse1(myArray);

            foreach (var element in myArray)
            {
                Console.WriteLine(element);
            }

            decimal[] arrayOfDecimals = { 1.4M, 5.6M, 10.8M };
            var result = ArrayUtils.Round(arrayOfDecimals);

            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
        }

        private static void DivisorAndMultiplierExample()
        {
            int multiplied = MultiplyForMeBy3(50);
            Console.WriteLine(multiplied);

            multiplied = MultiplyForMe(6, 8);
            Console.WriteLine(multiplied);

            Console.WriteLine(GreatestCommonDivisor(16, 12));
            Console.WriteLine(GreatestCommonDivisor(36, 48));

            int lcm, gcd;
            DivisorAndMultiplier(6, 9, out gcd, out lcm);

            Console.WriteLine($"{gcd}, {lcm}");

            var result = DivisorAndMultiplier(6, 9);
            Console.WriteLine($"{result.Gcd}, {result.Lcm}");
        }

        private static (int Gcd, int Lcm) DivisorAndMultiplier(int a, int b)
        {
            int divisor = GreatestCommonDivisor(a, b);
            int multiplier = a * b / divisor;
            return (divisor, multiplier);
        }

        // private static Tuple<int, int> DivisorAndMultiplier(int a, int b)
        // {
        //     int divisor = GreatestCommonDivisor(a, b);
        //     int multiplier = a * b / divisor;
        //     return new Tuple<int, int>(divisor, multiplier);
        // }

        //6,9 => lcm is ?  18
        //This is one of the worst options, you should avoid it, but you have to know it
        private static void DivisorAndMultiplier(int a, int b, out int divisor, out int multiplier)  
        {
            //Now how to return them back

            divisor = GreatestCommonDivisor(a, b);
            multiplier = a * b / divisor;
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            
            return a;
        }

        private static int MultiplyForMe(int numberToMultiply, int multiplier) =>   //new syntax is called expression body (expression bodied methods)
            numberToMultiply * multiplier;

        private static int MultiplyForMeBy3(int numberToMultiply)
        {
            int result = numberToMultiply * 3;
            return result;
        }
        
        private static void StringsJoiningExample()
        {
            string name = "Marcin";
            string surname = "Jagieła";

            // Console.Write(name);
            // Console.Write(" ");
            // Console.WriteLine(surname);

            // string fullName = name + " " + surname;
            // string fullName = string.Format("{0} {1}", name, surname);
            string
                fullName = $"{name} {surname}"; //string interpolation - this is what you should use in daily work - get used to it

            Console.WriteLine(fullName);

            decimal pricePerOunce = 17.36m;
            string s = string.Format("The current price is {0:C2} per ounce.", pricePerOunce);
            Console.WriteLine(s);
        }
    }
}
