public class Journal
{
    List<Entry> _entries = new List<Entry>();
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

}

