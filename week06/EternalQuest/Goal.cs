using System;

public class Goal
{
    public string Name;
    public int Points;
    public bool Completed;

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        Completed = false;
    }

    public virtual void RecordEvent()
    {
        Completed = true;
    }

    public virtual string GetDetails()
    {
        return $"{Name} ({Points} pts) - {(Completed ? "Completed" : "Incomplete")}";
    }
}