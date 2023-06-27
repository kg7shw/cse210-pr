using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>();
    protected int _score = 0;
    // private string _name;



    public void Save(string filePath)
    {
        // string json = JsonConvert.SerializeObject(_goals, Formatting.Indented);
        // File.WriteAllText(filePath, json);
        // Console.WriteLine($"{_goals}");
        // Console.WriteLine($"{json}");
        // Console.WriteLine($"Goals saved to file: {filePath} ");


    }

    public void Load(string filePath)
    {
        // if (File.Exists(filePath))
        // {
        //     string json = File.ReadAllText(filePath);
        //     _goals = JsonConvert.DeserializeObject<List<Goal>>(json);
        //     Console.WriteLine($"Goals loaded from file: {filePath}");
        // }
        // else
        // {
        //     Console.WriteLine($"No file found at path: {filePath}");
        // }
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
            string status = goal.IsDone() ? "[✓]" : "[ ]";
            Console.Write($"{status} ");
            goal.Display();
            Console.WriteLine($"Total score: {_score}");
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
