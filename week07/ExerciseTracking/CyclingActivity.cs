public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _minutes / GetPace();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_minutes} min)- Distance {GetDistance()} km, Speed {GetSpeed()} km, Pace: {GetPace()} min per km";
    }
}