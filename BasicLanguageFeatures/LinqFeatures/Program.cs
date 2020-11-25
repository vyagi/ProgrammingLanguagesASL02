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
            var employees = Employee.GetEmployees().ToArray();
            var personalData = PersonalData.GetPersonalData().ToArray();

            var task1 =
                from employee in employees
                orderby employee.BaseSalary descending 
                where employee.Seniority > 8
                select new { employee.Age, FullName = $"{employee.FirstName} {employee.LastName}", Position = employee.Role};

            foreach (var employee in task1)
            {
                Console.WriteLine(employee.GetType());
                Console.WriteLine($"{employee.FullName} is {employee.Age} and he is {employee.Position}");
            }

            var namesAndCities =
                from emp in employees
                join workData in personalData on emp.Id equals workData.Id
                select new { FullName = emp.FirstName+ " " + emp.LastName, workData.City};

            foreach (var nac in namesAndCities)
            {
                Console.WriteLine($"{nac.FullName} lives in {nac.City}");
            }

            var namesAndCitiesFull =
                from emp in employees
                join workData in personalData on emp.Id equals workData.Id
                select new { Person = emp, Data = workData};

            foreach (var nac in namesAndCitiesFull)
            {
                Console.WriteLine($"{nac.Person.FirstName} {nac.Person.LastName} lives in {nac.Data.City}");
            }

        }

        public static void OldStuff()
        {
            // var employees = Employee.GetEmployees().ToArray();
            // var personalData = PersonalData.GetPersonalData().ToArray();
            //
            // var task1 = employees.Where(x => x.Seniority > 8);
            //
            // var task2 = employees.Where(x => x.Gender == Gender.Woman);
            //
            // var task3 = employees.Select(x => x.BaseSalary).Average();
            //
            // var avg = employees.Select(y => y.BaseSalary).Average();
            // var task4 = employees.Where(x => x.BaseSalary > avg);
            //
            // var task5 = employees.Where(x => x.Bonus > x.BaseSalary * 0.1M);
            // foreach (var employee in task5)
            // {
            //     Console.WriteLine(employee.FirstName);
            // }

            // var groups = employees.GroupBy(x => x.Gender);
            //
            // foreach (var group in groups)
            // {
            //     Console.WriteLine(group.Key);
            //     foreach (var employee in group)
            //     {
            //         Console.WriteLine("    " + employee.LastName);
            //     }
            //
            //     Console.WriteLine("-------------------");
            // }

            // var groupsByRole = employees.GroupBy(x => x.Role);
            //
            // foreach (var group in groupsByRole)
            // {
            //     Console.WriteLine(group.Key);
            //     foreach (var employee in group)
            //     {
            //         Console.WriteLine("    " + employee.FirstName + " " + employee.LastName);
            //     }
            //
            //     Console.WriteLine("-------------------");
            // }


            // var groupsByRole = employees.GroupBy(x => x.Age > 40);
            //
            // foreach (var group in groupsByRole)
            // {
            //     Console.WriteLine(group.Key);
            //     foreach (var employee in group)
            //     {
            //         Console.WriteLine("    " + employee.FirstName + " " + employee.LastName);
            //     }
            //
            //     Console.WriteLine("-------------------");
            // }
        }
    }
}
