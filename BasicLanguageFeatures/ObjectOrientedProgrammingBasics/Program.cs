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
        private int _kilometerCounter;
        private int _petrolLevel;

        public string Make => _make;
        public int YearOfProduction => _yearOfProduction;
        public string Color => _color;
        public int PetrolTankCapacity => _petrolTankCapacity;
        public int PetrolUsagePer100Km => _petrolUsagePer100Km;

        public int KilometerCounter => _kilometerCounter;
        public int PetrolLevel => _petrolLevel;

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

        public void Tank(int litres)
        {
            if (litres < 0)
                throw new ArgumentException("Provide a positive value");

            if (_petrolLevel + litres > _petrolTankCapacity)
                _petrolLevel = _petrolTankCapacity;
            else
                _petrolLevel += litres;
        }

        public void Drive(int kilometers)
        {
            var range = _petrolLevel * 100 / _petrolUsagePer100Km;
            if (kilometers > range)
            {
                _kilometerCounter += range;
                _petrolLevel = 0;
            }
            else
            {
                _kilometerCounter += kilometers;
                _petrolLevel -= kilometers * PetrolUsagePer100Km / 100;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "Red", 2019, 60, 6);
            car1.Tank(30);
            car1.Drive(250);

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