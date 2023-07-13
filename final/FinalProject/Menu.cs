public class Menu
{
    public MealManager mealDriver { get; set; } = new MealManager();

    public Menu()
    {

    }

    public void DisplayMenu()
    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("======Menu Options======");
            Console.WriteLine("1. Add a recipe");
            Console.WriteLine("2. Make a meal");
            Console.WriteLine("3. Save recipes");
            Console.WriteLine("4. Load recipes");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Recipe recipe = new Recipe();
                    recipe.GetInfo();
                    mealDriver.recipeBook.AddRecipe(recipe);
                    break;

                case "2":
                    mealDriver.MakeMeal();
                    mealDriver.DisplayMeal();
                    break;

                case "3":
                    Console.Write("Enter the file name where you would like to save the recipes: ");
                    string saveFileName = Console.ReadLine();
                    FileHandler.SaveRecipes(mealDriver.recipeBook.GetRecipeList(), saveFileName);
                    Console.WriteLine("Recipes were saved successfully.");
                    break;

                case "4":
                    Console.Write("Enter the file name where you would like to load recipes from: ");
                    string loadFileName = Console.ReadLine();
                    mealDriver.recipes = FileHandler.LoadRecipes(loadFileName);
                    mealDriver.recipeBook.SetRecipes(mealDriver.recipes);
                    Console.WriteLine("Recipes were loaded successfully.");
                    break;

                case "5":
                    quit = true;
                    Console.WriteLine("Have a nice day!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    
    

}







