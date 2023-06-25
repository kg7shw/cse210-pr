public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _done = false;

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
