public class Cycling : Activity
{
    private double _speed; // speed in mph

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * Minutes) / 60; // Distance = Speed * Time
    }

    public override double GetSpeed()
    {
        return _speed; // Returns the speed directly (miles per hour)
    }

    public override double GetPace()
    {
        return 60 / GetSpeed(); // Pace = 60 / Speed (minutes per mile)
    }
}
