using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the \"guess a number\" game.");
        Console.WriteLine("You try to guess a random number in the smallest number of attempts.\n");

        Console.Write("Pick a positive integer: ");
        string valueUser = Console.ReadLine();
        int valueMax = int.Parse(valueUser);

        Random randomGenerator = new Random();
        int valueRandom = randomGenerator.Next(1, valueMax);

        Console.WriteLine($"Guess a number between 1 and {valueMax}. ");

        string valueGuessStr = "";
        int valueGuessInt = 0;
        List<int> myList = new List<int>();


        do
        {
            Console.WriteLine("> ");
            valueGuessStr = Console.ReadLine();
            valueGuessInt = int.Parse(valueGuessStr);

            myList.Add(valueGuessInt);


            if (valueGuessInt > valueRandom) {
                Console.WriteLine("\tToo high!");
            }
            else if (valueGuessInt < valueRandom) {
                Console.WriteLine("\tToo low!");
            }
            

        } while (valueGuessInt != valueRandom);

        Console.WriteLine($"You were able to find the number in {myList.Count} guesses.");
        Console.WriteLine($"The numbers you guessed were: {myList}");


 

    }
}