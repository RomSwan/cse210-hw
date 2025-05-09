using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   // The list of numbers & the declared variables
        List<int> numbers = new List<int>();
        int sum = 0;
        int average = 0;
        int maximum = 0;
        int smallest_positive = int.MaxValue;


        // Intro
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true) // Keeps loop going until broken
        {   // User input
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            // Convert from string to int:
            int number = int.Parse(input);

            if (number == 0) // Breaks loop if 0 is entered
            {
                break;
            }
            else
            {
                numbers.Add(number); // Adds numbers to the list
            }
        }

        // Loop for calculations
        foreach (int number in numbers)
        {   // SUM
            sum = sum + number;
            // MAXIMUM
            if (number > maximum)
            {
                maximum = number;
            }
            // SMALLEST POSITIVE
            if (number > 0 && number < smallest_positive)
            {
                smallest_positive = number;
            }
        }
        // AVERAGE
        average = sum / numbers.Count();

        // Print the sum, average, maximum, smallest positive, and sorted list:
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The maximum is: {maximum}");
        Console.WriteLine($"The smallest positive number is: {smallest_positive}");
        Console.WriteLine($"The sorted list is:");
        numbers.Sort(); // Sort list
        foreach (int number in numbers) // Print the sorted list
        {
            Console.WriteLine(number);
        }
    }
}  