class Goal
{
    private int _id;
    private String _description;
    private int _points;
    private bool _complete;
 
    public Goal(int id, String description, int points)
    {
        _id = id;
        _description = description;
        _points = points;
    }

    public String GetID()
    {
        return _id.ToString();
    }

    public virtual void Complete()
    {
        _complete = true; 
    }

    public void AddPoints(int points)
    {
        _points += points;
    }
    public int GetPoints()
    {
        return _points;
    }
    public virtual void DisplayStatus()
    {
        Console.WriteLine();
    }

    public void SetComplete()
    {
        _complete = true;
    }

    public bool GetCompletion()
    {
        return _complete;
    }

    public String GetDescription()
    {
        return _description;
    }
}