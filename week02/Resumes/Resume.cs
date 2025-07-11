public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // this method will show person's name and a list of jobs, iteriting each job added before.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // With a foreach we iterate each job and we shows it getting it from Job.cs using the display.
        foreach (Job job in _jobs)
        {
            // can call each job's Display method that was created earlier.
            job.Display();
        }
    }
}