using System;
using HelloLibrary;
using Jagiela;

namespace HelloProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var instance = new HelloClass();
            var lord = new LordOfTheRings();
            lord.ShowYourself();
        }
    }
}
