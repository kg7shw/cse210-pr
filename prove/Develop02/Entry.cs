public class Entry
{

    
    private string _entry = "";
    private string _title = "";
    private string _date = "";
    private string _prompt;
    private string _author = "";


    public Entry(string prompt, string author, string title, string entry)
    {
        _prompt = prompt;
        _author = author;
        _title = title;
        _entry = entry;

        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

    }

    public Entry(string prompt, string author, string title, string entry, string date)
    {
        _prompt = prompt;
        _author = author;
        _title = title;
        _entry = entry;
        _date = date;
    }

    private void FormattedPrint(string item)
    {
        
        Console.WriteLine($"{item}");
        
    } 


    public void Display()
    {
        Console.WriteLine(_prompt);
        Console.WriteLine(_author);
        Console.WriteLine(_title);
        Console.WriteLine(_entry);
        Console.WriteLine(_date);
    }
    


    
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
        return $"{_prompt}\n{_entry}";
    }

    public string GetTitle()
    {
        return $"{_title}";
    }

    public string GetAuthor()
    {
        return $"{_author}";
    }

    public string GetDate()
    {
        return $"{_date}";
    }
    public string GetPrompt()
    {
        return $"{_prompt}";
    }

    



}