public class GoalTracker
{
    private List<IGoal> goals;
    private int score;

    public GoalTracker()
    {
        goals = new List<IGoal>();
        score = 0;
    }
    public void CreateGoal(string goalType, string name, int value, int targetCount = 0)
    {
        IGoal goal;

        switch (goalType)
        {
            case "Simple":
                goal = new SimpleGoal(name, value);
                break;
            case "Eternal":
                goal = new EternalGoal(name, value);
                break;
            case "Checklist":
                goal = new ChecklistGoal(name, value, targetCount);
                break;
            default:
                throw new ArgumentException("Invalid goal type.");
        }

        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        IGoal goal = goals.Find(g => g.GetName() == goalName);

        if (goal != null)
        {
            if (!goal.IsCompleted())
            {
                goal.MarkComplete();
                score += goal.GetPoints();
                Console.WriteLine("Event recorded for goal: " + goalName);
            }
            else
            {
                Console.WriteLine("Goal already completed: " + goalName);
            }
        }
        else
        {
            Console.WriteLine("Goal not found: " + goalName);
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (IGoal goal in goals)
        {
            string status = goal.IsCompleted() ? "[X]" : "[ ]";
            string goalDetails = status + " " + goal.GetName();

            if (goal is ChecklistGoal checklistGoal)
            {
                goalDetails += " (Completed " + checklistGoal.GetCurrentCount() + "/" + checklistGoal.GetTargetCount() + " times)";
            }

            Console.WriteLine(goalDetails);
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine("Score: " + score);
    }
}
