using System.IO;
using System.Collections.Generic;
using System;
using System.Text.Json;

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
        // StreamWriter is a class that allow us to write text in an archive.
        // using used to close the arvhice once we don't use it anymore.
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // for each entry we are going to save in an archive this line.
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._enteryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear(); // Limpia las entradas previas en memoria
        // It will charge all lines of the archive and save it into an array.
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            // using the \n we are separateing one each other.
            string[] parts = line.Split("|");
            // creating new entry and adding this data to the list.
            Entry entry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _enteryText = parts[2]
            };
            _entries.Add(entry);
        }
    }
    public void SaveToJson(string filename)
    {
        // change list of _entries to text JSON
        string jsonString = JsonSerializer.Serialize(_entries, new JsonSerializerOptions
        {
            // legible archive
            WriteIndented = true
        });
        // It saves the text into a archive.
        File.WriteAllText(filename, jsonString);
    }
    public void LoadFromJson(string filename)
    {
        if (File.Exists(filename))
        {
            string jsonString = File.ReadAllText(filename);
            // makes a list of entry with JsonSerializer.Deserialize
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
        }
    }
}