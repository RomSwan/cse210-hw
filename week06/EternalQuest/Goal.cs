public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    public int _points; /*This is public so RecordEvent() in GoalManager can access it.*/

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }
}