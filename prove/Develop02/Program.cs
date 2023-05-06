using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + " ");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
