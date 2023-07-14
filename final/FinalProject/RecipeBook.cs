public class RecipeBook
{
    public List<Recipe> RecipesList { get; set; } = new List<Recipe>();
    public void AddRecipe(Recipe r)
    {
        RecipesList.Add(r);
    }

    public List<Recipe> GetRecipeList()
    {
        return RecipesList;
    }


    public void SetRecipes(List<Recipe> newRecipes)
    {
        RecipesList = newRecipes;
    }

    public void DisplayRecipes()
    {

        int i = 1;
        foreach (Recipe option in RecipesList)
        {
            Console.Write($"{i++}. ");
            option.DisplayRecipeName();


        }
    }

}