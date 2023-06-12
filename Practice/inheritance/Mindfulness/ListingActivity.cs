using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override string GetDescription()
    {
        return description;
    }

    public override void PerformActivity()
    {
        Console.WriteLine(GetDescription());

        string prompt = listingPrompts[new Random().Next(0, listingPrompts.Count)];
        Console.WriteLine(prompt);

        Console.WriteLine("You may begin listing...");
        Thread.Sleep(5000);

        List<string> itemsListed = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            itemsListed.Add(item);
        }

        Console.WriteLine($"\nYou listed {itemsListed.Count} items.");
    }
}






// public class ListingActivity : Activity
// {
//     private string activityName = "Listing";
//     private List<string> prompts = new List<string>
//     {
//         "Who are people that you appreciate?",
//         "What are personal strengths of yours?",
//         "Who are people that you have helped this week?",
//         "When have you felt the Holy Ghost this month?",
//         "Who are some of your personal heroes?"
//     };

//     public override string GetDescription()
//     {
//         return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
//     }

//     public override void PerformActivity()
//     {
//         Random random = new Random();
//         string prompt = prompts[random.Next(prompts.Count)];
//         Console.WriteLine(prompt);
//         Console.WriteLine();

//         Console.WriteLine("Get ready to list...");
//         Thread.Sleep(3000);

//         Console.WriteLine("Begin listing items:");

//         List<string> items = new List<string>();
//         DateTime endTime = DateTime.Now.AddSeconds(_duration);

//         while (DateTime.Now < endTime)
//         {
//             string item = Console.ReadLine();
//             if (!string.IsNullOrWhiteSpace(item))
//             {
//                 items.Add(item);
//             }
//         }

//         Console.WriteLine($"\nNumber of items listed: {items.Count}\n");

//         //  EndingMessage(totalDuration, activityName);
//     }

    
// }