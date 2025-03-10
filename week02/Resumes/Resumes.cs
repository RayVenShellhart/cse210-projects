using System;

public class Resume
{
    public string _name;

    public List<Job> _job = new List<Job>();

    public void DisplayResumeInfo()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _job)
        {
            job.DisplayJobInfo();
        }
    }
}