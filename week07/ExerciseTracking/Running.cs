public class Running : Activity
{
    private double _distance; // in miles

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance; // Returns the distance directly (miles)
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60; // Speed in miles per hour
    }

    public override double GetPace()
    {
        return Minutes / GetDistance(); // Pace in minutes per mile
    }
}
