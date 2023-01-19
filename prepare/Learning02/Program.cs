using System;

class Program
{
    static void Main(string[] args)
    {
        //First Job information
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle= "Computer programmer";
        job1._startYear= 2002;
        job1._endYear= 2022;

        //Second Job information
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Coca Cola Company";
        job2._startYear = 2010;
        job2._endYear = 2021;

        Resume Resume = new Resume();
        Resume._name = "Jhon Cyrus";
        Resume._jobs.Add(job1);
        Resume._jobs.Add(job2);

        Resume.Display();

    }
}