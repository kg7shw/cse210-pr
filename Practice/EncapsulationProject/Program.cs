using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture object
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (!scripture.AllWordsHidden)
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
        }
    }
}

class Scripture
{
    private string reference;
    private List<Word> words;
    private Random random;

    public bool AllWordsHidden
    {
        get { return words.TrueForAll(word => word.IsHidden); }
    }

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        random = new Random();

        // Split the scripture text into individual words
        string[] wordArray = text.Split(' ');

        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine(reference);

        foreach (Word word in words)
        {
            if (word.IsHidden)
                Console.Write("_ ");
            else
                Console.Write(word.Text + " ");
        }

        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        List<Word> visibleWords = words.FindAll(word => !word.IsHidden);

        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
        }
    }
}

class Word
{
    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }
}
