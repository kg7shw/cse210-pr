// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Player neymar = new Player("Neymar jr.", 10, "Forward");

// neymar._name = "Neymar jr.";
// neymar._position = "Forward";
// neymar._JerseyNumber = 10;


Player Kobe = new Player("Kobe Bryant", 24);

Kobe.SetPosition("Shooting Guard");

// Console.WriteLine(Kobe.Display());

Team awesomeSauce = new Team ("awesomeSauce");

awesomeSauce.AddPlayer(Kobe);
awesomeSauce.AddPlayer(neymar);

awesomeSauce.DisplayRoster();

awesomeSauce.AddWin();
awesomeSauce.AddLoss();

