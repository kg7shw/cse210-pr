public class Menu
{

    private RecipeBook _recipeBook;
    private FileHandler fileHandler;
    private Recipe[] recipes;



    private Meal meal;
    private Recipe recipe;
    private Program program;
    private RecipeBook recipeBook;
    


    public Menu()
    {
        recipeBook = new RecipeBook();

    }

    public void DisplayMenu()
    {

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("======Menu Options======");
            Console.WriteLine("1. Add a recipe");
            Console.WriteLine("2. Make a meal");
            Console.WriteLine("3. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    recipe = new Recipe();
                    recipeBook.AddRecipe(recipe);
                    break;


                    
                case "2":
                    meal = new Meal();
                    MakeMeal();
                    // Console.Write("What meal would you like? ");
                    // meal.DisplayMealItems();
                    // int mealNumber = int.Parse(Console.ReadLine());
                    // recipe = meal.GetMeal(mealNumber);
                    // recipe.DisplayRecipe();
                    // recipe.DisplayIngredientsInfoItems();
                    // recipe.DisplayInstructions();
                    recipe.DisplayRecipeName();
                    // recipe.DisplayRecipe();
                    break;

                case "3":
                    quit = true;
                    Console.WriteLine("Have a nice day!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    Console.WriteLine();
                    break;
            }
        }
    }
public void MakeMeal()
{   
    bool done = false;
    while (!done)
    {
        
        Console.Write("Would you like to add a meal item?(y/n) ");
        string response = Console.ReadLine() ?? String.Empty;
        response = response.ToLower();
        if (response == "y")
        {
            _recipeBook.DisplayRecipes();
            List<Recipe> _recipes = _recipeBook.GetRecipeList();
            Console.Write("What meal item would you like to add to this meal? ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0 && num < _recipes.Count) {
                Recipe mealitem = _recipes[num - 1]; // Set mealItem equal to the receipe asscoicated with the index num -1 in the list of receipes
                _recipes.Add(mealitem);
            } else
            {
                Console.WriteLine("Invalid entry. Please try again.");
            }
            
        } else if (response == "n")
        {
            done = true;
        } else
        {
            Console.WriteLine("Invalid entry try again");
        }
        
    }

}

}

































// public class Menu
// {

//     public void DisplayMenu()
//     {

//         bool quit = false;
//         while (!quit)
//         {
//             Console.WriteLine("======Menu Options======");
//             Console.WriteLine("1. Add meal option");
//             Console.WriteLine("2. Make a meal");
//             Console.WriteLine("3. Quit");
//             Console.Write("Select a choice from the menu: ");

//             string choice = Console.ReadLine();

//             switch (choice)
//             {
//                 case "1":
//                     Console.WriteLine("choose category");
//                     Console.WriteLine("1. Breakfast");
//                     Console.WriteLine("2. Lunch");
//                     Console.WriteLine("3. Dinner");
//                     string category = Console.ReadLine();
//                     Console.Write("Enter the name of the meal: ");
//                     string name = Console.ReadLine();
//                     Console.Write("How many steps will there be? ");
//                     string steps = int.Parse(Console.ReadLine());
//                     AddSteps(steps);
//                     Console.Write($"Where do you want to save {name}: ");
//                     string filename = Console.ReadLine();
//                     Save(filename);
//                     break;

                    
//                 case "2":
//                     Console.WriteLine("choose category");
//                     Console.WriteLine("1. Breakfast");
//                     Console.WriteLine("2. Lunch");
//                     Console.WriteLine("3. Dinner");
//                     string category = Console.ReadLine();

//                     // load(category);
//                     DisplayMealOptions(category);
//                     Console.Write("Enter the name of the meal: ");
//                     string name = Console.ReadLine();
//                     // SelectByName(name); // search for the meal and run the steps for
//                     DisplayMeal(name);
//                     break;

//                 case "3":
//                     quit = true;
//                     Console.Write("Enter the file path where you would like to save the the program: ");
//                     savePath = Console.ReadLine();
//                     tracker.Save(savePath);
//                     Console.WriteLine("Have a nice day!");
//                     break;

//                 default:
//                     Console.WriteLine("Invalid choice.");
//                     Console.WriteLine();
//                     break;
//             }
//         }
//     }
// }