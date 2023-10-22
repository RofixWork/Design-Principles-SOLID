using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class SMSService : IMessage
    {
        public string? MobileNo { get; set; }
        public void Send()
        {
            Console.WriteLine($"Send Message to {MobileNo}");
        }
    }
}
