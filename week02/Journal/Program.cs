using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        List<Journal> journalEntryList = new List<Journal>();

        while (true)
        {
            Console.WriteLine("Enter the number of the option you want.");
            Console.WriteLine("1. Write entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            Console.Write("- ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Journal journalEntry = new Journal();

                Console.WriteLine();
                Console.Write("Enter date: ");
                journalEntry._date = Console.ReadLine();

                PromptGenerator randomPrompt = new PromptGenerator();
                journalEntry._prompt = randomPrompt.GetPrompt();
                Console.WriteLine(journalEntry._prompt);

                Console.Write("Enter response: ");
                journalEntry._response = Console.ReadLine();

                journalEntryList.Add(journalEntry);
                Console.WriteLine();
                Console.WriteLine("Good job!");
                Console.WriteLine();

                continue;
            }

            else if (input == "2")
            {
                foreach (Journal entry in journalEntryList)
                {
                    Console.WriteLine($"Date: {entry._date}");
                    Console.WriteLine($"({entry._prompt})");
                    Console.WriteLine($"'{entry._response}'");
                    Console.WriteLine();
                }
            }

            else if (input == "3")
            {
                Console.Write("Enter file name: ");
                string filename = Console.ReadLine();
                Journal.SaveToFile(journalEntryList, filename);
                Console.WriteLine("Journal saved!");
                Console.WriteLine();
            }

            else if (input == "4")
            {
                Console.Write("Enter file name: ");
                string filename = Console.ReadLine();
                journalEntryList = Journal.ReadFromFile(filename);
                Console.WriteLine("Journal loaded!");
                Console.WriteLine();
            }

            else if (input == "5")
            {
                Console.WriteLine("Have a great day!");
                break;
            }

            else
            {
                Console.WriteLine("Sorry, didn't catch that. Try again.");
            }

        }
    }
}