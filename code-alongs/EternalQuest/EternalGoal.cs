public class EternalGoal : Goal
{
    

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }


        public override int Update()
    {
        return _points;
        
    }
}