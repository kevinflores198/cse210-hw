using System.Drawing;

public class GoalSimple : Goal
{
    private bool _isComplete;

    public GoalSimple(string name, string description, int point) : base(name, description, point)
    {
        _isComplete = false;
    }

    public GoalSimple()
    {
    }
    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            System.Console.WriteLine("You have completed a simple goal!");
            _isComplete = true;
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string StringRepresentation()
    {
        return $"Goal Simple|{_name} ({_description})|{(IsComplete() ? "Completed" : "Not Completed")}";
    }
    public override string DetailString()
    {
        if (IsComplete())
        {
            return $"[x] Goal Simple | {_name}|{_description}|{_point}|{_isComplete}";

        }
        else
        {
            return $"[ ] Goal Simple | {_name}|{_description}|{_point}|{_isComplete}";

        }
    }
}