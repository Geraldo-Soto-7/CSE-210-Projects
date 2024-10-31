class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal Goal '{_shortName}' recorded! Earned {_points} points.");
    }

    public override bool IsComplete() => false;
    public override string GetStringRepresentation() => $"[EternalGoal] {_shortName}";
}
