class EternalGoal : Goal
{
    private int _completions;

    public EternalGoal(int id, String description, int points) : base (id, description, points)
    {

    }

    public override void Complete()
    {
        AddPoints(GetPoints());
        _completions += 1;
    }
    public override void DisplayStatus()
    {
        Console.WriteLine(GetID(), ". ", GetDescription(), "Completed ", _completions, " times.");
    }
}