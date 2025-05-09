using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks for first name
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        // Asks for last name
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        // Display result
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}
