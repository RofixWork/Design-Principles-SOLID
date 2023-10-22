using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class EmailService : IMessage
    {
        public string? Email { get; set; }
        public void Send()
        {
            Console.WriteLine($"Email Snd to {Email}");
        }
    }
}
