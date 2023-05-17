public class Prompt
{

    List<string> _usedPrompts = new List<string>();
    List<string> _prompts = new List<string>();

    public Prompt()
    {
        _prompts.Add("How was your day?");
        _prompts.Add("What did you do today?");
        _prompts.Add("How has Evelyn grown today?");
        _prompts.Add("What was your favorite part of today? Why?");
        _prompts.Add("How have you seen the hand of the lord today?");
        _prompts.Add("What was the weather like today?");
        _prompts.Add("Where are you happiest? Describe that place.");
        _prompts.Add("What's something you're good at? What makes you good at it?");
        _prompts.Add("What's your favorite: season, color, place, or food? Describe it.");
        _prompts.Add("When you're feeling down, what makes you feel better?");
        _prompts.Add("What's your ideal morning routine?");
        _prompts.Add("How are you feeling today?");
        _prompts.Add("If you could only accomplish one thing today, what would it be?");
        _prompts.Add("What are your favorite songs? Why?");
        _prompts.Add("What's your favorite movie? Why?");
        _prompts.Add("What's your favorite book? Why?");
        _prompts.Add("What is your favorite memory of your spouse?");
        _prompts.Add("What was your wedding day like?");
        _prompts.Add("What was it like when your first child was born?");
    }


    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }


        public string GetPrompt()
    {
        return $"{_prompts}";
    }


}