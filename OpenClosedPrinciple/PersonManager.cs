using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class PersonManager
    {
        public List<Person> People { get; set; }

        public PersonManager(List<Person> people)
        {
            People = people;
        }

        public void Print()
        {
            foreach (Person person in People)
            {
                person.Print();
                Console.WriteLine("\n");
            }
        }
    }
}
