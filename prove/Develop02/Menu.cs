using System.IO; 

public class Menu
{
    private Journal _journal;
    private Prompt _prompt;
    private string _fileName = "";
    private string new_prompt = "";

    public Menu(Journal journal)
    {
        _journal = journal;
    }

    public void Display()
    {
        string response = "";
        string[] menu_options = {"L", "S", "Q"};
        while(response != "Q")
        {
            while(menu_options.Contains(response)==false)
            {
                Console.WriteLine("[L]oad journal: ");
                Console.WriteLine("[S]ave journal: ");
                Console.WriteLine("[Q]uit");
                Console.Write("What do you want to do? ");
                
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
                

            }
            

            switch (response)
            {

                case "Q":
                    Environment.Exit(0);
                    break;
                case "S":
                Console.WriteLine("Enter the filename to save the journal:");
                _fileName = Console.ReadLine() ?? String.Empty;
                _journal.fileName = _fileName;
                    _journal.SaveJournalToFile();
                    break;
                
                case "L":
                    Console.Write("Enter the filename to load the journal from (including extension): ");
                    
                    _fileName = Console.ReadLine() ?? String.Empty;
                        // Load the existing file
                        _journal.LoadJournalFromFile(_fileName);
                    
                    // User selects another option.
                    Console.WriteLine("[A]dd entry: ");
                    Console.WriteLine("[D]isplay entries: ");
                    Console.WriteLine("[F]ind entries: ");
                    Console.Write("What do you want to do? ");

                    string L_SubMenu_choice = "";
                    L_SubMenu_choice = Console.ReadLine()?.ToUpper() ?? String.Empty;
                    string[] L_SubMenu_options = {"A", "D", "F"};
                    
                
                    switch (L_SubMenu_choice)
                    {
                        case "A":
                            Console.WriteLine("[G]et random Prompt and add a journal entry");
                            Console.WriteLine("[W]rite in your journal without a prompt");
                            Console.WriteLine("[A]dd your own prompt and write a journal entry");
                            Console.Write("\nWhat would you like to do? ");

                            string A_SubResponse = "";
                            A_SubResponse = Console.ReadLine() ?? String.Empty;
                            A_SubResponse = A_SubResponse.ToUpper();
                            string[] SubMenu_options = {"G","W","A"};

                            switch (A_SubResponse)
                            {
                                case "G":
                                    // GetRandomPrompt()

                                    Console.Write("Please enter who is writing the Journal entry: ");
                                    string author = Console.ReadLine() ?? String.Empty;
                                    Console.Write("Please enter the title of your entry: ");
                                    string title = Console.ReadLine() ?? String.Empty;
                                    new_prompt = _journal._prompt.GetRandomPrompt();
                                    Console.WriteLine(new_prompt);
                                    Console.Write("Please enter your entry: ");
                                    string entry = Console.ReadLine() ?? String.Empty;

                                    _journal.AddEntry(new Entry(new_prompt, author, title, entry));
                                    break;
                                case "A":

                                    // AddPrompt()
                                    Console.Write("Please enter the prompt you would like to add: ");
                            
                                    new_prompt = Console.ReadLine() ?? String.Empty;
                                    _prompt.AddPrompt(new_prompt);
                                    Console.Write("Please enter who is writing the Journal entry: ");
                                    author = Console.ReadLine() ?? String.Empty;
                                    Console.Write("Please enter the title of your entry: ");
                                    title = Console.ReadLine() ?? String.Empty;
                                    Console.Write("Please enter your entry: ");
                                    entry = Console.ReadLine() ?? String.Empty;

                                    _journal.AddEntry(new Entry(new_prompt, entry, title, author));
                                    break;
                                case "W":
                                    new_prompt = "";
                                    Console.Write("Please enter who is writing the Journal entry: ");
                                    author = Console.ReadLine() ?? String.Empty;
                                    Console.Write("Please enter the title of your entry: ");
                                    title = Console.ReadLine() ?? String.Empty;
                                    Console.Write("Please enter your entry: ");
                                    entry = Console.ReadLine() ?? String.Empty;

                                    _journal.AddEntry(new Entry(new_prompt, author, title, entry));
                                    break;
                            }

                            
                            break;
                        case "D":
                            _journal.DisplayJournal();
                            break;
                        // case "F":
                        //     Console.WriteLine("Search by: [T]itle");
                        //     Console.WriteLine("Search by: [D]ate");
                        //     Console.WriteLine("Search by: [A]uthor");
                        //     Console.Write("\nWhat type of search do you want to perform? ");

                        //     string searchType = "";
                        //     searchType = Console.ReadLine() ?? String.Empty;
                        //     searchType = searchType.ToUpper();
                        //     string[] F_SubMenu_options = {"T","D","A"};

                        //     switch (searchType)
                        //     {
                        //         case "T":


                        //             break;
                        //         case "D":


                        //             break;
                        //         case "A":
                        //             // Console.Write("Please enter your author: ");
                        //             // author = Console.ReadLine() ?? String.Empty;
                        //             // Journal.FindEntriesByAuthor(author);
                        //             break;
                        //     }

                        case "R":
                            // _journal.GetRandomentry();
                            break;
                        }
                    break;   


                    

            }
            response = "";
        }

    }

}
