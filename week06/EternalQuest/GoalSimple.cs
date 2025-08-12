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

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string StringRepresentation()
    {
        return $"Goal Simple | {_name} ({_description}) | {(IsComplete() ? "Completed" : "Not Completed")}";
    }
    public override string DetailString()
    {
        return $"Goal Simple | {_name}|{_description}|{_point}|{_isComplete}";
    }
}