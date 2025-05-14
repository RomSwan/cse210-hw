using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public List<Journal> _entries = new List<Journal>();

    public void DisplayEntries()
    {
        Console.WriteLine("~~~ Past Entries ~~~");
        foreach (Journal entry in _entries)
        {
            entry.DisplayEntries();
        }
    }
}