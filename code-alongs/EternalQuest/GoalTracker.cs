public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _name;

    public GoalTracker(string name)
    {
        _name = name;
    }

    public void Save()
    {
        
    }
    public void load()
    {

    }
    public void RecordEvent()
    {
        
    }
    public void Display()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal);
        }
    }

}