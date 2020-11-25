using System;
using System.Linq;
using System.Net.Sockets;

namespace LinqFeatures
{
    public class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }
    }

    // public class PairOfStrings
    // {
    //     public string First { get; set; }
    //     public string Second { get; set; }
    // }
    //
    // public class PairOfInts
    // {
    //     public int First { get; set; }
    //     public int Second { get; set; }
    // }

    class Program
    {
        static void Main(string[] args)
        {
            var pairOfStrings = new Pair<string, string>();
            pairOfStrings.First = "Marcin";
            pairOfStrings.Second = "Jagieła";

            Console.WriteLine(pairOfStrings.First);
            Console.WriteLine(pairOfStrings.Second);

            var pairOfInts = new Pair<int, int>();
            pairOfInts.First = 1;
            pairOfInts.Second = 2;

            Console.WriteLine(pairOfInts.First);
            Console.WriteLine(pairOfInts.Second);

            var pairOfDates = new Pair<DateTime, DateTime>();
            pairOfDates.First = new DateTime(2020,11,25);
            pairOfDates.Second = DateTime.Now;

            Console.WriteLine(pairOfDates.First.ToLongDateString());

            var pairOfThings = new Pair<string, int>();
            pairOfThings.First = "Marcin";
            pairOfThings.Second = 10;
        }
    }
}
