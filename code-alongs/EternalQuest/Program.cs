using System;

class Program
{
    static void Main()
    {
        GoalTracker tracker = new GoalTracker();

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("======Menu Options======");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Select goal type:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Enter goal type: ");
                    string goalType = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Enter goal name: ");
                    string goalName = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("Enter goal points: ");
                    int points = int.Parse(Console.ReadLine());

                    switch (goalType)
                    {
                        case "1":
                            Goal simpleGoal = new SimpleGoal(goalName, goalDescription, points);
                            tracker.AddGoal(simpleGoal);
                            Console.WriteLine("Simple goal added!");
                            break;

                        case "2":
                            Goal eternalGoal = new EternalGoal(goalName, goalDescription, points);
                            tracker.AddGoal(eternalGoal);
                            Console.WriteLine("Eternal goal added!");
                            break;

                        case "3":
                            Console.Write("Enter target count: ");
                            int targetCount = Convert.ToInt32(Console.ReadLine());
                            Goal checklistGoal = new ChecklistGoal(goalName, goalDescription, points, targetCount);
                            tracker.AddGoal(checklistGoal);
                            Console.WriteLine("Checklist goal added!");
                            break;

                        default:
                            Console.WriteLine("Invalid goal type.");
                            break;
                    }

                    Console.WriteLine();
                    break;

                case "2":
                    tracker.DisplayGoals();
                    Console.WriteLine();
                    break;

                case "3":
                    Console.Write("Enter goal name: ");
                    string eventName = Console.ReadLine();
                    Goal? goal = tracker.GetGoalByName(eventName);
                    if (goal != null)
                    {
                        tracker.RecordEvent(goal);
                    }
                    else
                    {
                        Console.WriteLine("Goal not found.");
                    }
                    Console.WriteLine();
                    break;

                case "4":
                    Console.Write("Enter the file path to save the goals: ");
                    string savePath = Console.ReadLine();
                    tracker.Save(savePath);
                    Console.WriteLine();
                    break;

                case "5":
                    Console.Write("Enter the file path to load the goals: ");
                    string loadPath = Console.ReadLine();
                    tracker.Load(loadPath);
                    Console.WriteLine();
                    break;

                case "6":
                    quit = true;
                    Console.Write("Enter the file path to save the goals: ");
                    savePath = Console.ReadLine();
                    tracker.Save(savePath);
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
