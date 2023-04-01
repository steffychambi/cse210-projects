using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating a list of activities
        List<Activity> activities = new List<Activity>();

        //Creating a Running Activity
        Running activity1 = new Running("03 Nov 2022", 30, 68.56);
        activities.Add(activity1);

        //Creating a Cycling Activity
        Cycling activity2 = new Cycling("03 Mar 2022", 35, 76.89);
        activities.Add(activity2);

        //Creating a Swimming Activity
        Swimming activity3 = new Swimming("05 Apr 2022", 20, 6);
        activities.Add(activity3);

        Console.Clear();

        foreach (Activity a in activities)
        {
            string summary = a.GetSummary();
            Console.WriteLine(summary);
        }
    }
}