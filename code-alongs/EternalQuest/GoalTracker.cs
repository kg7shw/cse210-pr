using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>();
    protected int _score = 0;

    public void Save(string filePath)
    {
        List<string> goalStrings = new List<string>();
        foreach (var goal in _goals)
        {
            goalStrings.Add(goal.GetStringRepresentation());
        }

        string jsonResult = JsonConvert.SerializeObject(goalStrings, Formatting.Indented);
        File.WriteAllText(filePath, jsonResult);

        Console.WriteLine($"Goals saved to file: {filePath}");
    }

    public void Load(string filePath)
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            List<string>? goalStrings = JsonConvert.DeserializeObject<List<string>>(json);
            if (goalStrings != null)
            {
                foreach (var goalString in goalStrings)
                {
                    string[] goalData = goalString.Split('|');
                    string goalType = goalData[0];
                    string name = goalData[1];
                    string description = goalData[2];
                    int points = int.Parse(goalData[3]);

                    Goal? goal = null;
                    switch (goalType)
                    {
                        case "Simple Goal":
                            goal = new SimpleGoal(name, description, points);
                            break;

                        case "Eternal Goal":
                            goal = new EternalGoal(name, description, points);
                            break;

                        case "Checklist Goal":
                            int targetCount = int.Parse(goalData[4]);
                            int currentCount = int.Parse(goalData[5]);
                            goal = new ChecklistGoal(name, description, points, targetCount)
                            {
                                Done = currentCount >= targetCount,
                                _currentCount = currentCount
                            };
                            break;

                        default:
                            Console.WriteLine($"Unknown goal type: {goalType}");
                            continue;
                    }

                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }

                Console.WriteLine($"Goals loaded from file: {filePath}");
            }
        }
        else
        {
            Console.WriteLine($"No file found at path: {filePath}");
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
        Console.WriteLine($"Event recorded for goal: {goal.Name}");
        Console.WriteLine($"Points earned: {pointsEarned}");
        Console.WriteLine($"Total score: {_score}");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            string status = goal.Done ? "[✓]" : "[ ]";
            Console.Write($"{status} ");
            goal.Display();
            Console.WriteLine($"Total score: {_score}");
        }
    }

    public Goal? GetGoalByName(string name)
    {
        foreach (var goal in _goals)
        {
            if (goal.Name == name)
            {
                return goal;
            }
        }
        return null;
    }
}
