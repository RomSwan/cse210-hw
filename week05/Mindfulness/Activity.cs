using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"...Booting up {_name} Activity...");
        Console.WriteLine(_description);
        Console.Write("Enter how long you want to do this exercise in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Alright, you completed the {_name} Activity!");
        Console.Write("\nReturning to Menu ");
        ShowSpinner(8);
    }

    public void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < end)
        {
            foreach (string frame in frames)
            {
                Console.Write(frame);
                Thread.Sleep(200);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}