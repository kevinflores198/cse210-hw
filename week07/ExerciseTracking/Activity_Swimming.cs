using System.Data;

public class Activity_Swimming : Activity
{
    private int _laps;
    public Activity_Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public Activity_Swimming() : base()
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
        return (_laps * 50) / 1000;
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