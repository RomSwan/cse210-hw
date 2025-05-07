using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a grade percentage: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        string grade = "";

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

        Console.WriteLine($"Here is your grade: {grade}");
    }
}