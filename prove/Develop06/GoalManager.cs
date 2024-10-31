using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        // Implement main loop or menu logic here to interact with the user
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type (1. Simple, 2. Eternal, 3. Checklist): ");
        string choice = Console.ReadLine();
        Console.WriteLine("Enter name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter description: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;
        if (choice == "1")
        {
            goal = new SimpleGoal(name, description, points);
        }
        else if (choice == "2")
        {
            goal = new EternalGoal(name, description, points);
        }
        else
        {
            Console.WriteLine("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name, description, points, target, bonus);
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully.");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter goal name to record event: ");
        string name = Console.ReadLine();
        var goal = _goals.Find(g => g.GetStringRepresentation().Contains(name));

        if (goal != null)
        {
            goal.RecordEvent();
            _score += goal.Points; // Use Points property

            if (goal is ChecklistGoal checklistGoal)
            {
                if (checklistGoal.IsComplete())
                {
                    _score += checklistGoal.Bonus; // Use Bonus property
                }
            }
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void SaveGoals()
    {
         using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score); 
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation()); 
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine());
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
