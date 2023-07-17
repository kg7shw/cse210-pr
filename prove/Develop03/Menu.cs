public class Menu
{
    Scripture _scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

    public void DisplayMenu()
    {

        while (_scripture.AllWordsHidden() == false)
        {
            // Console.Clear();
            _scripture.Display();

            Console.Write("Press Enter to continue or type 'quit' to exit.");
            string response = Console.ReadLine();

            if (response.ToLower() == "quit")
                {
                    break;
                }
            _scripture.HideRandomWord();

        }


            
        
    }
}