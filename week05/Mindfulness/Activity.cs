using System.Runtime;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage(string _name)
    {
        System.Console.WriteLine($"Welcome to the {_name} activity:");
    }
    public void DisplayEndingMessage(string name)
    {
        System.Console.WriteLine($"Well done {name}!!");
    }

    public void Spinner(int time)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            System.Console.Write(s);
            Thread.Sleep(1000);
            System.Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }
    public int Counter(int time)
    {
        for (int i = time; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            System.Console.Write("\b \b");
        }
        return time;
    }
}