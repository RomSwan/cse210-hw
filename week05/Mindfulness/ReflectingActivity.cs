using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This exercise helps you reflect on times of strength and resilience.";
        _prompts = new List<string>
        {
            "Think of a time you overcame a tough challenge.",
            "Recall a time you overcame your fears.",
            "Think of a time you helped someone in need.",
            "Think of a great personal achievement."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful?",
            "What changed as a result?",
            "What did you learn from this?",
            "How did you feel at the time?",
            "What can you apply from this memory?",
            "Who was involved?",
            "How did this improve you as a person?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        Console.WriteLine("When ready, press Enter.");
        Console.ReadLine();
        Console.WriteLine("Ponder the following:");

        DateTime time = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < time)
        {
            DisplayQuestions();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($"- {GetRandomQuestion()}");
        ShowSpinner(8);
        Console.WriteLine();
    }
}