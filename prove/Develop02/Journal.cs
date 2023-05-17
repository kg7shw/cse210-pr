using System.IO;

public class Journal
{
    List<Entry> _entries = new List<Entry>();
    List<Prompt> _prompts = new List<Prompt>();
    private string fileName = "";
    private string new_prompt = "";


 private void FormattedPrint(string item)
 {
    
    Console.WriteLine($"{item}");
    
 }   


public void AddEntry(Entry entry)
{
    _entries.Add(entry);
}


public void ShowEntry()
{
    foreach (Entry entry in _entries)
    {
        FormattedPrint(entry.GetEntry());
    }
}
public void ShowPrompt()
{
    foreach (Prompt prompt in _prompts)
    {
        FormattedPrint(prompt.GetPrompt());
    }
}


public string GetRandomPrompt()
{
   var random = new Random();
   var randomNumber = random.Next(0, _prompts.Count);
   string new_prompt = "";
   FormattedPrint(_prompts[randomNumber].GetPrompt());
   return new_prompt;

}



    public void SaveJournalToFile()
    {
        

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                // string entryLine = $"{entry.GetEntry()},{entry.GetTitle()},{entry.GetAuthor()},{entry.GetDate()}";
                // writer.WriteLine(entryLine);
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

                    if (entryData.Length == 4)
                    {
                        string entryText = entryData[0];
                        string title = entryData[1];
                        string author = entryData[2];
                        string dateString = entryData[3];
                        DateTime date;

                        if (DateTime.TryParse(dateString, out date))
                        {
                            Entry entry = new Entry(new_prompt, author, title, entryText);
                            _entries.Add(entry);
                        }
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



