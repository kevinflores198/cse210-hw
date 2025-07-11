public class Job
{
    public Job()
    {
    }
    // Define variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // A display method must be used for showing the information of Job class.
    public void Display()
    {
        // format to show it in the main.
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

