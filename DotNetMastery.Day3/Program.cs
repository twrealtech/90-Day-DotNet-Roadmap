using System.Diagnostics;

Console.WriteLine("=== Even / Odd Checker ===");
Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"{num}is Even");

}
else
{
    Console.WriteLine($"{num} is Odd");
}


Console.WriteLine("\n=== Grading System ===");
Console.Write("Enter your mark (0-100): ");
int marks = Convert.ToInt32(Console.ReadLine());

if (marks >= 90)
{
    Console.WriteLine("Grade: A+ -Outstanding!");
}
else if (marks >= 80)
{
    Console.WriteLine("Grade: A -Excellent!");
}
else if (marks >= 70)
{
    Console.WriteLine("Grade: B -Good!");
}
else if (marks >= 60)
{
    Console.WriteLine("Grade: C -Pass!");
}
else if (marks >= 50)
{
    Console.WriteLine("Grade: D -need improvement!");
}
else
{
    Console.WriteLine("Grade: F -Fail, Try Agarin!");
}

Console.WriteLine("\n===Calculator with switch ===");
Console.Write("Enter first number: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second number: ");
double n2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Operation(+, -, *, /): ");
string op = Console.ReadLine()!;

switch (op)
{
    case "+":
        Console.WriteLine($"Result: {n1 + n2}");
        break;
    case "-":
        Console.WriteLine($"Result: {n1 - n2}");
        break;
    case "*":
        Console.WriteLine($"Result: {n1 * n2}");
        break;
    case "/":
        if(n2 != 0)
        {
         Console.WriteLine($"Result: {n1 / n2}");

        }
        else
        {

        Console.WriteLine($"Cannot divide by zero!");
        }
        break;

    default:
        Console.WriteLine($"Invalid operation!");
        break;
}

