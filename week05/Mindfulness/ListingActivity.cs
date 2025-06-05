using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity helps you reflect by listing your thoughts and ideas.";
        _prompts = new List<string>
        {
            "What are you grateful for today?",
            "List people who make you happy.",
            "What are your personal strengths?",
            "List moments you felt at peace."
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        GetRandomPrompt();

        Console.Write("Begin writing when the countdown ends: ");
        ShowCountDown(9);
        Console.WriteLine();

        List<string> lines = GetListFromUser();
        _count = lines.Count;
        Console.WriteLine($"You listed {_count} things.");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> lines = new List<string>();
        DateTime time = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < time)
        {
            Console.Write("> ");
            string line = Console.ReadLine();
            lines.Add(line);
        }

        return lines;
    }
}