using System.Data;

public class Activity_Running : Activity
{
    public Activity_Running() : base()
    {
    }
    public override void GetDistance()
    {
        System.Console.WriteLine("When did you do this activity");
        _today = Console.ReadLine();
        System.Console.WriteLine("How many minutes you ran?");
        _minutes = double.Parse(Console.ReadLine());
        System.Console.WriteLine("What was the distance you ran?(km)");
        _distance = double.Parse(Console.ReadLine());
    }
    public override void GetPace()
    {
        throw new NotImplementedException();
    }

    public override void GetSpeed()
    {
        throw new NotImplementedException();
    }
    public override void GetSummary()
    {
        System.Console.WriteLine(
            $"{_today}:\n--- Running --- ({_minutes} minutes)\nDistance: {_distance}km\nSpeed: {_speed}kph\nPace: {_pace} min per km");
    }

}