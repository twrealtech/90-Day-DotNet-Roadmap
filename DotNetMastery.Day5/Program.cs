Console.WriteLine("== Student Marks -Array ==");
int[] marks = { 85, 90, 78, 92, 88 };

for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine($" student {i+1}: {marks[i]}");
}

Console.WriteLine($"Total Students: {marks.Length}");

int max = marks[0];
for (int i = 1; i < marks.Length; i++)
{
    if (marks[i] > max ) max= marks[i];
}
Console.WriteLine($"Highest Marks: {max}");

Console.WriteLine("\n== Student Names - List ==");

List<string> students = new List<string>();

students.Add("Tariq");
students.Add("Ali");
students.Add("Ahmed");

Console.Write("Enter new student name: ");
students.Add(Console.ReadLine()!);

Console.WriteLine("All students names:");
foreach (var s in students)
{
    Console.WriteLine($"- {s}");
}

