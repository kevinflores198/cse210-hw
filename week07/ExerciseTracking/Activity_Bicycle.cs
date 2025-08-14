public class Activity_bicycles : Activity
{
    private double _speed;
    public Activity_bicycles(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }
    public Activity_bicycles()
    {
    }
    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override string GetSummary()
    {
        return $"---Cycling---\n: {GetDate():dd MMM yyyy} ({GetMinutes()} min) - " +
           $"\nDistance: {GetDistance()} km, " +
           $"\nSpeed: {GetSpeed()} kph, " +
           $"\nPace: {GetPace()} min per km";
    }
}