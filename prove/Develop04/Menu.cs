public class Menu
{
    private Activity activity;

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
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit\n");

            Console.Write("What do you want to do? ");
            response = Console.ReadLine() ?? string.Empty;

            switch (response)
            {
                case "1":
                    activity.StartingMessage("Description of breathing activity", "Breathing Activity");
                    // Perform breathing activity logic here
                    activity.EndingMessage(activity.GetDuration(), "Breathing Activity");
                    break;

                case "2":
                    activity.StartingMessage("Description of reflection activity", "Reflection Activity");
                    // Perform reflection activity logic here
                    activity.EndingMessage(activity.GetDuration(), "Reflection Activity");
                    break;

                case "3":
                    activity.StartingMessage("Description of listing activity", "Listing Activity");
                    // Perform listing activity logic here
                    activity.EndingMessage(activity.GetDuration(), "Listing Activity");
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
