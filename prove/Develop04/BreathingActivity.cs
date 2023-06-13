public class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public override string GetDescription()
    {
        return _description;
    }

    public override string GetName()
    {
        return _name;
    }
    
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

    // public void RunBreathingActivity(int duration)
    // {
    //     BreathIn(duration);
    //     BreathOut(duration);
    // }

    public override void PerformActivity()
    {
        int duration =  GetDuration();

        BreathIn(duration);
        BreathOut(duration);
    }



    // public override void PerformActivity()
    // {
    //     Console.WriteLine(GetDescription());

    //     Console.WriteLine("Inhale...");
    //     DisplaySpinnerAnimation(5);

    //     Console.WriteLine("Exhale...");
    //     DisplaySpinnerAnimation(5);
    // }

}