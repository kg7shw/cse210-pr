public class Entry
{
    private string _entry = "";
    private string _title = "";
    private DateTime _date = DateTime.Now;
    private Prompt _prompt;
    private string _author = "";


    public Entry(string new_prompt, string author, string title, string entry)
    {
        _prompt = new_prompt;
        _author = author;
        _title = title;
        _entry = entry;

    }



    
    // public bool HasDate()
    // {
    //     if (_date.Contains(DateTime date))
    //     {
    //         return true;
    //     }
    //     return false;

    // }

    
    public bool HasTitle(string name)
    {
        if (_author.ToUpper().Contains(name.ToUpper()))
        {
            return true;
        }
        return false;

    }


    public string GetEntry()
    {
        return $"Prompt: {_prompt}\n{_entry}";
    }
}