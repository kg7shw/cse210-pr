using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();

        Menu _menu = new Menu(_journal);
        _menu.Display();
    }
}
