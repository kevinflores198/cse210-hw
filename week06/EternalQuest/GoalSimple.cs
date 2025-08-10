public class GoalSimple : Goal
{
    private bool _isComplete;
    public GoalSimple() { }

    public GoalSimple(string name, string description, int point, bool isComplete) : base(name, description, point)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string StringRepresentation()
    {
        throw new NotImplementedException();
    }
    public override string DetailString()
    {
        throw new NotImplementedException();
    }
}