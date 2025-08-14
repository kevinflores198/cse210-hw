using System.Data;

public class ActivitySwimming : Activity
{
    private int _laps;
    public ActivitySwimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public ActivitySwimming() : base()
    {
    }
    public int GetLaps()
    {
        return _laps;
    }
    public void SetLaps(int laps)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return (GetLaps() * 50) / 1000;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }
    public override double GetPace()
    {
        return GetMinutes() / GetSpeed();
    }
    public override string GetSummary()
    {
        return $"---Swimming---\n: {GetDate():dd MMM yyyy} ({GetMinutes()} min) - " +
           $"\nDistance: {GetDistance()} km, " +
           $"\nSpeed: {GetSpeed()} kph, " +
           $"\nPace: {GetPace()} min per km";
    }
}