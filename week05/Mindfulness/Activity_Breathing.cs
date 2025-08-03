public class Activity_Breathing : Activity
{
    public Activity_Breathing() { }
    public Activity_Breathing(string name, string description, int duration)
    : base(name, description, duration)
    { }
    public void Run()
    {
        System.Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
        System.Console.WriteLine("How long, in seconds, would you like for you session?");
        _duration = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Get ready...");
        Spinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            System.Console.WriteLine($"Breathe in...");
            Counter(3);
            System.Console.WriteLine("Now breathe out...");
            Counter(3);
        }
    }

}
