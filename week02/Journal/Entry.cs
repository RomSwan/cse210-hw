using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public static List<Entry> ReadJournal()
    {
        List<Entry> pastEntries = new List<Entry>();
        string filename = "journal.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        return pastEntries;
    }
}