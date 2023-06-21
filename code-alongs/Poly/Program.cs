class Program
{
    static void Main(string[] args)
    {
        // GoalTracker goalTracker = new GoalTracker();

        // // Create goals
        // goalTracker.CreateGoal("Simple", "Run a marathon", 1000);
        // goalTracker.CreateGoal("Eternal", "Read scriptures", 100);
        // goalTracker.CreateGoal("Checklist", "Attend the temple", 50, 10);

        // // Record events
        // goalTracker.RecordEvent("Run a marathon");
        // goalTracker.RecordEvent("Read scriptures");
        // goalTracker.RecordEvent("Read scriptures");
        // goalTracker.RecordEvent("Attend the temple");
        // goalTracker.RecordEvent("Attend the temple");
        // goalTracker.RecordEvent("Attend the temple");

        // // Display goals and score
        // goalTracker.DisplayGoals();
        // goalTracker.DisplayScore();


        Menu menu = new Menu();

        while (true)
        {
            menu.DisplayMenu();
            string choice = Console.ReadLine();
            menu.ProcessChoice(choice);
        }
    }
}
