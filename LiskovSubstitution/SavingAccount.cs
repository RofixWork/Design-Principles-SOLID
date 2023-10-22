using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class SavingAccount : RegularAccount
    {
        public SavingAccount(string? name, decimal balance) : base(name, balance)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance -= amount;
        }

        public override void WithDraw(decimal amount)
        {
            Balance += amount;
        }
    }
}
