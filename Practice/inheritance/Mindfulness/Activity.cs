using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected int duration;
    protected string description;
    protected string name;
    protected List<string> animationStrings = new List<string> { "\\", "|", "/", "-" };

    public abstract string GetDescription();
    public abstract void PerformActivity();

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to {name}\n");
        Console.WriteLine(description);
        Console.Write("\nHow long, in seconds, would you like your session? ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready to begin...\n");
        Thread.Sleep(3000);
    }

    public void EndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed {duration} seconds of {name}\n");
        Thread.Sleep(3000);
    }

    protected void DisplaySpinnerAnimation(int duration)
    {
        int animationIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string spinner = animationStrings[animationIndex];
            Console.Write(spinner);
            Thread.Sleep(100);
            Console.Write("\b \b");
            animationIndex = (animationIndex + 1) % animationStrings.Count;
        }
    }

    protected void CountDownTimer(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b \b\b");
        }
    }
}
