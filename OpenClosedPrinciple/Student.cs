using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Student : Person
    {
        public string? SchoolName { get; set; }
        public int StudyYear { get; set; }
        public override void Print()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"School Name: {SchoolName}");
            Console.WriteLine($"Study Year: {StudyYear}");
        }
    }
}
