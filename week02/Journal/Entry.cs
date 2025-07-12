using System.ComponentModel.DataAnnotations;

public class Entry
{
    // Represents a single journal entry.
    public string _promptText;
    public string _enteryText;
    public DateTime _date = DateTime.Now;
    public void Display()
    {
        Console.WriteLine($"Date: {_date}: Prompt: {_promptText}\n{_enteryText}");
    }
}
