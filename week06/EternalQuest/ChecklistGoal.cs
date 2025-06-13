public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    public int _bonus; /*This is public so RecordEvent() in GoalManager can access it.*/

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;

        Console.WriteLine($"You earned {_points} points!");

        if (_amountCompleted > _target)
        {
            Console.WriteLine($"You earned a bonus of {_bonus} points!");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted < _target) /*Reach target to complete*/
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- Completed: {_amountCompleted}/{_target}";
    }
    
    public override string GetStringRepresentation()
    {
        return $"CHECKLIST,{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}