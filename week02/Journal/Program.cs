using System;
using System.Net;
//---What have I done to exceed the requirements:

//I Made two new behaviors SaveToJson(string):void / LoadFromJson(string):void in Journal.cs
//SaveToJson(string):void = In those behaviors I shows how to save the output unto 
//a Json. I used JsonSerializer to change the list to text JSON. Then we save the file
//into an archive using WriteAllText(file,json).
//LoadFromJson(string):void = In charge of loading the file Json. We indicate if 
//it exists, then we read the file text and we make a list of entry with  JsonSerializer.Deserialize.
//Then, in Program.cs I added those two behaviors into case 5 and 6 in the switch to show
//the function of that. running the file in case 5, it will save the new string jsonSaveFile
//into the journal. then we can see it on the .json. Same with case 6, load the Json.
class Program
{
    static void Main(string[] args)
    {
        PromptGenerator aPrompt = new PromptGenerator();
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        // while to start again until the user selects 5 to close the program.
        int answer = 0;
        while (answer != 2)
        {
            Console.Write("Please select one of the following: \n1. Write\n2. Display\n3. Load from file\n4. Save in file\n5. Save in JSON\n6. Load from JSON\n7. Close\nWhat would you like to do?\n> ");
            int option = int.Parse(Console.ReadLine());
            // switch options touse more than 2 options.
            switch (option)
            {
                case 1:
                    // we initialize a new prompt random, and we print it
                    string prompt = aPrompt.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    // We star a new Entry and then we add it into the list.
                    Entry entry = new Entry();
                    // We save each entry and prompt each time the code starts again until we select 5.
                    entry._date = DateTime.Now.ToString("yyyy-MM-dd");
                    entry._enteryText = Console.ReadLine();
                    entry._promptText = prompt;
                    // We add each entry to the journal.
                    journal.AddEntry(entry);
                    System.Console.WriteLine("Entry added successfully!");
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    System.Console.WriteLine("Please enter file to load: ");
                    string loadingFile = Console.ReadLine();
                    journal.LoadFromFile(loadingFile);
                    break;
                case 4:
                    string fileName = "journal.txt";
                    journal.SaveToFile(fileName);
                    System.Console.WriteLine("entry charged successfully!");
                    break;
                case 5:
                    System.Console.WriteLine("Please enter the name of the JSON file? ");
                    string jsonSaveFile = Console.ReadLine();
                    journal.SaveToJson(jsonSaveFile);
                    Console.WriteLine("Saved in JSON successfully.\n");
                    break;
                case 6:
                    Console.Write("Please enter JSON to load: ");
                    string jsonLoadFile = Console.ReadLine();
                    journal.LoadFromJson(jsonLoadFile);
                    Console.WriteLine("Loaded from archive JSON successfully.\n");
                    break;
                case 7:
                    Console.Write("Would you like to add another entry?\n1.Yes/2.No\n> ");
                    answer = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid option, choose from 1 to 7.");
                    break;
            }
        }
        Console.WriteLine("Thanks for being here, we wait you next time!");
    }
}