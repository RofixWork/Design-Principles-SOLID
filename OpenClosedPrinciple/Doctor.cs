using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Doctor : Person
    {
        public string? Hospital { get; set; }
        public int Experience { get; set; }
        public decimal Salary { get; set; }
        public override void Print()
        {
            Console.WriteLine($"Doctor Name: {Name}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"Hospital Name: {Hospital}");
            Console.WriteLine($"Experience: {Experience} Years");
            Console.WriteLine($"Salary: {Salary:C0}");
        }
    }
}
