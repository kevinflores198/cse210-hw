using System.Data;

public class Activity_Reflecting : Activity
{
    List<string> _promptList;
    List<string> _questionList;

    public Activity_Reflecting() : base()
    {
    }
    public void Run()
    {
        System.Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        System.Console.WriteLine("How long, in seconds, would you like for you session?");
        _duration = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Get ready...");
        Spinner(5);

        System.Console.WriteLine($"Consider the following prompt: \n");
        DisplayPrompt();

        System.Console.WriteLine("When you have something in mind, press enter continue");
        string continues = Console.ReadLine();

        System.Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        Counter(3);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            Spinner(5);
        }
    }
    public string RandomPrompt()
    {
        _promptList = new List<string>
        {
            "Think of a time when you stood up for someone else."
            ,"Think of a time when you did something really difficult."
            ,"Think of a time when you helped someone in need."
            ,"Think of a time when you did something truly selfless."
        };
        Random r = new Random();
        return _promptList[r.Next(_promptList.Count)];
    }
    public string RandomQuestion()
    {
        _questionList = new List<string>
        {
            "Why was this experience meaningful to you?"
            ,"Have you ever done anything like this before?"
            ,"How did you get started?"
            ,"How did you feel when it was complete?"
            ,"What made this time different than other times when you were not as successful?"
            ,"What is your favorite thing about this experience?"
            ,"What could you learn from this experience that applies to other situations?"
            ,"What did you learn about yourself through this experience?"
            ,"How can you keep this experience in mind in the future?"
        };
        Random r = new Random();
        return _questionList[r.Next(_questionList.Count)];
    }
    public void DisplayPrompt()
    {
        System.Console.Write(RandomPrompt());
    }
    public void DisplayQuestion()
    {
        System.Console.WriteLine(RandomQuestion());
    }
}
