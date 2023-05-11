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
        _prompts.Add("");
        _prompts.Add("");
        _prompts.Add("");
        _prompts.Add("");
    }



    public string GetRandomPrompt()
    {
        return "This is  prompt";
    }

}