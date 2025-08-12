public class GoalEternal : Goal
{

    public GoalEternal(string name, string description, int point) 
    : base(name, description, point)
    {
    }

    public GoalEternal()
    {
    }
    

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            System.Console.WriteLine("You have completed an eternal goal!");
            _point++;
        }
    }

    public override bool IsComplete()
    {
        return false;
    }
    public override string StringRepresentation()
    {
        return $"Eternal Goal|{_name}|{_description}|{_point}";
    }
    public override string DetailString()
    {
        return $"[ ] Eternal Goal | {_name} ({_description})";
    }
}