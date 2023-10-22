namespace InterfaceSegregationPrinciple
{
    internal class SavingAccount : Account, IWithDraw, IDeposit
    {
        public SavingAccount(string? accountNumber, string? accountHolder, decimal balance) : base(accountNumber, accountHolder, balance)
        {
        }
        public void Deposit(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("m3ndkx f account had lmablar $" + amount + "| Your Balance: $" + Balance);
            }
            else
            {
                Balance -= amount;
            }
        }

        public void WithDraw(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }
    }
}
