using System;

namespace Lesson1
{
    class Program
    {

        //6.	Write a program which will ask the user about circle radius and then calculate and
        // display area and circumference of the circle.

        static void Main(string[] args)
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
