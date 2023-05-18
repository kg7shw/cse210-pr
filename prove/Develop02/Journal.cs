using System.IO;

public class Journal
{
    List<Entry> _entries = new List<Entry>();
    public Prompt _prompt = new Prompt();
    public string fileName = "";
    private string new_prompt = "";


 private void FormattedPrint(string item)
 {
    
    Console.WriteLine($"{item}");
    
 }   


public void AddEntry(Entry entry)
{
    _entries.Add(entry);
}


public void DisplayJournal()
{
    foreach (Entry entry in _entries)
    {
        entry.Display();
    }
}


    public void SaveJournalToFile()
    {
        

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                string entryLine = $"{entry.GetPrompt()}|{entry.GetAuthor()}|{entry.GetTitle()}|{entry.GetEntry()}|{entry.GetDate()}";
                writer.WriteLine(entryLine);
            }
        }

        Console.WriteLine("Journal saved to file successfully.");
    }

    public void LoadJournalFromFile(string fileName)
    {
        
        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] entryData = line.Split('|');

                    if (entryData.Length == 5)
                    {
                        string prompt = entryData[0];
                        string author = entryData[1];
                        string title = entryData[2];
                        string entryText = entryData[3];
                        string dateString = entryData[4];

                        Entry entry = new Entry(prompt, author, title, entryText, dateString);
                        _entries.Add(entry);
                        
                        
                    }
                }
            }

            Console.WriteLine("Journal loaded from file successfully.");
        }
        else
        {
            Console.WriteLine("File not found. Creating a new file.");
            CreateNewFile(fileName);
            LoadJournalFromFile(fileName);
        }
    }

    public void CreateNewFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            Console.WriteLine("New file created: " + fileName);
        }
    }



}



