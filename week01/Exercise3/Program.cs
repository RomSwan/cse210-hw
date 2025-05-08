using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {   
        while (true) // Keeps loop infinite until broken
        {
            // Generate random number
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
                {   // user successfully guesses the correct number
                    Console.WriteLine($"Correct! It took you {guesses} guesses.");
                    break; // Breaks the loop
                }
            }    

            // Ask to go again
            Console.Write("Go again? yes/no: ");
            string yes_no = Console.ReadLine();
            if (yes_no == "yes")
            {
                guesses = 0; // Resets guess counter 
                continue; // Restarts loop
            }
            else if (yes_no == "no")
            {
                Console.WriteLine("Okay. See you later!");
                break; // Breaks loop, which ends the program.
            }
            else // If input is neither yes nor no, just restart the loop for fun.
            {
                Console.WriteLine("Hm. I didn't quite catch that. I'll assume you wanna go again.");
                guesses = 0; // Resets guess counter 
                continue; // Restarts loop
            }       
        }
    }
}
