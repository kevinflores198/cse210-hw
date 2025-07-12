using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator aPrompt = new PromptGenerator();
        Journal journal = new Journal();
        int answer = 0;
        Console.WriteLine("Welcome to the Journal Program!");
        // do-while to start again until the user selects 5 to close the program.
        do
        {
            Console.Write("Please select one of the following choic \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?\n> ");
            int option = int.Parse(Console.ReadLine());
            // switch options touse more than 2 options.
            switch (option)
            {
                case 1:
                    // Entry entry = new Entry();
                    // Console.WriteLine(aPrompt.GetRandomPrompt());
                    // entry._enteryText = Console.ReadLine();
                    // entry._promptText = aPrompt.GetRandomPrompt();
                    // journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    journal.LoadFromFile(null);
                    break;
                case 4:
                    journal.SaveToFile(null);
                    break;
            }
        } while (answer != 5);
        Console.WriteLine("Thanks for being here, we wait you next time!");
    }
}