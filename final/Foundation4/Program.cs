using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running("25 Apr 2026", 30, 3.0);
        Cycling cycle = new Cycling("22 Oct 2024", 45, 12.5);
        Swimming swim = new Swimming("22 Jul 2026", 20, 60);

        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}