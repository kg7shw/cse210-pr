public class EternalGoal : IGoal
{
    private string name;
    private bool completed;
    private int value;
    private int points;

    public EternalGoal(string name, int value)
    {
        this.name = name;
        this.value = value;
        completed = false;
        points = 0;
    }

    public string GetName()
    {
        return name;
    }

    public bool IsCompleted()
    {
        return completed;
    }

    public int GetValue()
    {
        return value;
    }

    public int GetPoints()
    {
        return points;
    }

    public void MarkComplete()
    {
        points += value;
    }
}
