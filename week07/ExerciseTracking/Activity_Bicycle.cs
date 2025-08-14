public class Activity_bicycles : Activity
{
    public Activity_bicycles() : base()
    {
    }
    public override void GetDistance()
    {
        _distance = _speed * _minutes;
    }
    public override void GetSpeed()
    {
        System.Console.WriteLine("When did you do this activity");
        _today = Console.ReadLine();
        System.Console.WriteLine("How many minutes you rode the bike?");
        _minutes = double.Parse(Console.ReadLine());
        System.Console.WriteLine("What is the speed?");
        _speed = double.Parse(Console.ReadLine());
    }
    public override void GetPace()
    {
        throw new NotImplementedException();
    }
    public override void GetSummary()
    {
        System.Console.WriteLine(
    $"{_today}:\n--- Bicycle --- ({_minutes} minutes)\nDistance: {_distance}km\nSpeed: {_speed}kph\nPace: {_pace} min per km");

    }
}