public class GoalList : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public GoalList() { }

    public GoalList(string name, string description, int point, int ammountCompleted, int target, int bonus) : base(name, description, point)
    {
        _amountCompleted = ammountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetTarget(int target)
    {
        _target = target;
    }
    public int GetTarget()
    {
        return _target;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string DetailString()
    {
        return $"Check List Goal: {GetName()} | {GetDescription} | {GetPoint()} | {GetAmountCompleted()} | {GetTarget()} | {GetBonus()}";

    }
    public override string StringRepresentation()
    {
        return $"Check List Goal: {GetName()} | {GetDescription} | {GetPoint()} | {GetAmountCompleted()} | {GetTarget()} | {GetBonus()}";
    }
}