using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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
        string jsonString = JsonSerializer.Serialize(_goals);
        File.WriteAllText("goals.json", jsonString);
        Console.WriteLine("Goals saved successfully.");
    }

    public void Load()
    {
        try
        {
            string jsonString = File.ReadAllText("goals.json");
            _goals = JsonSerializer.Deserialize<List<Goal>>(jsonString);
            Console.WriteLine("Goals loaded successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No saved goals found.");
        }
        catch (JsonException)
        {
            Console.WriteLine("Error while loading goals. Invalid file format.");
        }
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

    public Goal GetGoalByName(string name)
    {
        foreach (var goal in _goals)
        {
            if (goal.GetName() == name)
            {
                return goal;
            }
        }
        return null;
    }
}
