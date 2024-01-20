using System.Collections.Specialized;
using System.IO;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {   
        Console.WriteLine("Entries:");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("");
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Mood: {entry._mood}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Entry: {entry._entryText}");
            Console.WriteLine("");

        }
    }

    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {   
            // Writes each entry's deatils on a single line to a file.
            foreach (Entry entry in _entries)
            {
                outputFile.Write($"{entry._date}|");
                outputFile.Write($"{entry._mood}|");
                outputFile.Write($"{entry._promptText}|");
                outputFile.WriteLine($"{entry._entryText}");

            }
        }
    }

    public void LoadFromFile(string file)
    {   
        // Removess all entries
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        // Splits the stored entries and stores them as new entries.
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string _date = parts[0];
            string _mood = parts[1];
            string _prompt = parts[2];
            string _entry = parts[3];

            Entry entry = new Entry();
            entry._date = _date;
            entry._mood = _mood;
            entry._promptText = _prompt;
            entry._entryText = _entry;
            AddEntry(entry);

        }
    }
}