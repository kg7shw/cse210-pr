public class RecipeBook
{
    List<Recipe> _recipes { get; set; } = new List<Recipe>();
    public void AddRecipe(Recipe r)
    {
        _recipes.Add(r);
    }

    public List<Recipe> GetRecipeList()
    {
        return _recipes;
    }


    public void SetRecipes(List<Recipe> newRecipes)
    {
        _recipes = newRecipes;
    }

    public void DisplayRecipes()
    {

        int i = 1;
        foreach (Recipe option in _recipes)
        {
            Console.Write($"{i++}. ");
            option.DisplayRecipeName();


        }
    }

}