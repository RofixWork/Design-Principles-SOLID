using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal static class PersonsDB
    {
        public static List<Person> GetPeople()
        {
            return new List<Person>()
            {
                new Student()
                {
                    Name = "ahmed",
                    Age = 34,
                    City="agadir",
                    Country="morocco",
                    SchoolName="abc",
                    StudyYear=2023
                },
                new Doctor()
                {
                    Name = "amin",
                    Age = 34,
                    City="tanger",
                    Country="morocco",
                    Hospital="xcd hospital",
                    Experience=2,
                    Salary=20000
                },
                new Student()
                {
                    Name = "imane",
                    Age = 22,
                    City="agadir",
                    Country="morocco",
                    SchoolName="abc",
                    StudyYear=2023
                },
                new Doctor()
                {
                    Name = "aymen",
                    Age = 34,
                    City="casablanca",
                    Country="morocco",
                    Hospital="erw hospital",
                    Experience=4,
                    Salary=30000
                },
            };
        }
    }
}
