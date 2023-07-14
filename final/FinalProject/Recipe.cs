public class Recipe
{
    public string Name { get; set; }
    public string ServingSize { get; set; }
    public List<IngredientsInfo> IngredientsInfo { get; set; } = new List<IngredientsInfo>();
    public List<string> Instructions { get; set; } = new List<string>();
    
    // public Recipe(string name, List<IngredientsInfo> ingredientsinfo, List<string> instructions)
    // {
    //     Name = name;
    //     IngredientsInfo = ingredientsinfo;
    //     Instructions = instructions;
    // }
    // public Recipe()
    // {
    //     SetName();
    //     SetIngredientsInfo();
    //     SetInstructions();
    // }

    public Recipe()
    {

    }

    public void GetInfo()
    {
        SetName();
        SetIngredientsInfo();
        SetInstructions();
    }


    public void SetName()
    {
        Console.Write("What is the name of this recipe? ");
        Name = Console.ReadLine() ?? String.Empty;
    }
    public void SetIngredientsInfo()
    {
        Console.WriteLine("=======================================");
        bool quit = false;
        while (!quit)
        {
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
                IngredientsInfo.Add(ii);
                }
            

        }
    }
    public void SetInstructions()
    {
        bool quit = false;
        while (!quit)
        {

            Console.Write("Enter the Instructions for the recipe: ");
            string instructions = Console.ReadLine() ?? String.Empty;

            

            if (instructions.ToLower() == "stop"){
                quit = true;
                
                Console.WriteLine("Thank you for listing the instructions!");
                
            } else
            {
            
                Instructions.Add(instructions);
            }
        }
    }

        public void DisplayIngredientsInfoItems()
    {
        foreach (IngredientsInfo option in IngredientsInfo)
        {
            option.DisplayIngredientsInfo();

        }
    }

    public void DisplayInstructions()
    {
        int i = 1;
        foreach (var item in Instructions)
        {
            Console.Write($"{i++}. ");
            Console.WriteLine(item);
        }
    }


    public void DisplayRecipeName()
    {
        Console.WriteLine(Name);
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