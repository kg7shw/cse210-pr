public class Recipe
{
    private string _name;
    private string _servingSize;
    List<IngredientsInfo> _ingredientsinfo = new List<IngredientsInfo>();
    List<string> _instructions = new List<string>();
    
    public Recipe()
    {
        SetName();
        SetIngredientsInfo();
        SetInstructions();
    }

    public void SetName()
    {
        Console.Write("What is the name of this recipe? ");
        _name = Console.ReadLine() ?? String.Empty;
    }
    public void SetIngredientsInfo()
    {
        
        Console.Write("Enter ingredient: ");
        string ingredient = Console.ReadLine() ?? String.Empty;
        Console.Write("Enter the quantity: ");
        string quantity = Console.ReadLine() ?? String.Empty;
        Console.Write("Enter any additional information: ");
        string extraInfo = Console.ReadLine() ?? String.Empty;

        IngredientsInfo ii = new IngredientsInfo(ingredient, quantity, extraInfo);

    }
    public void SetInstructions()
    {
        Console.Write("Enter the Instructions: ");
        string instructions = Console.ReadLine() ?? String.Empty;

        _instructions.Add(instructions);
    }



}