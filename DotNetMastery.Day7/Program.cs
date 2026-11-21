using DotNetMastery.Day7;



//Object -Real Students

Console.WriteLine("=== Student Management - OOP ===");

Student s1 = new Student();
s1.Name = "Tariq";
s1.RollNo = 1;
s1.Marks = 85;
s1.ShowDetails();

Console.WriteLine($"Grade: {s1.GetGrade()}");
Console.WriteLine();

Student s2 = new Student();
s2.Name = "Ali";
s2.RollNo = 2;
s2.Marks = 72;
s2.ShowDetails();

Console.WriteLine($"Grade: {s2.GetGrade()}");
Console.WriteLine();

Student s3 = new Student();
Console.Write("Enter student Name: ");

s3.Name = Console.ReadLine()!;
Console.Write("Enter student RollNo: ");
s3.RollNo = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter student Marks: ");
s3.Marks = Convert.ToInt32(Console.ReadLine());
s3.ShowDetails();

Console.WriteLine($"Grade: {s3.GetGrade()}");



