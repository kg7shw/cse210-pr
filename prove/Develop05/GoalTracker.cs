using System;
using System.Collections.Generic;

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
        // Implement code to save the goals and score to a file or database
        // You can use serialization or any other suitable method
    }

    public void Load()
    {
        // Implement code to load the goals and score from a file or database
        // You can use deserialization or any other suitable method
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        int pointsEarned = goal.Update();
        _score += pointsEarned;
        Console.WriteLine($"Event recorded for goal: {goal.GetName()}");
        Console.WriteLine($"Points earned: {pointsEarned}");
        Console.WriteLine($"Total score: {_score}");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            string status = goal.IsDone() ? "[X]" : "[ ]";
            Console.Write($"{status} ");
            goal.Display();
        }
    }
}
