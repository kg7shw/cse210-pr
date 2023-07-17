public class Scripture
{
    private string _reference;
    private string _text;
    
    private List<Word> _words;
    private Random _random;

    public bool AllWordsHidden()
    {
        return _words.TrueForAll(word => word._IsHidden);
    }

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = new List<Word>();
        _random = new Random();


    }


    public void GetWordArray()
    {
        // Split the scripture text into individual words
        string[] wordArray = _text.Split(' ');

        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }
    

    public void Display()
    {
        Console.WriteLine(_reference);

        foreach (Word word in _words)
        {
            if (word._IsHidden)
                Console.Write("_ ");
            else
                Console.Write(word.GetText() + " ");
        }

        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        List<Word> visibleWords = _words.FindAll(word => !word._IsHidden);

        if (visibleWords.Count > 0)
        {
            int randomIndex = _random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
        }
    }
}


