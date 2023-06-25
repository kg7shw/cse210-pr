class Program
{
    static void Main()
    {
        GoalTracker tracker = new GoalTracker("John");

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("======Menu Options======");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(tracker);
                    break;
                case "2":
                    tracker.DisplayGoals();
                    break;
                case "3":
                    tracker.Save();
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case "4":
                    tracker.Load();
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case "5":
                    RecordEvent(tracker);
                    break;
                case "6":
                    quit = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CreateNewGoal(GoalTracker tracker)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = Convert.ToInt32(Console.ReadLine());

        SimpleGoal goal = new SimpleGoal(name, description, points);
        tracker.AddGoal(goal);

        Console.WriteLine("New goal created successfully.");
    }

    static void RecordEvent(GoalTracker tracker)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Goal goal = tracker.GetGoalByName(name);
        if (goal != null)
        {
            tracker.RecordEvent(goal);
        }
        else
        {
            Console.WriteLine("Goal not found. Please try again.");
        }
    }
}
