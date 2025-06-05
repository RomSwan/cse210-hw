public class BreathingActivity : Activity
{
    private int _breathCount = 60; /*Counts number of asterixes for breathing animation*/
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity helps you relax through slow breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Write("The activity will begin in ");
        ShowCountDown(5);
        Console.Clear();

        for (int i = 0; i < _duration; i += 10)
        {
            Console.WriteLine("-------------------------Breathe IN-------------------------");
            BreathingInAnimation();
            Console.Clear();
            Console.WriteLine("---------------------Now breathe OUT------------------------");
            BreathingOutAnimation();
            Console.Clear();
        }

        DisplayEndingMessage();
    }

    /*Added BreathingInAnimation() and BreathingOutAnimation()*/
    public void BreathingInAnimation()
    {
        for (int i = 0; i < _breathCount; i++)
        {
            Console.Write("*");
            Thread.Sleep(50);
        }
    }

    public void BreathingOutAnimation()
    {
        Console.Write(new string('*', _breathCount));
        for (int i = _breathCount; i > 0; i--)
        {
            Console.Write("\b \b");
            Thread.Sleep(50);
        }
    }
}