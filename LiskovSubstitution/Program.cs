
using LiskovSubstitution;

RegularAccount account = new SavingAccount("ahmed", 10_000);

account.WithDraw(10_000);
account.Deposit(5_000);
Console.WriteLine(account.Balance);