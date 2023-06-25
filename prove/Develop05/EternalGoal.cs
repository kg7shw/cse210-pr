public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int Update()
    {
        // For eternal goals, the points are earned every time the goal is recorded
        return _points;
    }
}
