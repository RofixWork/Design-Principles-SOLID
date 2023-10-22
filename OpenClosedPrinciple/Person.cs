using System;
using System.Collections.Generic;
namespace OpenClosedPrinciple
{
    abstract internal class Person
    {
        public string? Name { get; set; } 
        public int Age { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }

        public abstract void Print();

    }
}
