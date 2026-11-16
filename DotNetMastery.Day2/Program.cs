using System;

Console.WriteLine("== Day 2: variables & User Input ===");
Console.WriteLine();

//Part A: Variables - Personal Info

string name = "Ali";
int age = 22;
double height = 5.9;
bool isStudent = true;
char grade = 'A';
var city = "Faisalabad";

Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Height: {height}");
Console.WriteLine($"Is Student: {isStudent}");
Console.WriteLine($"Grade: {grade}");
Console.WriteLine($"City: {city}");
Console.WriteLine();

//Part B: User input -Calculator

Console.Write("Enter your name: ");
string userName = Console.ReadLine()!;

Console.Write("Enter your age: ");
int userAge = int.Parse(Console.ReadLine()!);


Console.Write("Enter first number: ");
double num1 = double.Parse(Console.ReadLine()!);


Console.Write("Enter second number: ");
double num2 = double.Parse(Console.ReadLine()!);

double sum = num1 + num2;
double minus = num1 - num2;
double multiply = num1 * num2;
double divide = num1 / num2;

Console.WriteLine();
Console.WriteLine($"Hello {userName}, you are {userAge} years old.");
Console.WriteLine($"{num1} + {num2}= {sum}");
Console.WriteLine($"{num1} - {num2}= {minus}");
Console.WriteLine($"{num1} * {num2}= {multiply}");
Console.WriteLine($"{num1} / {num2}= {divide}");


Console.WriteLine();

// Part C: your challange - Do yourself
//1. Ask user for birth year and calculate age in 2030

Console.Write("Enter your birth year:");
int birthYear = int.Parse(Console.ReadLine()!);
int ageIn2030 = 2030 - birthYear;
//2. Ask for price and quantity, calculate total bill 
Console.Write("Enter price:");
double price = double.Parse(Console.ReadLine()!);
Console.Write("Enter quantity:");
double quantity = double.Parse(Console.ReadLine()!);
double totalBill = price * quantity;
//3. Ask for temerature in celsius. convert to Fahrenheit:
Console.Write("Enter temprature in celsius:");
double celsiusTemp = double.Parse(Console.ReadLine()!);
double FahrnheitTemp = (celsiusTemp * 9 / 5) + 32;

Console.WriteLine();

Console.WriteLine($"your age in 2030 will be: {ageIn2030}.");
Console.WriteLine($"your total bill : {totalBill}.");
Console.WriteLine($"Temprature in fahrenheit : {FahrnheitTemp}.");


Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();





