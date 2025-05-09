using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); // Welcome!
        string name = PromptUserName(); // Name?
        float number = PromptUserNumber(); // Number?
        float square = SquareNumber(number); // Calculates square
        DisplayResult(name, square); // Displays results
    }

    static void DisplayWelcome() // Displays welcome card
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName() // Asks user for name
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static float PromptUserNumber() // Asks user for number
    {
        Console.Write("Please enter your favourite number: ");
        string number = Console.ReadLine();
        return float.Parse(number); // Converts string to float
    }
    
    static float SquareNumber(float number) // Squares number
    {
        return number * number;
    }

    static void DisplayResult(string name, float square) // Displays results
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}