namespace ObjectOrientedProgrammingBasics
{
    public class Person
    {
        public string Name;
        public string LastName;
        public int Age;

        public Person()
        {
            Name = "Unknown";
            LastName = "Unknown";
            Age = -1;
        }

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        // public string GetFullName()
        // {
        //     return $"{Name} {LastName}";
        // }

        // public bool GetIsAdult()
        // {
        //     return Age >= 18;
        // }

        //Oldschool
        // public bool IsAdult
        // {
        //     get
        //     {
        //         return Age >= 18;
        //     }
        // }

        //Slightly newer school:
        // public bool IsAdult
        // {
        //     get => Age >= 18;
        // }

        //Newest, cool school:
        public bool IsAdult => Age >= 18;

        public string FullName => $"{Name} {LastName}";
    }
}