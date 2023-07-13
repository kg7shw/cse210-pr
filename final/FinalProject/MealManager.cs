public class MealManager
{
    public RecipeBook recipeBook { get; set; }
    public List<Recipe> recipes { get; set; }
    public Meal meal { get; set; }

    public MealManager()
    {
        recipeBook = new RecipeBook();
        recipes = new List<Recipe>();
    }
}