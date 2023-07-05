public class IngredientsInfo
{
    private string _ingredient;
    private string _quantity;
    private string _extraInfo;
    // private int _prepTime;
    // private int _cookTime;
    // private int _totalTime;

    

    public IngredientsInfo(string ingredient, string quantity, string extraInfo)
    {
        _ingredient = ingredient;
        _quantity = quantity;
        _extraInfo = extraInfo;
    }

    // public int SetTotalTime(int prepTime, int cookTime)
    // {
    //     return _totalTime;
    // }

    public void DisplayIngredientsInfo()
    {
        Console.WriteLine($"{_quantity} {_ingredient} - {_extraInfo}");
    }
}