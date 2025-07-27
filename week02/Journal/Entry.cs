using System.ComponentModel.DataAnnotations;

public class Entry
{
    // Represents a single journal entry.
    // to make a JSON we need the set and get of each variable.
    public string _date { set; get; }
    public string _promptText { set; get; }
    public string _enteryText { set; get; }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}: - Prompt: {_promptText}\n> {_enteryText}");
    }
}
