public class Menu
{

    public void DisplayMenu()
    {

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("======Menu Options======");
            Console.WriteLine("1. Add meal option");
            Console.WriteLine("2. Make a meal");
            Console.WriteLine("3. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("choose category");
                    Console.WriteLine("1. Breakfast");
                    Console.WriteLine("2. Lunch");
                    Console.WriteLine("3. Dinner");
                    string category = Console.ReadLine();
                    Console.Write("Enter the name of the meal: ");
                    string name = Console.ReadLine();
                    Console.Write("How many steps will there be? ");
                    string steps = int.Parse(Console.ReadLine());
                    AddSteps(steps);
                    Console.Write($"Where do you want to save {name}: ");
                    string filename = Console.ReadLine();
                    Save(filename);
                    break;

                    
                case "2":
                    Console.WriteLine("choose category");
                    Console.WriteLine("1. Breakfast");
                    Console.WriteLine("2. Lunch");
                    Console.WriteLine("3. Dinner");
                    string category = Console.ReadLine();

                    // load(category);
                    DisplayMealOptions(category);
                    Console.Write("Enter the name of the meal: ");
                    string name = Console.ReadLine();
                    // SelectByName(name); // search for the meal and run the steps for
                    DisplayMeal(name);
                    break;

                case "3":
                    quit = true;
                    Console.Write("Enter the file path where you would like to save the the program: ");
                    savePath = Console.ReadLine();
                    tracker.Save(savePath);
                    Console.WriteLine("Have a nice day!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}