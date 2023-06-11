public class BreathingActivity : Activity
{
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";


    
    public void BreathIn(int duration)
    {
        Console.Write("Breath in...");
        CountDownTimer(duration);

    }
    public void BreathOut(int duration)
    {
        Console.Write("Breath out...");
        CountDownTimer(duration);
    }

    public void RunBreathingActivity(int duration)
    {
        BreathIn(duration);
        BreathOut(duration);
    }

}