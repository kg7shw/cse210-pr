public class Menu
{
    
    public void DisplayMenu()
    {
        string response = "";
        while (response != "4")
        {
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit\n");


            Console.Write("What do you want to do? ");
            response = Console.ReadLine() ?? String.Empty;

            switch (response)
            {
                case "1":
                    StartingMessage(duration, description, name)
                    
                
                default:
                    Environment.Exit(0);
                    break;
            }



        }
    }





    
}