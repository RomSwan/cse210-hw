using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {   // Generate random number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        // Sets the guess counter
        int guesses = 0;

        while (true) // Keeps the loop infinite
        {   // User input
            Console.Write("Enter your guess: ");
            string input2 = Console.ReadLine();
            int guess = int.Parse(input2);

            // Adds to guess counter
            guesses += 1;

            if (guess > number)
            {
                Console.WriteLine("Lower.");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher.");
            }
            else
            {   // They successfully guess the correct number
                Console.WriteLine($"Correct! It took you {guesses} guesses.");
                break; // Breaks loop, which ends the program.
            }
        }
    }
}