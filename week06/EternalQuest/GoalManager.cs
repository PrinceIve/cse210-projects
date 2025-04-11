using System;
using System.Collections.Generic;

public class GoalManager
{
    public List<Goal> Goals = new List<Goal>();
    public int TotalPoints = 0;

    public void CreateSimpleGoal(string name, int points)
    {
        Goals.Add(new SimpleGoal(name, points));
    }

    public void CreateEternalGoal(string name, int points)
    {
        Goals.Add(new EternalGoal(name, points));
    }

    public void CreateChecklistGoal(string name, int points, int targetCount)
    {
        Goals.Add(new ChecklistGoal(name, points, targetCount));
    }

    public void RecordGoalEvent(int index)
    {
        if (index >= 0 && index < Goals.Count)
        {
            Goals[index].RecordEvent();
            TotalPoints += Goals[index].Points;
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (var goal in Goals)
        {
            Console.WriteLine(goal.GetDetails());
        }
    }

    public void DisplayPointsAndRank()
    {
        Console.WriteLine($"Total Points: {TotalPoints}");
        Console.WriteLine($"Current Rank: {GetRank(TotalPoints)}");
    }

    public string GetRank(int points)
{
    if (points >= 1000) return "Master Achiever - Keep up the amazing work!";
    if (points >= 500) return "Goal Crusher - You're crushing your goals!";
    if (points >= 250) return "Goal Getter - Great progress!";
    if (points >= 100) return "Aspiring Achiever - Keep pushing!";
    return "Goal Novice - Start your journey!";
}

}