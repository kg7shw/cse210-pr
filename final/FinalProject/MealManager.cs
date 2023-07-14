public class MealManager
{
    public RecipeBook recipeBook { get; set; } = new RecipeBook();
    public List<Recipe> recipes { get; set; } = new List<Recipe>();
    public Meal meal { get; set; } = new Meal();

    public MealManager()
    {
        recipeBook = new RecipeBook();
        recipes = new List<Recipe>();
    }

    public void MakeMeal()
    {
        string mealName = meal.SetMealName();
        bool done = false;
        while (!done)
        {
            Console.Write("Would you like to add a meal item? (y/n) ");
            string response = Console.ReadLine()?.ToLower();
            if (response == "y")
            {
                recipeBook.DisplayRecipes();
                Console.Write("Enter the number of the recipe to add: ");
                int num = int.Parse(Console.ReadLine());
                if (num > 0 && num <= recipeBook.GetRecipeList().Count)
                {
                    Recipe mealItem = recipeBook.GetRecipeList()[num - 1];
                    recipes.Add(mealItem);
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            }
            else if (response == "n")
            {
                done = true;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please try again.");
            }
        }
    }

    public void DisplayRecipes()
    {
        Console.WriteLine("---------------------------------");
        foreach (Recipe recipe in recipes)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            recipe.DisplayRecipe();
            Console.WriteLine("+++++++++++++++++++++++++++++++");
        }
        Console.WriteLine("---------------------------------");
    }
}
