public class Scripture
{
    private string _reference;
    private string _text;
    
    private List<Word> _words;
    private List<Word> _hiddenWords;

    private Random _random;

    // public bool AllWordsHidden()
    // {
    //     foreach (Word word in _words)
    //     {
    //         if (word.GetIsHidden() == true)
    //         {
    //             continue;
    //         } else
    //         {
    //             return true;
    //         }

    //     }

    //     return false;
    // }


    public Scripture(string text)
    {
        
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
                Console.Write("______ ");
            else
                Console.Write(word.GetText() + " ");
        }

        Console.WriteLine();
    }

    public void HideRandomWord()
    {

        // for (int i = 0; i <= 4; i++)
        // {
            var random = new Random();
            var randomNumber = random.Next(0, _words.Count);
            Word new_word = _words[randomNumber];
            _hiddenWords.Add(new_word);
            new_word.HideWord();
                
        // }


    }

    public string CheckIsHidden()
    {
        foreach (Word word in _hiddenWords)
        {
            if (_words.Contains(word))
            {
                continue;
            } else
            {
                return "";
            }
            
        }
        return "quit";

    }


}


