using System;
using System.Collections.Generic;
using System.IO;
public class GoalManager
{
    private List<Goal> _lg = new List<Goal>();
    private int _score = 0;
    public GoalManager()
    {
        _lg = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        DisplayPlayerInfo();
        System.Console.WriteLine("Menu options:");
        System.Console.WriteLine("1. Create new goal\n2. List goals\n3. Save goals\n4. Load goals\n5. Record event\n6. Quit\n");
        System.Console.WriteLine("Select a choise from the menu: ");
    }
    public void AddGoal(Goal goal)
    {
        _lg.Add(goal);
    }
    public void DisplayGoals()
    {
        Console.WriteLine($"\nScore actual: {_score}\n");
        foreach (Goal goal in _lg)
        {
            Console.WriteLine(goal.DetailString());
        }
    }
    public void DisplayPlayerInfo()
    {
        System.Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalName()
    {
        // print number by list and name.
        for (int i = 0; i < _lg.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_lg[i].DetailString()}");
        }
    }
    public void ListGoalDetail()
    {
        foreach (var goal in _lg)
        {
            Console.WriteLine(goal.DetailString());
        }
    }
    public void CreateGoal()
    {
        System.Console.WriteLine("Type of goals:\n1. Simple Goal\n2. Eternal Goal\n3. CheckList Goal");
        System.Console.WriteLine("Whitch type of goal would you like to create?");
        int choise = int.Parse(Console.ReadLine());

        // those 3 arguments are the same for the 3 goals, 
        // to avoid repeating code, 
        // we do it here and we use the parameters.
        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int point = int.Parse(Console.ReadLine());

        Goal g = null;
        switch (choise)
        {
            case 1:
                g = new GoalSimple(name, description, point);
                break;
            case 2:
                g = new GoalEternal(name, description, point);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                g = new GoalList(name, description, point, target, bonus);
                break;
            default:
                System.Console.WriteLine("Please use a number between 1 and 3.");
                break;
        }
        _lg.Add(g);
    }
    public void RecordEvent()
    {
        Console.WriteLine("Select goal number to record event:");
        ListGoalName();
        int choice = int.Parse(Console.ReadLine());

        if (choice > 0 && choice <= _lg.Count)
        {
            Goal goal = _lg[choice - 1];
            goal.RecordEvent();

            if (goal.IsComplete())
            {
                _score += goal.GetPoint();
                Console.WriteLine("Goal completed! Score added.");
            }
            else
            {
                Console.WriteLine("Event recorded.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }


    }
    public void SaveToTxt(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Goal goal in _lg)
            {
                if (goal is GoalList gl)
                {
                    outputFile.WriteLine($"GoalList|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoint()}|{gl.GetAmountCompleted()}|{gl.GetAmountCompleted()}|{gl.GetBonus()}");
                }
                else if (goal is GoalEternal)
                {
                    outputFile.WriteLine($"GoalEternal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoint()}");
                }
                else if (goal is GoalSimple)
                {
                    outputFile.WriteLine($"GoalSimple|{goal.GetName}|{goal.GetDescription()}|{goal.GetPoint()}|{goal.IsComplete()}");
                }
            }
        }

    }
    public void LoadFromTxt(string file)
    {
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                string type = parts[0];

                switch (type)
                {
                    case "Goal Simple":
                        GoalSimple gs = new GoalSimple();
                        gs.SetName(parts[1]);
                        gs.SetDescription(parts[2]);
                        gs.SetPoint(int.Parse(parts[3]));
                        if (bool.Parse(parts[4])) gs.IsComplete();
                        _lg.Add(gs);
                        break;

                    case "Goal Eternal":
                        GoalEternal ge = new GoalEternal();
                        ge.SetName(parts[1]);
                        ge.SetDescription(parts[2]);
                        ge.SetPoint(int.Parse(parts[3]));
                        _lg.Add(ge);
                        break;

                    case "Goal List":
                        GoalList gl = new GoalList();
                        gl.SetName(parts[1]);
                        gl.SetDescription(parts[2]);
                        gl.SetPoint(int.Parse(parts[3]));
                        gl.SetAmountCompleted(int.Parse(parts[4]));
                        gl.SetTarget(int.Parse(parts[5]));
                        gl.SetBonus(int.Parse(parts[6]));
                        _lg.Add(gl);
                        break;
                }
            }
        }
    }
}