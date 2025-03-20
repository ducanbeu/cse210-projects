class ChecklistGoal : Goal
{
    private int _iterations;
    private int _completions;
    private int _bonus;
    public ChecklistGoal(int id, String description, int points, int iterations, int bonus) : base (id, description, points)
    {
        _iterations = iterations;
        _bonus = bonus;
    }

    public override void Complete()
    {
        _completions += 1;
        AddPoints(GetPoints());
        if (_completions >= _iterations)
        {
            AddPoints(_bonus);
        }
    }
    public override void DisplayStatus()
    {
        Console.WriteLine(GetID(), ". ", GetDescription(), "completed ", _completions, "/", _iterations, " times");
    }
}