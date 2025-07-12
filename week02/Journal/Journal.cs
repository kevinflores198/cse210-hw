using System.IO;
using System.Collections.Generic;
using System;
public class Journal
{
    // Stores a list of journal entries
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        file = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                DisplayAll();
            }
        }
    }
    public void LoadFromFile(string file)
    {

    }
}