public class ChecklistGoal : Goal
{
    private int _targetCount;
    public int _currentCount = 0;

    public ChecklistGoal(string name, string description, int points, int targetCount) : base(name, description, points)
    {
        _targetCount = targetCount;
    }

    public override int Update()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            Done = true;
            return Points + 500; // Bonus points for completing the checklist goal
        }
        else
        {
            return Points;
        }
    }

    public override void Display()
    {
        Console.WriteLine($"{Name}  ({Description}) -- Currently Completed: {_currentCount}/{_targetCount}");
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal|{Name}|{Description}|{Points}|{_targetCount}|{_currentCount}";
    }
}
