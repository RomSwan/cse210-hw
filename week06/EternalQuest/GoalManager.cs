using System.IO;
using System.IO.Compression;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager() { }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("----MENU----");
            Console.WriteLine("Enter the number of one of the options below:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write(">");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                CreateGoal();
            }
            else if (input == "2")
            {
                Console.Clear();
                ListGoalDetails();
            }
            else if (input == "3")
            {
                Console.Clear();
                SaveGoals();
            }
            else if (input == "4")
            {
                Console.Clear();
                LoadGoals();
            }
            else if (input == "5")
            {
                Console.Clear();
                RecordEvent();
            }
            else if (input == "6")
            {
                Console.Clear();
                Console.WriteLine("Don't forget to continue working on your goals! ;)");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("--INVALID REQUEST--\n");
            }
        }
    }

    public void DisplayUserScore()
    {
        Console.WriteLine($"\nCurrent Score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            string checkbox = "[ ]";

            if (_goals[i].IsComplete() == true)
            {
                checkbox = "[X]";
            }

            Console.WriteLine($"{i + 1}. {checkbox} {_goals[i].GetDetailsString()}");
        }

        DisplayUserScore();
        Console.WriteLine(); /*Here for formatting*/
    }

    public void CreateGoal()
    {
        Console.WriteLine("Goal types:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Choose goal type: ");
        string type = Console.ReadLine();

        Console.Write("Goal name: ");
        string name = Console.ReadLine();

        Console.Write("Goal description: ");
        string description = Console.ReadLine();

        Console.Write("Points when completed: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("Target amount: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }

        Console.Clear();
        Console.WriteLine("--GOAL CREATED--\n");
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("\nWhich goal did you complete?");
        Console.Write(">");

        int index = int.Parse(Console.ReadLine());
        index = index - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();

            if (goal is SimpleGoal)
            {
                _score += ((SimpleGoal)goal)._points;
            }
            else if (goal is EternalGoal)
            {
                _score += ((EternalGoal)goal)._points;
            }
            else if (goal is ChecklistGoal)
            {
                ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                _score += checklistGoal._points;

                if (checklistGoal.IsComplete())
                {
                    _score += checklistGoal._bonus;
                }
            }
        }

        DisplayUserScore();
    }

    public void SaveGoals()
    {
        Console.WriteLine("Save goals to which file?");
        Console.Write(">");
        string file = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.Clear();
        Console.WriteLine("--GOALS SAVED--\n");
    }

    public void LoadGoals()
    {
        _goals.Clear();

        Console.WriteLine("Load which file?");
        Console.Write(">");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] part = lines[i].Split(",");
            string type = part[0];

            if (type == "SIMPLE")
            {
                string name = part[1];
                string description = part[2];
                int points = int.Parse(part[3]);
                bool complete = bool.Parse(part[4]);

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);

                if (complete)
                {
                    simpleGoal.RecordEvent();
                }

                _goals.Add(simpleGoal);
            }
            else if (type == "ETERNAL")
            {
                string name = part[1];
                string description = part[2];
                int points = int.Parse(part[3]);

                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "CHECKLIST")
            {
                string name = part[1];
                string description = part[2];
                int points = int.Parse(part[3]);
                int target = int.Parse(part[4]);
                int bonus = int.Parse(part[5]);
                int completed = int.Parse(part[6]);

                ChecklistGoal checkListGoal = new ChecklistGoal(name, description, points, target, bonus);

                for (int x = 0; x < completed; x++)
                {
                    checkListGoal.RecordEvent();
                }

                _goals.Add(checkListGoal);
            }
        }

        Console.Clear();
        Console.WriteLine("--GOALS LOADED--\n");
    }
}