public class Meal
{
    private string _name;

    List<Recipe> _recipes = new List<Recipe>();
    List<Recipe> _mealItems = new List<Recipe>();

    public Meal()
    {
        SetMealName();
        MakeMeal();

    }


    public void SetMealName()
    {
        Console.Write("What is the name of this meal? ");
        _name = Console.ReadLine() ?? String.Empty;
    }

    public void DisplayMealItems() // MealItems = Receipies
    {

        int i = 1;
        foreach (Recipe option in _recipes)
        {
            Console.Write($"{i++}. ");
            option.DisplayRecipeName();


        }
    }

    public Recipe GetMeal(int mealNumber)
    {
        return _recipes[mealNumber - 1];

    }
    public void MakeMeal()
    {   
        bool done = false;
        while (!done)
        {
            Console.Write("Would you like to add another meal item?(y/n) ");
            string response = Console.ReadLine() ?? String.Empty;
            response = response.ToLower();
            if (response == "y")
            {
                DisplayMealItems();
                Console.Write("What meal item would you like to add to this meal? ");
                int num = int.Parse(Console.ReadLine());
                if (num > 0 && num < _recipes.Count) {
                    Recipe mealitem = _recipes[num - 1]; // Set mealItem equal to the receipe asscoicated with the index num -1 in the list of receipes
                    _mealItems.Add(mealitem);
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


    public void DisplayMeal()
    {

    }
        



}