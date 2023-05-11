public class Journal
{
    List<Entry> _entries = new List<Entry>();
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