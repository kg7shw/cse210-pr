using System;

public class IngredientsInfo
{
public string Ingredient { get; set; } = string.Empty;
public string Quantity { get; set; } = string.Empty;
public string ExtraInfo { get; set; } = string.Empty;


    public void DisplayIngredientsInfo()
    {
        Console.WriteLine($"{Quantity} {Ingredient} - {ExtraInfo}");
    }
}
