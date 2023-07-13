public class IngredientsInfo
{
    public string _ingredient { get; set; }
    public string _quantity { get; set; }
    public string _extraInfo { get; set; }
    // private int _prepTime;
    // private int _cookTime;
    // private int _totalTime;

    public IngredientsInfo()
    {

    }

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