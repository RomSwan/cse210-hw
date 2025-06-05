using System;

/*Added a breathing animation to BreathingActvity*/

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to your personal mindfullness app!");
            Console.WriteLine("Choose an option 1-4:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("> ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (input == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (input == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (input == "4")
            {
                Console.Clear();
                break;
            }
        }
    }
}