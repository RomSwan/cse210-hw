using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal journalEntry = new Journal();

        Console.Write("Enter date: ");
        journalEntry._date = Console.ReadLine();

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today.",
            "What was the strongest emotion I felt today.",
            "If I had one thing I could do over today, what would it be?"
        };

        Random randomGenerator = new Random();
        int index = randomGenerator.Next(prompts.Count);
        journalEntry._prompt = prompts[index];

        Console.WriteLine(journalEntry._prompt);
        journalEntry._response = Console.ReadLine();
        Console.WriteLine();
        
        journalEntry.DisplayEntries();
    }
}