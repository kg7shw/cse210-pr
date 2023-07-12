using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    private static readonly string RecipesFilePath = "recipes.json";
    private static List<Recipe> recipes = new List<Recipe>();

    static void Main(string[] args)
    {
        LoadRecipes();

        Menu menu = new Menu();
        menu.DisplayMenu();
    }

    public static void LoadRecipes()
    {
        if (File.Exists(RecipesFilePath))
        {
            string jsonString = File.ReadAllText(RecipesFilePath);
            recipes = JsonSerializer.Deserialize<List<Recipe>>(jsonString);
        }
    }

    public static void SaveRecipes()
    {
        string jsonString = JsonSerializer.Serialize(recipes);
        File.WriteAllText(RecipesFilePath, jsonString);
    }

    public static void AddRecipe(Recipe recipe)
    {
        recipes.Add(recipe);
        SaveRecipes();
        Console.WriteLine("Recipe added successfully!");
    }
}


public class FileHandler
{
    public static void SaveRecipes(List<Recipe> recipes, string fileName)
    {
        string jsonString = JsonSerializer.Serialize(recipes);
        File.WriteAllText(fileName, jsonString);
    }

    public static List<Recipe> LoadRecipes(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        return JsonSerializer.Deserialize<List<Recipe>>(jsonString);
    }
}

public class Menu
{
    private Meal meal;

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
                    Recipe recipe = CreateRecipe();
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

public class IngredientsInfo
{
    public string Ingredient { get; set; }
    public string Quantity { get; set; }
    public string ExtraInfo { get; set; }

    public void DisplayIngredientsInfo()
    {
        Console.WriteLine($"{Quantity} {Ingredient} - {ExtraInfo}");
    }
}

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
