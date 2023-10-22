using InterfaceSegregationPrinciple;

SavingAccount account = new("2022-1d-13", "xyz", 1500);

account.WithDraw(1_000);
Console.WriteLine(account.Balance);


CheckingAccount account2 = new("2022-1d-13", "xyz", 1500);

account2.Deposit(1_000);
Console.WriteLine(account.Balance);
