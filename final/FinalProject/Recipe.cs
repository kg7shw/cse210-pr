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
        Console.WriteLine("=======================================");
        bool quit = false;
        while (!quit)
        {
        
            // Console.Write("Do you want to add an Ingredient?(y/n) ");
            // string response = Console.ReadLine() ?? String.Empty;

            

                
                Console.Write("Enter ingredient: ");
                string ingredient = Console.ReadLine() ?? String.Empty;
                if (ingredient.ToLower() == "stop"){
                    quit = true;
                    DisplayIngredientsInfoItems();
                    Console.WriteLine("Thank you for listing the ingredients!");
                    Console.WriteLine("=======================================");
                } else
                {
                
                Console.Write("Enter the quantity: ");
                string quantity = Console.ReadLine() ?? String.Empty;
                Console.Write("Enter any additional information: ");
                string extraInfo = Console.ReadLine() ?? String.Empty;

                IngredientsInfo ii = new IngredientsInfo(ingredient, quantity, extraInfo);
                _ingredientsinfo.Add(ii);
                }
            

        }
    }
    public void SetInstructions()
    {
        Console.Write("Enter the Instructions: ");
        string instructions = Console.ReadLine() ?? String.Empty;

        _instructions.Add(instructions);
    }

        public void DisplayIngredientsInfoItems()
    {
        foreach (IngredientsInfo option in _ingredientsinfo)
        {
            option.DisplayIngredientsInfo();

        }
    }

    public void DisplayInstructions()
    {
        foreach (var item in _instructions)
        {
            Console.WriteLine(item);
        }
    }


    public void DisplayRecipeName()
    {
        Console.WriteLine(_name);
    }

    public void DisplayRecipe()
    {
        DisplayRecipeName();
        DisplayIngredientsInfoItems();
        DisplayInstructions();
    }

    public void MakeRecipe()
    {
        SetName();
        SetIngredientsInfo();
        SetInstructions();
    }



}