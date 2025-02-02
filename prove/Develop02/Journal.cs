using System.Diagnostics.Metrics;

class Journal
{
    List<string> _entries;
    string _filename = "journal.csv";

    public Journal()
    {
        _entries = new List<string>();
        using (StreamReader sr = new StreamReader(_filename))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                _entries.Add(line);
            }
        }
    }

    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        int counter = 1;
        foreach (string entry in _entries)
        {
            Console.Write($"{counter}. ");
            Console.WriteLine(entry);
            counter++;
        }
    }

    public void DeleteEntry(int id)
    {
        _entries.RemoveAt(id-1);
    }

    public void CloseJournal()
    {
        using (StreamWriter writer = new StreamWriter(_filename))
        {
            foreach (string entry in _entries)
            {
                writer.WriteLine(entry);
            }
        }
        Console.WriteLine("Journal saved successfully");
    }
}