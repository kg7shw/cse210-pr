using System;
using System.Collections.Generic;
using System.Threading;

public class Menu
{
    private List<Activity> activities;

    public Menu()
    {
        activities = new List<Activity>
        {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity()
        };
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
                    PerformActivity(activities[0]);
                    break;

                case "2":
                    PerformActivity(activities[1]);
                    break;

                case "3":
                    PerformActivity(activities[2]);
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }

    private void PerformActivity(Activity activity)
    {
        activity.StartingMessage();
        activity.PerformActivity();
        activity.EndingMessage();
    }
}
