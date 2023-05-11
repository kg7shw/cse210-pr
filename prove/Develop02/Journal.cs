public class Journal
{
    List<Entry> _entries = new List<Entry>();
    List<Prompt> _prompts = new List<Prompt>();
 private void FormattedPrint(string item)
 {
    Console.WriteLine("-----------------------------");
    Console.WriteLine($"{item}");
    Console.WriteLine("-----------------------------");
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


public void GetRandomPrompt()
{
   var random = new Random();
   var randomNumber = random.Next(0, _prompts.Count);
   FormattedPrint(_prompts[randomNumber].GetPrompt());

}



    public void SaveJournalToFile()
    {
        Console.WriteLine("Enter the filename to save the journal (without extension):");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName + ".csv"))
        {
            foreach (Entry entry in _entries)
            {
                // string entryLine = $"{entry.GetEntry()},{entry.GetTitle()},{entry.GetAuthor()},{entry.GetDate()}";
                // writer.WriteLine(entryLine);
            }
        }

        Console.WriteLine("Journal saved to file successfully.");
    }

    public void LoadJournalFromFile()
    {
        Console.WriteLine("Enter the filename to load the journal from (including extension):");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            _entries.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] entryData = line.Split(',');

                    if (entryData.Length == 4)
                    {
                        string entryText = entryData[0];
                        string title = entryData[1];
                        string author = entryData[2];
                        string dateString = entryData[3];
                        DateTime date;

                        if (DateTime.TryParse(dateString, out date))
                        {
                            Entry entry = new Entry(entryText, title, author);
                            _entries.Add(entry);
                        }
                    }
                }
            }

            Console.WriteLine("Journal loaded from file successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }



}



