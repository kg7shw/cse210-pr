public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        name = "Breathing Activity";
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override string GetDescription()
    {
        return description;
    }

    public override void PerformActivity()
    {
        Console.WriteLine(GetDescription());

        Console.WriteLine("Inhale...");
        DisplaySpinnerAnimation(5);

        Console.WriteLine("Exhale...");
        DisplaySpinnerAnimation(5);
    }
}


















// public class BreathingActivity : Activity
// {

//     private string activityName = "Breathing";
//     public override string GetDescription()
//     {
//         return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
//     }

//     public override void PerformActivity()
//     {
//         Console.WriteLine(GetDescription());

//         Console.Write("Enter the duration of each breathing session in seconds: ");
//         int sessionDuration = int.Parse(Console.ReadLine());

//         Console.Write("Enter the total duration of the breathing activity in seconds: ");
//         int totalDuration = int.Parse(Console.ReadLine());

//         int numSessions = totalDuration / sessionDuration; // Number of breathing sessions
//         int breatheInDuration = sessionDuration / 2; // Duration for breathing in
//         int breatheOutDuration = sessionDuration / 2; // Duration for breathing out

//         Console.WriteLine("Get ready to begin...");
//         Thread.Sleep(3000);

//         // for (int i = 0; i < numSessions; i++)
//         // {
//         //     Console.WriteLine("Breathe in...");
//         //     CountDownTimer(breatheInDuration);
//         //     Console.WriteLine("Breathe out...");
//         //     CountDownTimer(breatheOutDuration);
//         // }

//         while (duration > 0)
//         {
//             Console.WriteLine("Inhale...");
//             CountDownTimer(sessionDuration / 2);

//             Console.WriteLine("\nExhale...");
//             CountDownTimer(sessionDuration / 2);

//             duration -= sessionDuration;
//             Console.WriteLine();
//         }

//         //  EndingMessage(totalDuration, activityName);
//     }
// }


