using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Threading.Channels;

namespace LinqFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] measurements = { 5, 24, -12, 34, -1, 8, -21, 100, 200, 14, 36, -48, 60 };
            string[] names = {"John", "Bob", "Alice", "Donald", "Euzebiusz", ""};
   
            // Console.WriteLine(names.Min());
            // Console.WriteLine(measurements.Min());

           // Display(measurements.Where(x => x > 10));
           // Display(measurements.Where(x => x > 0 && x % 2 == 0));
           // Display(measurements.OrderByDescending(x => x));
           // Display(names.OrderBy(x=>x));
           // Display(names.OrderBy(x=>x.Length));
           //
           // Display(names.Where(x=>x.Length > 0).Select(x => x[0]));
           // Display(names.Select(x => x.Length > 0 ? x[0].ToString() : ""));
           // Display(names.Select(x => x.FirstOrDefault()));
           //
           // Display(names.Skip(2).Take(2));
           // Console.WriteLine(names.Skip(1).FirstOrDefault());

           var collection = measurements
               .Where(x => x % 12 == 0)
               .OrderBy(x => x)
               .Select(x => Math.Abs(x));

            Display(collection);

            var aenames = names
                .Where(x => x.StartsWith("A") || x.StartsWith("E"))
                .OrderByDescending(x => x.Length)
                .Select(x => x.Last())
                .Skip(1);
            Display(aenames);



        }

        public static void Display<T>(IEnumerable<T> collection)
        {
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("------------------------------------");
        }
    }
}
