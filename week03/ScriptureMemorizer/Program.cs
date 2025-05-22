using System;

// I added user inputs for choosing their own verse(s) to use. As well as a way to choose how many words to hide at a time.

class Program
{
    static void Main(string[] args)
    {   //// USER INPUT ////
        // Book name:
        Console.Write("Please enter the name of the book: ");
        string book = Console.ReadLine();

        // Chapter:
        Console.Write("The chapter: ");
        string chapterString = Console.ReadLine();
        int chapter = int.Parse(chapterString);

        // Verse:
        Console.Write("The starting verse: ");
        string startVerseString = Console.ReadLine();
        int startVerse = int.Parse(startVerseString);

        // Ending verse:
        int endVerse;
        Console.Write("The ending verse (if there is there is only one verse, just press enter): ");
        string endVerseString = Console.ReadLine();
        if (endVerseString == "")
        {
            endVerse = -1;
        }
        else
        {
            endVerse = int.Parse(endVerseString);
        }

        // Text:
        Console.Write("Enter the full text of the verse(s) here: ");
        string text = Console.ReadLine();

        // Number of hidden words:
        Console.Write("Enter the amount of words you would like hidden each round: ");
        string hiddenWordAmountString = Console.ReadLine();
        int hiddenWordAmount = int.Parse(hiddenWordAmountString);
        //// END OF USER INPUT ////

        Reference reference = new Reference(book.ToUpper(), chapter, startVerse, endVerse);
        Scripture scripture = new Scripture(reference, text);

        while (scripture.IsCompletelyHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(hiddenWordAmount);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nFinished!");
    }
}