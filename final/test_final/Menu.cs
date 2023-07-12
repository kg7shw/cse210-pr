using System;
using System.Collections.Generic;


public class Menu
{
    private Meal? meal;

    public void DisplayMenu()
    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("======Menu Options======");
            Console.WriteLine("1. Add a recipe");
            Console.WriteLine("2. Make a meal");
            Console.WriteLine("3. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Recipe? recipe = CreateRecipe();
                    Program.AddRecipe(recipe);
                    break;
                case "2":
                    meal = new Meal();
                    meal.MakeMeal();
                    break;
                case "3":
                    quit = true;
                    Console.WriteLine("Have a nice day!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    Console.WriteLine();
                    break;
            }
        }
    }

    public Recipe CreateRecipe()
    {
        Recipe recipe = new Recipe();

        Console.Write("Enter the recipe name: ");
        recipe.Name = Console.ReadLine();

        Console.Write("Enter the serving size: ");
        recipe.ServingSize = Console.ReadLine();

        recipe.Ingredients = new List<Ingredient>();
        Console.WriteLine("Enter the ingredients (Enter 'done' to finish):");
        while (true)
        {
            Ingredient ingredient = new Ingredient();

            Console.Write("Ingredient: ");
            string ingredientName = Console.ReadLine();
            if (ingredientName == "done")
            {
                break;
            }
            ingredient.Name = ingredientName;

            Console.Write("Quantity: ");
            ingredient.Quantity = Console.ReadLine();

            Console.Write("Extra Info: ");
            ingredient.ExtraInfo = Console.ReadLine();

            recipe.Ingredients.Add(ingredient);
        }

        recipe.Instructions = new List<string>();
        Console.WriteLine("Enter the instructions (Enter 'done' to finish):");
        while (true)
        {
            Console.Write("- ");
            string instruction = Console.ReadLine();
            if (instruction == "done")
            {
                break;
            }
            recipe.Instructions.Add(instruction);
        }

        return recipe;
    }
}
