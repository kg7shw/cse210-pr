public class Meal
{
    public string _name { get; set; }

    public List<Recipe> _recipes { get; set; } = new List<Recipe>();

    public Meal()
    {
        

    }

    public Meal(string name)
    {
        _name = name;
    }


    public string SetMealName()
    {
        Console.Write("What is the name of this meal? ");
        _name = Console.ReadLine() ?? String.Empty;
        return _name;
    }

    public string GetName()
    {
        return _name;
    }

    // public void DisplayMealItems()
    // {

    //     int i = 1;
    //     foreach (Recipe option in _recipes)
    //     {
    //         Console.Write($"{i++}. ");
    //         option.DisplayRecipeName();


    //     }
    // }



    public Recipe GetMeal(int mealNumber)
    {
        return _recipes[mealNumber - 1];

    }
    
    // public void AddRecipe(Recipe r)
    // {
    //     _recipes.Add(r);
    // }

    public void DisplayMeal()
    {
        Console.WriteLine("---------------------------------");
        foreach (Recipe recipe in _recipes)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            recipe.DisplayRecipe();
            Console.WriteLine("+++++++++++++++++++++++++++++++");
        }
        Console.WriteLine("---------------------------------");
    }
        



}