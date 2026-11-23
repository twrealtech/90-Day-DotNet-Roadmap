using DotNetMastery.Day8;

Console.WriteLine("=== Bank Account - OOP Encapsulation ===");

BankAccount acc1 = new BankAccount("Tariq", "PK-1001", 5000);
acc1.ShowDetails();
Console.WriteLine();
acc1.Deposit(2000);
acc1.Withdraw(2000);
acc1.Withdraw(2000);

Console.WriteLine();
acc1.ShowDetails();
