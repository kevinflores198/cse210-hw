using System.Diagnostics.CodeAnalysis;

public class Activity_Listing : Activity
{
    private int _counter;
    private List<string> _promptList;
    public Activity_Listing()
    {

    }
    public Activity_Listing(int counter, string name, string description, int duration)
    : base(name, description, duration)
    {
        _counter = counter;
    }

    public void Run()
    {
        System.Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        System.Console.WriteLine("How long, in seconds, would you like for you session?");
        _duration = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Get ready...");
        Spinner(5);
        System.Console.WriteLine("List as many responses you can to the folowing promt:\n");
        string prompt = RandomPrompt();
        System.Console.WriteLine(prompt);
        System.Console.Write("\nYou may begin in: ");
        Counter(5);
        Console.Clear();
        ListItems();
    }


    public string RandomPrompt()
    {
        _promptList = new List<string>()
        {
            ">> Who are people that you appreciate? <<"
            ,">> What are personal strengths of yours? <<"
            ,">> Who are people that you have helped this week? <<"
            ,">> When have you felt the Holy Ghost this month? <<"
            ,">> Who are some of your personal heroes <<?"
        };

        Random r = new Random();
        return _promptList[r.Next(_promptList.Count)];
    }
    public void ListItems()
    {
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }
        int counters = responses.Count();
        System.Console.WriteLine($"\nYou listed {counters} items!");
    }

}
