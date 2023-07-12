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
