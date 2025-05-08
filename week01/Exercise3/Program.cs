using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        while (true)
        {
            Console.Write("Enter your guess: ");
            string input2 = Console.ReadLine();
            int guess = int.Parse(input2);

            if (guess > number)
            {
                Console.WriteLine("Lower.");
            }
            else if (guess < number)
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