class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

     public int Bonus => _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted < _target)
        {
            Console.WriteLine($"Checklist Goal '{_shortName}' recorded! Earned {_points} points. Progress: {_amountCompleted}/{_target}");
        }
        else if (_amountCompleted == _target)
        {
            Console.WriteLine($"Checklist Goal '{_shortName}' completed! Earned {_points} points + bonus of {_bonus} points!");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;
    public override string GetDetailsString() => $"{base.GetDetailsString()} - Completed {_amountCompleted}/{_target}";
    public override string GetStringRepresentation() => $"[ChecklistGoal] {_shortName} - Progress: {_amountCompleted}/{_target}";
}