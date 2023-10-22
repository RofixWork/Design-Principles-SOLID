using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    abstract internal class Account
    {
        protected Account(string? accountNumber, string? accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public string? AccountNumber { get; set; }
        public string? AccountHolder { get; set; }
        public decimal Balance { get; protected set; }
    }
}
