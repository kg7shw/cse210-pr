public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";




    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    {
        _studentName = studentName;
        _topic = topic;
        _textbookSection = textbookSection;
        _problems = problems;
    }


    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic} \nSection {_textbookSection} Problems {_problems}";
    }
}