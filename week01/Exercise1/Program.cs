using System;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
=======
        Console.Write("Enter your first name: ");
        string first = Console.ReadLine();

        Console.Write("Enter your last name: ");
>>>>>>> 56ac07b48a2bc3e19d8c71d7688eb576f305488a
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}
