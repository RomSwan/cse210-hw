public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        _isComplete = true; /*One-time completion*/

        Console.WriteLine($"You earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SIMPLE,{_shortName},{_description},{_points},{_isComplete}";
    }
}