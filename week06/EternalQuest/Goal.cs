public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _point;
    public Goal() { }
    public Goal(string name, string description, int point)
    {
        _name = name;
        _description = description;
        _point = point;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPoint()
    {
        return _point;
    }
    public void SetPoint(int point)
    {
        _point = point;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string StringRepresentation();
    public abstract string DetailString();
}