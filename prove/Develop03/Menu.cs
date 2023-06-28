public class Menu
{

    public void DisplayMenu()
    {

        bool quit = false;
        while (!quit)
        {
            
            
            DisplayScripture();
            Console.Write("Press Enter or any Key to hide the words or 'quit' to exit: ");
            string choice = Console.ReadLine();

            

            if (choice == "quit")   
            {
                quit = true;
                Console.WriteLine("Have a nice day!");
            } 



            
        
    }
}