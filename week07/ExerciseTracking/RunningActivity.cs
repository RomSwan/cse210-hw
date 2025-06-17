public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes} min)- Distance {GetDistance()} km, Speed {GetSpeed()} km, Pace: {GetPace()} min per km";
    }
}