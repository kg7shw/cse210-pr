public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal|{_name}|{_description}|{_points}";
    }
}
