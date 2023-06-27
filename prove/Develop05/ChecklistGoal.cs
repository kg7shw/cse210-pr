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


    public override void Display()
    {
        Console.WriteLine($"{_name}  ({_description}) -- Currently Completed: {_currentCount}/{_targetCount}");
    }


        public override string GetStringRepresentation()
    {
        return $"Simple Goal|{_name}|{_description}|{_points}|{_targetCount}|{_currentCount}";
    }
}
