public class Entry
{
    private string _entry = "";
    private string _title = "";
    private DateTime _date = DateTime.Now;
    private Prompt _prompt;
    private string _author = "";


    public Entry(string entry, Prompt prompt, DateTime date, string title, string author)
    {
        _entry = entry;
        _prompt = prompt;
        _date = date;
       _title = title;
        _author = author;
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