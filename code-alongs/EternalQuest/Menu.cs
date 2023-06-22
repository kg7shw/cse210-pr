public class Menu
{
    



    public void DisplayMenu()
    {

        string response = "";

        while(response != "Q")
            Console.WriteLine("======Menu Options======");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            response = Console.ReadLine() ?? String.Empty;

        switch (response)
        {
            case "6":
                Environment.Exit(0);
                break;
                
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                break;
        }
        response = "";
        



    }
}