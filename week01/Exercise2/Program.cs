using System;

class Program
{
    static void Main(string[] args)
    {
        // User Input
        Console.Write("Enter a grade percentage: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        // Variables for the letter grade and sign
        string grade = "";
        string sign = "";
        string numberString = number.ToString();

        // Conditionals to decide letter grade
        if (number >= 90)
        {
            grade = "A";
        }
        else if (number >= 80)
        {
            grade = "B";
        }
        else if (number >= 70)
        {
            grade = "C";
        }
        else if (number >= 60)
        {
            grade = "D";
        }
        else if (number < 60)
        {
            grade = "F";
        }

        // Calculate if and what sign to use
        if (numberString[1] >= 7)
        {
            sign = "+";
            if (grade[0] == 'A') // There is no A+
            {
                sign = "";
            }
        }
        else if (numberString[1] < 3)
        {
            sign = "-";
        }
        if (grade[0] == 'F') // There is no F+ nor F-
        {
            sign = "";
        }

        // Print final letter grade
        Console.WriteLine($"Here is your grade: {grade}{sign}");
        if (number >= 70)
        {   // If grade is > 70, you pass:
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {   // If grade is less than 70, you do not pass:
            Console.WriteLine("You did not pass. Better luck next time!");
        }
    }
}