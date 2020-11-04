using System;

namespace ObjectOrientedProgrammingBasics
{
    public class Car
    {
        private string _make;
        private int _yearOfProduction;
        private string _color;
        private int _petrolTankCapacity;
        private int _petrolUsagePer100Km;

        public string Make => _make;
        public int YearOfProduction => _yearOfProduction;
        public string Color => _color;
        public int PetrolTankCapacity => _petrolTankCapacity;
        public int PetrolUsagePer100Km => _petrolUsagePer100Km;


        public Car(string make, string color, int yearOfProduction, int petrolTankCapacity, int petrolUsagePer100km)
        {
            if (string.IsNullOrEmpty(make))
                throw new ArgumentNullException("Make cannot be empty");

            if (string.IsNullOrEmpty(color))
                throw new ArgumentNullException("Colour cannot be empty");

            if (yearOfProduction < 2000 || yearOfProduction > DateTime.Now.Year)
                throw new ArgumentException("Year of production can be a number from 2000 to current year");

            if (petrolTankCapacity < 1)
                throw new ArgumentException("Petrol tank capacity needs to be positive");

            if (petrolUsagePer100km < 0)
                throw new ArgumentException("Petrol usage needs to be not negative");

            _make = make;
            _color = color;
            _yearOfProduction = yearOfProduction;
            _petrolTankCapacity = petrolTankCapacity;
            _petrolUsagePer100Km = petrolUsagePer100km;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "Red", 2019, 60, 6);

            Console.WriteLine($"{car1.Make} was produced in {car1.YearOfProduction}");

        }

        private static void PersonTest()
        {
            //Old approach
            // Person me = new Person();
            // me.Name = "Marcin";
            // me.LastName = "Jagieła";
            // me.Age = 16;

            //Newer approach with object initializer
            var me = new Person {Name = "Marcin", LastName = "Jagieła", Age = 16};

            Console.WriteLine(me.FullName);
            Console.WriteLine(me.IsAdult);

            var you = new Person();
            you.Name = "John";
            you.LastName = "Lennon";
            Console.WriteLine(you.FullName);

            var him = new Person("Andrew", "Gołota", 50);
            Console.WriteLine(him.FullName);
            Console.WriteLine(him.IsAdult);

            Console.WriteLine(new Person().FullName);
        }
    }
}