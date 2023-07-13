public class Menu
{
    public MealManager mealDriver { get; set; }

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
                    MakeMeal();
                    DisplayMeal();
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

    public void BuildMealFromJson()
    {

    }

    public void MakeMeal()
    {
        string mealName = mealDriver.meal.SetMealName();
        bool done = false;
        while (!done)
        {
            Console.Write("Would you like to add a meal item? (y/n) ");
            string response = Console.ReadLine()?.ToLower();
            if (response == "y")
            {
                mealDriver.recipeBook.DisplayRecipes();
                Console.Write("Enter the number of the recipe to add: ");
                int num = int.Parse(Console.ReadLine());
                if (num > 0 && num <= mealDriver.recipeBook.GetRecipeList().Count)
                {
                    Recipe mealItem = mealDriver.recipeBook.GetRecipeList()[num - 1];
                    mealDriver.recipes.Add(mealItem);
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

    public void DisplayMeal()
    {
        Console.WriteLine("---------------------------------");
        foreach (Recipe recipe in mealDriver.recipes)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            recipe.DisplayRecipe();
            Console.WriteLine("+++++++++++++++++++++++++++++++");
        }
        Console.WriteLine("---------------------------------");
    }
}











// public class Menu
// {

//     private mealDriver.RecipeBook _recipeBook;
//     private FileHandler fileHandler;
//     private Recipe[] recipes;



//     private Meal meal;
//     private Recipe recipe;
//     private Program program;
//     private RecipeBook recipeBook;
//     List<Recipe> _recipes;
    


//     public Menu()
//     {
//         recipeBook = new RecipeBook();

//     }

//     public void DisplayMenu()
//     {

//         bool quit = false;
//         while (!quit)
//         {
//             Console.WriteLine("======Menu Options======");
//             Console.WriteLine("1. Add a recipe");
//             Console.WriteLine("2. Make a meal");
//             Console.WriteLine("3. Quit");
//             Console.Write("Select a choice from the menu: ");

//             string choice = Console.ReadLine();

//             switch (choice)
//             {
//                 case "1":
//                     recipe = new Recipe();
//                     recipeBook.AddRecipe(recipe);
//                     break;


                    
//                 case "2":
//                     recipe.DisplayRecipeName();
//                     meal = new Meal();
//                     MakeMeal();
//                     DisplayMeal();

//                     break;

//                 case "3":
//                     quit = true;
//                     Console.WriteLine("Have a nice day!");
//                     break;

//                 default:
//                     Console.WriteLine("Invalid choice.");
//                     Console.WriteLine();
//                     break;
//             }
//         }
//     }
//     public void MakeMeal()
//     {   
//         bool done = false;
//         while (!done)
//         {
            
//             Console.Write("Would you like to add a meal item?(y/n) ");
//             string response = Console.ReadLine() ?? String.Empty;
//             response = response.ToLower();
//             if (response == "y")
//             {
//                 recipeBook.DisplayRecipes();
//                 _recipes = recipeBook.GetRecipeList();
//                 Console.Write("What meal item would you like to add to this meal? ");
//                 int num = int.Parse(Console.ReadLine());
//                 if (num > 0 && num < _recipes.Count) {
//                     Recipe mealitem = _recipes[num - 1]; // Set mealItem equal to the receipe asscoicated with the index num -1 in the list of receipes
//                     _recipes.Add(mealitem);
//                 } else
//                 {
//                     Console.WriteLine("Invalid entry. Please try again.");
//                 }
                
//             } else if (response == "n")
//             {
//                 done = true;
//             } else
//             {
//                 Console.WriteLine("Invalid entry try again");
//             }
            
//         }

//     }

//     public void DisplayMeal()
//     {
//         Console.WriteLine("---------------------------------");
//         string mealName = meal.GetName();
//         Console.WriteLine($"{mealName}");
//         foreach (Recipe recipe in _recipes)
//         {
//             Console.WriteLine("+++++++++++++++++++++++++++++++");
//             recipe.DisplayRecipe();
//             Console.WriteLine("+++++++++++++++++++++++++++++++");

//         }
//         Console.WriteLine("---------------------------------");
//     }

// }

































// // public class Menu
// // {

// //     public void DisplayMenu()
// //     {

// //         bool quit = false;
// //         while (!quit)
// //         {
// //             Console.WriteLine("======Menu Options======");
// //             Console.WriteLine("1. Add meal option");
// //             Console.WriteLine("2. Make a meal");
// //             Console.WriteLine("3. Quit");
// //             Console.Write("Select a choice from the menu: ");

// //             string choice = Console.ReadLine();

// //             switch (choice)
// //             {
// //                 case "1":
// //                     Console.WriteLine("choose category");
// //                     Console.WriteLine("1. Breakfast");
// //                     Console.WriteLine("2. Lunch");
// //                     Console.WriteLine("3. Dinner");
// //                     string category = Console.ReadLine();
// //                     Console.Write("Enter the name of the meal: ");
// //                     string name = Console.ReadLine();
// //                     Console.Write("How many steps will there be? ");
// //                     string steps = int.Parse(Console.ReadLine());
// //                     AddSteps(steps);
// //                     Console.Write($"Where do you want to save {name}: ");
// //                     string filename = Console.ReadLine();
// //                     Save(filename);
// //                     break;

                    
// //                 case "2":
// //                     Console.WriteLine("choose category");
// //                     Console.WriteLine("1. Breakfast");
// //                     Console.WriteLine("2. Lunch");
// //                     Console.WriteLine("3. Dinner");
// //                     string category = Console.ReadLine();

// //                     // load(category);
// //                     DisplayMealOptions(category);
// //                     Console.Write("Enter the name of the meal: ");
// //                     string name = Console.ReadLine();
// //                     // SelectByName(name); // search for the meal and run the steps for
// //                     DisplayMeal(name);
// //                     break;

// //                 case "3":
// //                     quit = true;
// //                     Console.Write("Enter the file path where you would like to save the the program: ");
// //                     savePath = Console.ReadLine();
// //                     tracker.Save(savePath);
// //                     Console.WriteLine("Have a nice day!");
// //                     break;

// //                 default:
// //                     Console.WriteLine("Invalid choice.");
// //                     Console.WriteLine();
// //                     break;
// //             }
// //         }
// //     }
// // }