using System;
using System.Collections.Generic;

public class Recipe
{
    public string Name { get; set; }
    public string ServingSize { get; set; }
    public List<IngredientsInfo> Ingredients { get; set; }
    public List<string> Instructions { get; set; }

    public void DisplayIngredientsInfoItems()
    {
        foreach (IngredientsInfo option in Ingredients)
        {
            option.DisplayIngredientsInfo();
        }
    }

    public void DisplayInstructions()
    {
        foreach (string instruction in Instructions)
        {
            Console.WriteLine("- " + instruction);
        }
    }

    public void DisplayRecipe()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Serving Size: " + ServingSize);
        Console.WriteLine("Ingredients:");
        DisplayIngredientsInfoItems();
        Console.WriteLine("Instructions:");
        DisplayInstructions();
        Console.WriteLine();
    }
}
