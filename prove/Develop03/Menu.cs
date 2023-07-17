public class Menu
{
    Reference reference = new Reference("John 3:5");
    
    Scripture _scripture = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

    public void DisplayMenu()
    {
        _scripture.GetWordArray();
        
        // while (_scripture.AllWordsHidden() == false)
        // {
            // Console.Clear();
        string response = "";
        Console.WriteLine(reference.GetRef());
        while (response.ToLower() != "quit")
        {
            _scripture.Display();
            Console.Write("Press Enter to continue or type 'quit' to exit.");
            response = Console.ReadLine();
            _scripture.HideRandomWord();
            response = _scripture.CheckIsHidden();


        }



            
        
    }
}