public interface IGoal
{
    string GetName();
    bool IsCompleted();
    int GetValue();
    int GetPoints();
    void MarkComplete();
}
