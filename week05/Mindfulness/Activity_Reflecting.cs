public class Activity_Reflecting : Activity
{
    List<string> _promptList;
    List<string> _questionList;

    public Activity_Reflecting()
    {
        _promptList = new List<string>
        {
            "Think of a time when you stood up for someone else."
            ,"Think of a time when you did something really difficult."
            ,"Think of a time when you helped someone in need."
            ,"Think of a time when you did something truly selfless."
        };

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
    }
    public void Run()
    {
        System.Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        System.Console.WriteLine("How long, in seconds, would you like for you session?");
        int time = int.Parse(Console.ReadLine());
        int cycle = 6;
        while (time >= cycle)
        {

            time -= cycle;
        }
    }
    public string RandomPrompt()
    {
        Random r = new Random();
        return _promptList[r.Next(_promptList.Count)];
    }
    public string RandomQuestion()
    {
        Random r = new Random();
        return _questionList[r.Next(_questionList.Count)];
    }
    public void DisplayPrompt()
    {
        System.Console.WriteLine(RandomPrompt());
    }
    public void DisplayQuestion()
    {
        System.Console.WriteLine(RandomQuestion());
    }
}
