using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class FixedDepositAccount : Account
    {
        public FixedDepositAccount(string? name, decimal balance) : base(name, balance)
        {
        }

        public override void Deposit(decimal balance)
        {
            Balance -= balance;
        }
    }
}
