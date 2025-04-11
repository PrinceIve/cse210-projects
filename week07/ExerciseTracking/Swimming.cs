public class Swimming : Activity
{
    private int _laps; // Number of laps in the pool

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; // Distance in kilometers (50 meters per lap)
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60; // Speed in kilometers per hour
    }

    public override double GetPace()
    {
        return Minutes / GetDistance(); // Pace in minutes per kilometer
    }
}
