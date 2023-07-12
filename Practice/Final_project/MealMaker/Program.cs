using System;

class Program
{
    static void Main(string[] args)
    {
        FileHandler fileHandler = new FileHandler();
        Recipe[] recipes = fileHandler.Load<Recipe[]>("recipes.json");

        Menu menu = new Menu(fileHandler, recipes);
        menu.DisplayMenu();
    }
}
