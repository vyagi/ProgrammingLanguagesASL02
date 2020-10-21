using System;

namespace Lesson1
{
    class Program
    {

        static void Main(string[] args)
        {
            
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
