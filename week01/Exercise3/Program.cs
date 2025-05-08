using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the magic number: ");
        string input = Console.ReadLine();
        int magicNum = int.Parse(input);

        while (true)
        {
            Console.Write("Enter your guess: ");
            string input2 = Console.ReadLine();
            int guess = int.Parse(input2);

            if (guess > magicNum)
            {
                Console.WriteLine("Lower.");
            }
            else if (guess < magicNum)
            {
                Console.WriteLine("Higher.");
            }
            else 
            {
                Console.WriteLine("Correct!");
                break;
            }
        }
    }
}