using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1994;
        job1._endYear = 2012;

        Job job2 = new Job();
        job2._jobTitle = "Devoloper";
        job2._company = "AMD";
        job2._startYear = 2004;
        job2._endYear = 2010;

        Resume myResume = new Resume();
        myResume._job.Add(job1);
        myResume._job.Add(job2);
        myResume._name = "John Smith";

        myResume.DisplayResumeInfo();

    }
}