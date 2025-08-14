using System.Data;

public abstract class Activity
{
    protected double _minutes { get; set; }
    protected double _laps { get; set; }
    protected double _speed { get; set; }
    protected double _distance { get; set; }
    protected double _pace { get; set; }
    protected string _today { get; set; }
    public Activity() { }
    public abstract void GetSummary();
    public abstract void GetDistance();
    public abstract void GetSpeed();
    public abstract void GetPace();
}