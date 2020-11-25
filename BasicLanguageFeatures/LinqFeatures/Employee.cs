using System.Collections.Generic;

namespace LinqFeatures
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }
        public int Seniority { get; set; }
        public Role Role { get; set; }
        
        public static IEnumerable<Employee> GetEmployees()
        {
            yield return new Employee { Id = 1, FirstName = "Tony", LastName = "Stark", Gender = Gender.Man, BaseSalary = 10000M, Bonus = 1500M,  Seniority = 12, Age = 37, Role = Role.Manager };
            yield return new Employee { Id = 2, FirstName = "Clark", LastName = "Kent", Gender = Gender.Man, BaseSalary = 9500M, Bonus = 1200M,  Seniority = 11, Age = 44, Role = Role.RegularWorker };
            yield return new Employee { Id = 3, FirstName = "Bruce", LastName = "Wayne", Gender = Gender.Man, BaseSalary = 8800M, Bonus = 2200M,  Seniority = 10, Age = 66, Role = Role.OnNotice };
            yield return new Employee { Id = 4, FirstName = "Eliza", LastName = "Bennett", Gender = Gender.Woman, BaseSalary = 9700, Bonus = 140M,  Seniority = 8, Age = 41, Role = Role.OnNotice };
            yield return new Employee { Id = 5, FirstName = "Cat", LastName = "Woman", Gender = Gender.Woman, BaseSalary = 2500M, Bonus = 500M,  Seniority = 1, Age = 28, Role = Role.Intern };
            yield return new Employee { Id = 6, FirstName = "Vicky", LastName = "Vale", Gender = Gender.Woman, BaseSalary = 2700M, Bonus = 490,  Seniority = 2, Age = 34, Role = Role.Intern };
            yield return new Employee { Id = 7, FirstName = "Wonder", LastName = "Woman", Gender = Gender.Woman, BaseSalary = 2200M, Bonus = 100M,  Seniority = 1, Age = 20, Role = Role.Intern };
        }
    }
}
