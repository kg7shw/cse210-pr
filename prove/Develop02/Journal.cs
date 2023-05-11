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



}



