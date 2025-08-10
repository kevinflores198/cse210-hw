using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();

        int response = 0;
        do
        {
            gm.Start();
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    gm.CreateGoal();
                    break;
                case 2:
                    System.Console.WriteLine("List of goals: ");
                    gm.ListGoalName();
                    break;
                case 3:
                    System.Console.WriteLine("Please enter the name of the JSON file? ");
                    string jsonSaveFile = Console.ReadLine();
                    gm.SaveToJson(jsonSaveFile);
                    Console.WriteLine("Saved in JSON successfully.\n");
                    break;
                case 4:
                    Console.Write("Please enter JSON to load: ");
                    string jsonLoadFile = Console.ReadLine();
                    gm.LoadFromJson(jsonLoadFile);
                    Console.WriteLine("Loaded from archive JSON successfully.\n");
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    break;
            }
            System.Console.WriteLine("Do you want to leave? 1. Yes - 2. No");
            response = int.Parse(Console.ReadLine());
        } while (response != 1);
        System.Console.WriteLine("See you next time!");
    }
}