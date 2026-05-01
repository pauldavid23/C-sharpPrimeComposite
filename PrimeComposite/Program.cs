// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?"); 
string name = Console.ReadLine();
if (name == null)
{
    Console.WriteLine("Name cannot be null.");
    Console.ReadKey();
    return;
}

Console.WriteLine($"Hello, {name}!");
Console.WriteLine("Thank you for using PrimeComposite App!");
Console.ReadKey();
Console.WriteLine("Enter a number");
if (!int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    Console.ReadKey();
    return;
}

if (number < 2)
{
    Console.WriteLine("Number must be greater than 1.");
    Console.ReadKey();
}
else if (IsPrime(number))
{
    Console.WriteLine($"{number} is a prime number.");
    Console.ReadKey();
}
else
{
    Console.WriteLine($"{number} is a composite number.");
}

Console.ReadKey();

bool IsPrime(int n)
{
    if (n < 2) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;

    for (int i = 3; i * i <= n; i += 2)
    {
        if (n % i == 0) return false;
    }

    return true;
}
