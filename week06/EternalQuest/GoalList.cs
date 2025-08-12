public class GoalList : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public GoalList(string name, string description, int point,int amountCompleted, int target, int bonus) : base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public GoalList()
    {
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
        if (_amountCompleted < _target)
        {
            System.Console.WriteLine("You have completed another Check list goal!");
            _amountCompleted++;
        }
        else if (_amountCompleted == _target)
        {
            System.Console.WriteLine("Goal completed. Can go to main menu and create another one.");
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string StringRepresentation()
    {
        return $"Check list Goal|{_name}|{_description}|{_point}|{_amountCompleted}|{_target}|{_bonus}";
    }
    public override string DetailString()
    {
        if (_target == _amountCompleted)
        {
        return $"[x] Check list goals | {_name} ({_description}) | Completed: {_amountCompleted}/{_target} | Bonus: '{_bonus}'";
        }
        else
        {
        return $"[ ] Check list goals | {_name} ({_description}) | Completed: {_amountCompleted}/{_target} | Bonus: '{_bonus}'";
            
        }
    }
}