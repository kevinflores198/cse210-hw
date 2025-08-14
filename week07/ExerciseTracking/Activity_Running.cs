using System.Data;

public class Activity_Running : Activity
{
    private double _distance;
    public Activity_Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    public Activity_Running()
    {
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
    public override string GetSummary()
    {
            return $"---Running---\n {GetDate():dd MMM yyyy} ({GetMinutes()} min) - " +
           $"\nDistance: {GetDistance()} km, " +
           $"\nSpeed: {GetSpeed()} kph, " +
           $"\nPace: {GetPace()} min per km";
    }
}