class SimpleGoal : Goal
{
    public SimpleGoal(int id, String description, int points) : base (id, description, points)
    {

    }

    public override void Complete()
    {
        AddPoints(GetPoints());
    }
    public override void DisplayStatus()
    {
        Console.WriteLine(GetID(), ". ", GetDescription(), GetCompletion() ? "[X]" : "[ ]");
    }
}