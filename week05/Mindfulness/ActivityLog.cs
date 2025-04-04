using System;
using System.Collections.Generic;

public class ActivityLog
{
    private Dictionary<string, int> activityCounts;

    public ActivityLog()
    {
        activityCounts = new Dictionary<string, int>();
    }

    // Increment the count for the specified activity
    public void LogActivity(string activityName)
    {
        if (activityCounts.ContainsKey(activityName))
        {
            activityCounts[activityName]++;
        }
        else
        {
            activityCounts[activityName] = 1;
        }
    }

    // Display the log of activity counts
    public void DisplayLog()
    {
        Console.WriteLine("\nActivity Log:");
        foreach (var activity in activityCounts)
        {
            Console.WriteLine($"{activity.Key}: {activity.Value} times");
        }
    }
}
