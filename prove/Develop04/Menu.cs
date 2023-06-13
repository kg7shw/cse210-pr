public class Menu
{
    private Activity activity = new Activity();
    private BreathingActivity breathingActivity = new BreathingActivity();
    private ListingActivity listingActivity = new ListingActivity();
    private ReflectionActivity reflectionActivity = new ReflectionActivity();

    private int duration;

    private string name;
    private string description;

    public Menu()
    {
        activity = new Activity();
    }

    public void DisplayMenu()
    {
        string response = "";
        while (response != "4")
        {
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Quit\n");

            Console.Write("What do you want to do? ");
            response = Console.ReadLine() ?? string.Empty;

            switch (response)
            {
                case "1":
                    name = breathingActivity.GetName();
                    description = breathingActivity.GetDescription();
                    activity.StartingMessage(description, name);
                    // duration = activity.GetDuration();
                    breathingActivity.PerformActivity();
                    activity.EndingMessage(duration, name);
                    break;

                case "2":
                    name = listingActivity.GetName();
                    description = breathingActivity.GetDescription();
                    activity.StartingMessage(description, name);
                    // duration = activity.GetDuration();
                    listingActivity.PerformActivity();
                    activity.EndingMessage(duration, name);
                    break;

                case "3":
                    name = reflectionActivity.GetName();
                    description = breathingActivity.GetDescription();
                    activity.StartingMessage(description, name);
                    // duration = activity.GetDuration();
                    reflectionActivity.PerformActivity();
                    activity.EndingMessage(duration, name);
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
