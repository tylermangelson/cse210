using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Job job3 = new Job();
        job3._jobTitle = "Party guy";
        job3._company = "Google";
        job3._startYear = 1993;
        job3._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        


        Resume myResume2 = new Resume();
        myResume2._name = "Billy Bob";

        myResume2._jobs.Add(job3);
        myResume2._jobs.Add(job2);

        myResume.Display();
        Console.WriteLine("");

        myResume2.Display();
    }
}