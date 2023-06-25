public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _done = false;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual void Display()
    {
        Console.WriteLine($"{_name} - {_description} - Points: {_points}");
    }

    public virtual int Update()
    {
        _done = true;
        return _points;
    }

    public virtual bool IsDone()
    {
        return _done;
    }

    public string GetName()
    {
        return _name;
    }
}
