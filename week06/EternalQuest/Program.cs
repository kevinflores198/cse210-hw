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
                    System.Console.WriteLine("Please enter the file's name? ");
                    string file = Console.ReadLine();
                    gm.SaveToTxt(file);
                    Console.WriteLine($"Saved in {file} successfully.\n");
                    break;
                case 4:
                    Console.Write("Please enter file's name to load: ");
                    file = Console.ReadLine();
                    gm.LoadFromTxt(file);
                    Console.WriteLine($"Loaded from archive {file} successfully.\n");
                    break;
                case 5:
                    gm.RecordEvent();
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