public class Meal
{
    private string _name;

    List<Recipe> _recipes = new List<Recipe>();

    public Meal()
    {
        SetMealName();

    }


    public void SetMealName()
    {
        Console.Write("What is the name of this meal? ");
        _name = Console.ReadLine() ?? String.Empty;
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

    }
        



}