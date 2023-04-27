// See https://aka.ms/new-console-template for more information

Book mistborn = new Book("Mistborn", "Brandon Sanderson");
Book stormlight = new Book("Stormlight", "Brandon");
Book BookOfMormon = new Book("The Book of Mormon", "Mormon");

BookOfMormon.Display();
stormlight.Display();
mistborn.Display();
Console.WriteLine(mistborn.IsAvailable());