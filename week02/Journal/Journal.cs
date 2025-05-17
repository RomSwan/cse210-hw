public class Journal
{
    public string _prompt;
    public string _response;
    public string _date;
    public string _weather;

    List<Journal> journal = new List<Journal>();

    public static void SaveToFile(List<Journal> journal, string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Journal entry in journal)
            {
                outputFile.WriteLine($"{entry._date},{entry._weather},{entry._prompt},{entry._response}");
            }
        }
    }
    public static List<Journal> ReadFromFile(string filename)
    {
        List<Journal> pastEntries = new List<Journal>();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Journal pastEntry = new Journal();
            pastEntry._date = parts[0];
            pastEntry._weather = parts[1];
            pastEntry._prompt = parts[2];
            pastEntry._response = parts[3];

            pastEntries.Add(pastEntry);

        }

        return pastEntries;
    }

}