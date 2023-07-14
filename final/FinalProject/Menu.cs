public class Menu
{
    public MealManager mealDriver { get; set; } = new MealManager();
    public FileHandler fileHandler { get; set; } = new FileHandler();

    public Meal meal { get; set; } = new Meal();


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
            Console.WriteLine("5. Display Recipes");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine() ?? String.Empty;

            switch (choice)
            {
                case "1":
                    Recipe recipe = new Recipe();
                    recipe.GetInfo();
                    mealDriver.recipeBook.AddRecipe(recipe);
                    break;

                case "2":
                    mealDriver.MakeMeal();
                    meal.DisplayMeal();
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
                    Console.WriteLine("Recipes:");
                    // mealDriver.recipeBook.DisplayRecipes();
                    break;

                case "5":
                    Console.WriteLine("1. List of Recipe names.");
                    Console.WriteLine("2. List of Full Recipe.");
                    Console.WriteLine("3. Return to the menu");
                    string response = Console.ReadLine() ?? String.Empty;
                    if (response.ToLower() == "1")
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        mealDriver.recipeBook.DisplayRecipes();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    }else if (response.ToLower() == "2")
                    {   
                        
                        mealDriver.DisplayRecipes();
                        
                    } else
                    {
                    
                    }
                    break;

                case "6":
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







