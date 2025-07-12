using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // We create a new instance called job1, and so.
        Job job1 = new Job();
        // Define member variables to add in the instance for job1, same for job2 and resume.
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume resume = new Resume();

        resume._name = "Allison Rose";
        // WeakReference use Add function to add each job into the list _jobs.
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}