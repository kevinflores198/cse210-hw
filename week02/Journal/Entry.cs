using System.ComponentModel.DataAnnotations;

public class Entry
{
    // Represents a single journal entry.
    public string _date { set; get; }
    public string _promptText { set; get; }
    public string _enteryText { set; get; }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}: \nPrompt: {_promptText}\n> {_enteryText}");
    }
}
