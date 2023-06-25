public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount = 0;

    public ChecklistGoal(string name, string description, int points, int targetCount) : base(name, description, points)
    {
        _targetCount = targetCount;
    }

    public override int Update()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            _done = true;
            return _points + 500; // Bonus points for completing the checklist goal
        }
        else
        {
            return _points;
        }
    }
}
