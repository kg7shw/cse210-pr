public class Activity
{
    protected int _duration;
    protected string _description;
    protected string _name;
    List<string> animationStrings = new List<string>();
    List<int> times = new List<int>();


    // public Activity(string description, string name)
    // {
    //     _description = description;
    //     _name = name;

    // }

    public virtual string GetDescription()
    {
        return _description;
    }
    public virtual void PerformActivity()
    {

    }

    public virtual string GetName()
    {
        return _name;
    }



    public void StartingMessage(string description, string name)
    {
        Console.WriteLine($"Welcome to the {name}\n");
        Console.WriteLine($"{description}\n");
        
        Thread.Sleep(3000);

    }

    public int GetDuration()
    {
        Console.Write("How long, in seconds would you like your session? ");
        int duration = int.Parse(Console.ReadLine());
        return duration;
    }

    public void EndingMessage(int duration, string name)
    {
        Console.WriteLine($"Well Done!!!");
        Console.WriteLine($"You have completed another {duration} seconds of the {name}\n");
        Thread.Sleep(3000);

    }

    public void DisplayDiscription(string description)
    {
        Console.WriteLine($"{description}");
    }

    public void DisplaySpinnerAnimation(int duration)
    {   
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            // foreach (string str in animationStrings)
            // {
                
            //     Console.Write(str);
            //     Thread.Sleep(500);
            //     Console.Write("\b \b");
        
            // }


            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);

            int i = 0;

            while (DateTime.Now < endTime)
            {
                string str = animationStrings[i];
                Console.Write(str);
                Thread.Sleep(100);
                Console.Write("\b \b");

                i++;

                if (i >= animationStrings.Count)
                {
                    i = 0;
                }
            }

    }

    public void CountDownTimer(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b\b");
        }

    }









}