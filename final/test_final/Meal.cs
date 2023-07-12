using System;
using System.Collections.Generic;

public class Meal
{
    private List<Recipe> mealItems;

    public void MakeMeal()
    {
        mealItems = new List<Recipe>();
        bool done = false;
        while (!done)
        {
            Console.WriteLine("Add a meal item (Enter 'done' to finish):");
            string input = Console.ReadLine();
            if (input == "done")
            {
                done = true;
            }
            else
            {
                Recipe recipe = Program.recipes.Find(r => r.Name == input);
                if (recipe != null)
                {
                    mealItems.Add(recipe);
                    Console.WriteLine("Meal item added!");
                }
                else
                {
                    Console.WriteLine("Recipe not found!");
                }
            }
        }

        Console.WriteLine("Meal created:");
        foreach (Recipe recipe in mealItems)
        {
            recipe.DisplayRecipe();
        }
    }
}
