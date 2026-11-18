Console.WriteLine("== Multiplication Table ===");
Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
for  (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}

Console.WriteLine("\n== Sum 1 to 100 ===");
int sum = 0;
int j = 1;

while (j <= 100)
{
    sum = sum + j;
    j++;
}
Console.WriteLine($"Sum 1 to 100 = {sum}");


Console.WriteLine("\n== ATM PIN Check ===");

int correctPin = 1234;
int enteredPin ;

do
{
    Console.Write("Enter PIN (Hint:1234):");
    enteredPin = Convert.ToInt32(Console.ReadLine());

    if (enteredPin!= correctPin)
    {
        Console.WriteLine("Wrong PIN. Try again!");
    }
} while (enteredPin != correctPin);
Console.WriteLine($"Sum 1 to 100 = {sum}");

