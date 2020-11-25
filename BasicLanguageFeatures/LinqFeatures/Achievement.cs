using System;
using System.Collections.Generic;

namespace LinqFeatures
{
    class Achievement
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime AchievementDate { get; set; }

        public static IEnumerable<Achievement> GetAchievements()
        {
            yield return new Achievement {EmployeeId = 1, Name = "Win in tournament", Value = 6, AchievementDate = new DateTime(2008, 02, 12)};
            yield return new Achievement {EmployeeId = 2, Name = "New invention", Value = 3, AchievementDate = new DateTime(2012, 02, 14)};
            yield return new Achievement {EmployeeId = 1, Name = "Article in newspaper", Value = 4, AchievementDate = new DateTime(2017, 02, 5)};
            yield return new Achievement {EmployeeId = 3, Name = "Project finished before time", Value = 5, AchievementDate = new DateTime(2011, 01, 1)};
            yield return new Achievement {EmployeeId = 1, Name = "Acquiring new branch", Value = 1, AchievementDate = new DateTime(2013, 06, 30)};
            yield return new Achievement {EmployeeId = 2, Name = "The biggest contribution to the project", Value = 2, AchievementDate = new DateTime(2014, 02, 25)};
            yield return new Achievement {EmployeeId = 2, Name = "Project finished on time", Value = 4, AchievementDate = new DateTime(2015, 04, 11)};
            yield return new Achievement {EmployeeId = 4, Name = "Project finished on time", Value = 6, AchievementDate = new DateTime(2016, 05, 6)};
            yield return new Achievement {EmployeeId = 4, Name = "Article in newspaper", Value = 2, AchievementDate = new DateTime(2020, 06, 19)};
            yield return new Achievement {EmployeeId = 1, Name = "New invention", Value = 5, AchievementDate = new DateTime(2012, 07, 14)};
            yield return new Achievement {EmployeeId = 5, Name = "Acquiring new branch", Value = 1, AchievementDate = new DateTime(2001, 12, 21)};
        }
    }
}
