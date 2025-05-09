using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   // The list of numbers & the declared variables
        List<string> numbers = new List<string>();
        int sum = 0;
        int average = 0;
        int maximum = 0;

        // Intro
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true) // Keeps loop going until broken
        {   // User input
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();

            if (number == "0") // Breaks loop if 0 is entered
            {
                break;
            }
            else
            {
                numbers.Add(number); // Adds numbers to the list
            }
        }

        // SUM of numbers
        foreach (string number in numbers)
        {
            int num = int.Parse(number);
            sum = sum + num;
        }
        // AVERAGE of numbers
        average = sum / numbers.Count();
        // MAXIMUM of numbers
        foreach (string number in numbers)
        {
            int num = int.Parse(number);
            if (num > maximum) // If a number is greater than the maximum, make it the new maximum
            {
                maximum = num;
            }
        }

        // Print the sum, average and maximum:
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The maximum is: {maximum}");
    }
}  