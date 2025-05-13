using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2005";
        job1._endYear = "2015";

        Job job2 = new Job();
        job2._jobTitle = "Salesman";
        job2._company = "Apple";
        job2._startYear = "2022";
        job2._endYear = "2025";

        Resume resume = new Resume();

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume._name = "John Smith";

        resume.DisplayJobDetails();
    }
}