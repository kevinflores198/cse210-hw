public class GoalEternal : Goal
{
    public GoalEternal() { }

    public GoalEternal(string name, string description, int point) : base(name, description, point)
    {
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
        return $"Eternal Goal: {GetName()} | {GetDescription} | {GetPoint()}";
    }
    public override string DetailString()
    {
        throw new NotImplementedException();
    }
}