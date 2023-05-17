public class Entry
{
    private string _entry = "";
    private string _title = "";
    private DateTime _date = DateTime.Now;
    private string _NewPrompt = "";
    private Prompt _prompt;
    private string _author = "";


    public Entry(string prompt, string author, string title, string entry)
    {
        _NewPrompt = prompt;
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

    public string GetTitle()
    {
        return $"Title: {_title}";
    }

    public string GetAuthor()
    {
        return $"Author: {_author}";
    }

    public string GetDate()
    {
        return $"Title: {_date}";
    }

}