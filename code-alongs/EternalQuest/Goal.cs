public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool Done { get; set; }

    public Goal() { }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public virtual void Display()
    {
        Console.WriteLine($"{Name}  ({Description}) - Point value: {Points}");
    }

    public virtual int Update()
    {
        Done = true;
        return Points;
    }

    public virtual bool IsDone()
    {
        return Done;
    }

    public abstract string GetStringRepresentation();
}
