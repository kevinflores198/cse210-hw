using System.Data;

public class Activity_Swimming : Activity
{
    public Activity_Swimming() : base()
    {
    }
    public override void GetDistance()
    {
        throw new NotImplementedException();
    }

    public override void GetSpeed()
    {
        throw new NotImplementedException();
    }

    public override void GetPace()
    {
        System.Console.WriteLine("When did you do this activity");
        _today = Console.ReadLine();
        System.Console.WriteLine("How many minutes you swam?");
        _minutes = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Whay is the number of laps?");
        _laps = double.Parse(Console.ReadLine());
    }

    public override void GetSummary()
    {
        System.Console.WriteLine(
            $"{_today}:\n--- Running --- ({_minutes} minutes)\nLaps: {_laps}km\nSpeed: {_speed}kph\nPace: {_pace} min per km");
    }
}