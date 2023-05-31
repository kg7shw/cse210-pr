public class Loanable
{
    protected bool _isCheckedIn = true;
    


    public void checkOut()
    {
        _isCheckedIn = false;
    }

    public void CheckedIn()
    {
        _isCheckedIn = true;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Available: {_isCheckedIn}");
    }


}