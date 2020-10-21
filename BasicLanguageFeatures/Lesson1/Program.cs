using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void Program10c()
        {
            var list = new List<int>();

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter the number no {i + 1}");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum = sum + list[i];
            }

            var average = 1.0 * sum / list.Count;
            Console.WriteLine($"Sum is {sum} and average is {average}");

            Console.WriteLine("Without loops:");    //This is thanks to LINQ (we will discuss LINQ in detail later)
            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Average());
        }

        private static void Program10b()
        {
            var myArray = new int[4];

            for (var i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Enter the number no {i + 1}");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            var sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sum = sum + myArray[i];
            }

            var average = 1.0 * sum / myArray.Length;
            Console.WriteLine($"Sum is {sum} and average is {average}");

            Console.WriteLine("Without loops:");    //This is thanks to LINQ (we will discuss LINQ in detail later)
            Console.WriteLine(myArray.Sum());
            Console.WriteLine(myArray.Average());
        }

        private static void Program10a()
        {
            //It can be easily  done without introducing so many variables, but this is to show some technical things
            Console.Write("Enter the first number: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            var c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            var d = Convert.ToInt32(Console.ReadLine());

            var sum = a + b + c + d;
            var average = sum / 4.0;

            Console.WriteLine($"Sum is {sum} and average is {average}");
        }
        private static void Program9()
        {
            Console.Write("Enter the temperature in celsius: ");
                
            var celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In Kelvins: {0}", celsius + 273.15);
            Console.WriteLine("In Fahrenheit: {0}", celsius * 18 / 10 + 32);
        }
        private static void Program8()
        {
            Console.WriteLine("Enter length of first side of a triangle");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter length of second side of a triangle");
            var b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter length of third side of a triangle");
            var c = Convert.ToDouble(Console.ReadLine());

            var perimeter = a + b + c;

            var halfOfPerimeter = perimeter / 2;

            var area = Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - a) * (halfOfPerimeter - b) * (halfOfPerimeter - c));

            Console.WriteLine($"Area is {area} and perimeter is {perimeter}");
        }

        private static void Program7()
        {
            Console.WriteLine("Enter height of a triangle");
            var height = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter base of a triangle");
            var basee = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Area is {0.5 * height * basee} ");
        }

        private static void Program6()
        {
            Console.WriteLine("Enter the radius of the circle");
            var radiusInput = Console.ReadLine();

            // var radius = double.Parse(radiusInput);  //and the other way is
            var radius = Convert.ToDouble(radiusInput);

            var area = Math.PI * radius * radius;
            var perimeter = 2 * Math.PI * radius;

            Console.WriteLine($"Area is {area} and perimeter is {perimeter}");
        }
    }
}
