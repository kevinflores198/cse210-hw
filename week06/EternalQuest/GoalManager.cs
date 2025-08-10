using System.Linq.Expressions;
using System.Text.Json;

public class GoalManager : Goal
{
    private List<Goal> _lg = new List<Goal>();
    private int _score = 0;
    public GoalManager() { }
    public GoalManager(int score)
    {
        _score = score;
    }
    public GoalManager(string name, string description, int point) : base(name, description, point) { }
    public void SetScore(int score)
    {
        _score = score;
    }
    public int GetScore()
    {
        return _score;
    }
    public void Start()
    {
        DisplayPlayerInfo();
        System.Console.WriteLine("*** YOU HAVE 0 POINTS ***\n");
        System.Console.WriteLine("Menu options:");
        System.Console.WriteLine("1. Create new goal\n2. List goals\n3. Save goals\n4. Load goals\n5. Record event\n6. Quit\n");
        System.Console.WriteLine("Select a choise from the menu: ");
    }
    public void DisplayPlayerInfo()
    {
        System.Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalName()
    {
        foreach (Goal g in _lg)
        {
            System.Console.WriteLine(g.GetName());
        }
    }
    public void ListGoalDetail()
    {
        foreach (Goal g in _lg)
        {
            System.Console.WriteLine(g.GetDescription());
        }
    }
    public void ListGoalNameAndDetail()
    {
        foreach (Goal g in _lg)
        {
            System.Console.WriteLine($"[ ] {ListGoalName}: {ListGoalDetail}");
        }
    }
    public void CreateGoal()
    {
        System.Console.WriteLine("Type of goals:\n1. Simple Goal\n2. Eternal Goal\n3. CheckList Goal");
        System.Console.WriteLine("Whitch type of goal would you like to create?");
        int choise = int.Parse(Console.ReadLine());
        switch (choise)
        {
            case 1:
                GoalSimple gs = new GoalSimple();

                System.Console.WriteLine("What is the name of the goal?: ");
                gs.SetName(Console.ReadLine());
                string name = gs.GetName();

                System.Console.WriteLine("What is a shor description of it? ");
                gs.SetDescription(Console.ReadLine());
                string description = gs.GetDescription();

                System.Console.WriteLine("What is the amount of points associated with this goal?");
                gs.SetPoint(int.Parse(Console.ReadLine()));
                int point = gs.GetPoint();
                
                _lg.Add(gs);

                break;
            case 2:
                GoalEternal ge = new GoalEternal();

                System.Console.WriteLine("What is the name of the goal?: ");
                ge.SetName(Console.ReadLine());
                string name2 = ge.GetName();

                System.Console.WriteLine("What is a shor description of it? ");
                ge.SetDescription(Console.ReadLine());
                string description2 = ge.GetDescription();

                System.Console.WriteLine("What is the amount of points associated with this goal?");
                ge.SetPoint(int.Parse(Console.ReadLine()));
                int point1 = ge.GetPoint();

                _lg.Add(ge);

                break;
            case 3:
                GoalList gl = new GoalList();

                System.Console.WriteLine("What is the name of the goal? ");
                gl.SetName(Console.ReadLine());
                string name3 = gl.GetName();

                System.Console.WriteLine("What is a shor description of it? ");
                gl.SetDescription(Console.ReadLine());
                string description3 = gl.GetDescription();

                System.Console.WriteLine("What is the amount of points associated with this goal? ");
                gl.SetPoint(int.Parse(Console.ReadLine()));
                int point3 = gl.GetPoint();

                System.Console.WriteLine("How nmany times does this goal need to be accomplished for hours? ");
                gl.SetAmountCompleted(int.Parse(Console.ReadLine()));
                int amount = gl.GetAmountCompleted();

                System.Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                gl.SetBonus(int.Parse(Console.ReadLine()));
                int bonus = gl.GetBonus();

                _lg.Add(gl);

                DetailString();

                break;
            default:
                System.Console.WriteLine("Please use a number between 1 and 3.");
                break;
        }
    }
    public void SaveToJson(string file)
    {
        string jsonString = JsonSerializer.Serialize(_lg, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        File.WriteAllText(file, jsonString);
    }
    public void LoadFromJson(string file)
    {
        if (File.Exists(file))
        {
            string jsonString = File.ReadAllText(file);
            _lg = JsonSerializer.Deserialize<List<Goal>>(jsonString);
        }
    }

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string StringRepresentation()
    {
        return $"{GetName()} | {GetDescription} | {GetPoint()}";
    }

    public override string DetailString()
    {
        return $"{GetName()} | {GetDescription} | {GetPoint()}";
    }
}