public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return false; /*Ongoing*/
    }

    public override string GetStringRepresentation()
    {
        return $"ETERNAL,{_shortName},{_description},{_points}";
    }
}