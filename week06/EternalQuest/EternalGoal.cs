public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        // Eternal goals are never marked complete
    }

    public override string GetDetails()
    {
        return $"{Name} ({Points} pts) - Eternal Goal";
    }
}