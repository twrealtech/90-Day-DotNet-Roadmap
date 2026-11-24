using DotNetMastery.Day9;

Console.WriteLine("=== Employee Management -Inheritance ===");

Employee emp1 = new Employee("Tariq", 1, 80000);
emp1.ShowDetails();

Console.WriteLine();

Manager mgr1 = new Manager("Ali", 2, 150000, 5);
mgr1.ShowDetails();
Console.WriteLine();

Developer dev1 = new Developer("Ahmad", 3, 120000, "C#");
dev1.ShowDetails();




