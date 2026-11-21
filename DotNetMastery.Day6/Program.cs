
//Simple methode
static void SayHello()
{
    Console.WriteLine($"Hello, Welcome to methods class");
}

SayHello();

//methode with parameter
//addition of two number
static void add(int a, int b)
{
    Console.WriteLine($"Result: {a+b}");
}

Console.Write("Enter your first number:");

int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your second number:");

int n2 = Convert.ToInt32(Console.ReadLine());

add(n1,n2);
//Multiplication of two number function

static int Multiply(int a, int b)
{
    return a * b;
}
static string GetGrade(int marks)
{
    if (marks >= 90) return "A+";
    else if (marks >= 80) return "A";
    else if (marks >= 70) return "B";
    else if (marks >= 60) return "C";
    else if (marks >= 50) return "D";
    else if (marks >= 40) return "E";
    else return "Fail";
}


Console.WriteLine($"Multiplication result: {Multiply(n1 , n2)}");

Console.Write("Enter your Marks:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"your grade is : {GetGrade(m)}");




