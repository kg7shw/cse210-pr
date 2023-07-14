using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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
