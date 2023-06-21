public class ChecklistGoal : IGoal
{
    private string name;
    private bool completed;
    private int value;
    private int points;
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int value, int targetCount)
    {
        this.name = name;
        this.value = value;
        completed = false;
        points = 0;
        this.targetCount = targetCount;
        currentCount = 0;
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

    public int GetTargetCount()
    {
        return targetCount;
    }

    public int GetCurrentCount()
    {
        return currentCount;
    }

    public void SetCurrentCount(int count)
    {
        currentCount = count;
    }

    public void MarkComplete()
    {
        currentCount++;
        points += value;

        if (currentCount == targetCount)
        {
            points += 500;
            completed = true;
        }
    }
}
