public class Journal
{
    public string _prompt;
    public string _response;
    public string _date;

    public void DisplayEntries()
    {
        Console.WriteLine($"~~{_date}~~");
        Console.WriteLine($"({_prompt})");
        Console.WriteLine($"{_response}");
        Console.WriteLine();
    }
}