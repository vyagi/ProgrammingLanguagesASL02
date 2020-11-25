using System;
using System.Collections.Generic;

namespace LinqFeatures
{
    class PersonalData
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }

        public static IEnumerable<PersonalData> GetPersonalData()
        {
            yield return new PersonalData { Id = 1, BirthDate = new DateTime(1981, 11, 10), City = "Rzeszow", Street = "Sw. Marcina", House = "19B/1" };
            yield return new PersonalData { Id = 2, BirthDate = new DateTime(1971, 2, 27), City = "Warszawa", Street = "Durna", House = "13" };
            yield return new PersonalData { Id = 3, BirthDate = new DateTime(1949, 6, 18), City = "Warszawa", Street = "Miejska", House = "3" };
            yield return new PersonalData { Id = 4, BirthDate = new DateTime(1954, 3, 16), City = "Warszawa", Street = "Pusta", House = "11/3" };
            yield return new PersonalData { Id = 5, BirthDate = new DateTime(1987, 11, 10), City = "Gdynia", Street = "Waldowska", House = "11" };
            yield return new PersonalData { Id = 6, BirthDate = new DateTime(1981, 2, 16), City = "Gdynia", Street = "Warszawska", House = "997" };
           // yield return new PersonalData { Id = 7, BirthDate = new DateTime(1995, 12, 21), City = "Krakow", Street = "Pijarska", House = "17A/89" };
        }
    }
}
