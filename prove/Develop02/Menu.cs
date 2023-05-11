public class Menu
{
    private Journal _journal;

    public Menu(Journal journal)
    {
        _journal = journal;
    }

    public void Display()
    {
        string response = "";
        string[] menu_options = {"L","A","D","Q","F","S"};
        while(response != "Q")
        {
            while(menu_options.Contains(response)==false)
            {
                Console.Write("[L]oad journal[A]dd entry:\n[D]isplay entries\n[F]ind entries\n[Q]uit\n\nWhat do you want to do? ");

                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();

            }

            switch (response)
            {
                case "Q":
                    Environment.Exit(0);
                    break;
                case "A":
                    Console.Write("[G]et random Prompt and add a journal entry");
                    Console.Write("[W]rite in your journal without a prompt");
                    Console.Write("[A]dd your own prompt and write a journal entry");
                    Console.Write("\nWhat would you like to do? ");

                    string A_SubResponse = "";
                    A_SubResponse = Console.ReadLine() ?? String.Empty;
                    A_SubResponse = A_SubResponse.ToUpper();
                    string[] SubMenu_options = {"G","W","A"};

                    switch (A_SubResponse)
                    {
                        case "G":
                            // GetRandomPrompt()
                            Console.Write("Please enter your entry: ");
                            string entry = Console.ReadLine() ?? String.Empty;
                            Console.Write("Please enter your title: ");
                            string title = Console.ReadLine() ?? String.Empty;
                            Console.Write("Please enter your author: ");
                            string author = Console.ReadLine() ?? String.Empty;

                            _journal.AddEntry(new Entry(entry, title, author));
                            break;
                        case "A":

                            // AddPrompt()
                            Console.Write("Please enter your entry: ");
                            entry = Console.ReadLine() ?? String.Empty;
                            Console.Write("Please enter your title: ");
                            title = Console.ReadLine() ?? String.Empty;
                            Console.Write("Please enter your author: ");
                            author = Console.ReadLine() ?? String.Empty;

                            _journal.AddEntry(new Entry(entry, title, author));
                            break;
                        case "W":
                            Console.Write("Please enter your entry: ");
                            entry = Console.ReadLine() ?? String.Empty;
                            Console.Write("Please enter your title: ");
                            title = Console.ReadLine() ?? String.Empty;
                            Console.Write("Please enter your author: ");
                            author = Console.ReadLine() ?? String.Empty;

                            _journal.AddEntry(new Entry(entry, title, author));
                            break;
                    }

                    
                    break;
                case "S":
                    _journal.ShowEntry();
                    break;
                case "F":
                    Console.Write("Search by: [T]itle");
                    Console.Write("Search by: [D]ate");
                    Console.Write("Search by: [A]uthor");
                    Console.Write("\nWhat type of search do you want to perform? ");

                    string searchType = "";
                    searchType = Console.ReadLine() ?? String.Empty;
                    searchType = searchType.ToUpper();
                    string[] F_SubMenu_options = {"T","D","A"};

                    switch (searchType)
                    {
                        case "T":


                            break;
                        case "D":


                            break;
                        case "A":
                            // Console.Write("Please enter your author: ");
                            // author = Console.ReadLine() ?? String.Empty;
                            // Journal.FindEntriesByAuthor(author);
                            break;
                    }


                    // string searchTerm = Console.ReadLine() ?? "";
                    // Console.WriteLine("[D]ate search");
                    // Console.WriteLine("[T]opic search");
                    // Console.WriteLine("[K]eywords search");
                    // Console.Write("\nWhat type of search do you want to perform? ");
                    // string searchType = Console.ReadLine()?.ToUpper() ?? "";
                    // // if (searchType == "D")
                    // // {
                    // //     Console.Write("Please enter the date (e.g., yyyy-MM-dd): ");
                    // //     string dateInput = Console.ReadLine() ?? "";
                    // //     if (DateTime.TryParse(dateInput, out DateTime date))
                    // //         _journal.FindEntriesByDate(date);
                    // // }
                    // // else if (searchType == "T")
                    // // {
                    // //     Console.Write("Please enter the topic: ");
                    // //     string topic = Console.ReadLine() ?? "";
                    // //     _journal.FindEntriesByTopic(topic);
                    // // }
                    // // else if (searchType == "K")
                    // // {
                    // //     Console.Write("Please enter the keywords (comma-separated): ");
                    // //     string keywordsInput = Console.ReadLine() ?? "";
                    // //     string[] keywords = keywordsInput.Split(',');
                    // //     _journal.FindEntriesByKeywords(keywords);
                    // }
                    break;

                case "R":
                    // _journal.GetRandomentry();
                    break;

                    

            }
            response = "";
        }

    }

}
