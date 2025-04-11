using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create instances of different activities
        Running running = new Running(new DateTime(2022, 11, 3), 30, 8.0); // 8 miles
        Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 30, 16.0); // 16 mph
        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 40); // 40 laps

        // Create a list of activities
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Iterate through the list and print summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
