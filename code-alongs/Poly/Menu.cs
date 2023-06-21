public class Menu
{
    private GoalTracker goalTracker;

    public Menu()
    {
        goalTracker = new GoalTracker();
    }

    public void DisplayMenu()
    {
        Console.WriteLine("===== Goal Tracker Menu =====");
        Console.WriteLine("1. Create a goal");
        Console.WriteLine("2. Record an event");
        Console.WriteLine("3. Display goals");
        Console.WriteLine("4. Display score");
        Console.WriteLine("5. Exit program");
        Console.Write("Enter your choice: ");
    }

    public void ProcessChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                CreateGoal();
                break;
            case "2":
                RecordEvent();
                break;
            case "3":
                DisplayGoals();
                break;
            case "4":
                DisplayScore();
                break;
            case "5":
                Console.WriteLine("Exiting program...");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter the goal type (Simple/Eternal/Checklist): ");
        string goalType = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter the goal value: ");
        int goalValue = int.Parse(Console.ReadLine());

        if (goalType == "Checklist")
        {
            Console.Write("Enter the target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            goalTracker.CreateGoal(goalType, goalName, goalValue, targetCount);
        }
        else
        {
            goalTracker.CreateGoal(goalType, goalName, goalValue);
        }

        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        Console.Write("Enter the goal name: ");
        string goalName = Console.ReadLine();
        goalTracker.RecordEvent(goalName);
    }

    public void DisplayGoals()
    {
        goalTracker.DisplayGoals();
    }

    public void DisplayScore()
    {
        goalTracker.DisplayScore();
    }
}

// Rest of the code...
