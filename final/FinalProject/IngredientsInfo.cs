public class IngredientsInfo
{
    public string Ingredient { get; set; }
    public string Quantity { get; set; }
    public string ExtraInfo { get; set; }
    // private int _prepTime;
    // private int _cookTime;
    // private int _totalTime;

    public IngredientsInfo()
    {

    }

    public IngredientsInfo(string ingredient, string quantity, string extraInfo)
    {
        Ingredient = ingredient;
        Quantity = quantity;
        ExtraInfo = extraInfo;
    }

    // public int SetTotalTime(int prepTime, int cookTime)
    // {
    //     return _totalTime;
    // }

    public void DisplayIngredientsInfo()
    {
        Console.WriteLine($"{Quantity} {Ingredient} - {ExtraInfo}");
    }
}