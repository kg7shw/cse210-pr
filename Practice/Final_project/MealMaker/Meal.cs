public class Meal
{
    private string _name;
    private int _mealItems;

    List<Recipe> _recipes = new List<Recipe>();




    public Meal()
    {
        SetMealName();
        CreateMeal();

    }


    public void SetMealName()
    {
        Console.Write("What is the name of this meal? ");
        _name = Console.ReadLine() ?? String.Empty;
    }
    public void CreateMeal()
    {
        Console.Write("How many meal items are there in this meal? ");
        _mealItems = int.Parse(Console.ReadLine() ?? String.Empty);


        // for (int i = 0; i < length; i++)
        // {
            
        // }
        
    }
        



}