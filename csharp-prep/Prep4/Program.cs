using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int numUser = -1;
        do
        {

        Console.Write("Enter number: ");
        string valueUser = Console.ReadLine();
        numUser = int.Parse(valueUser);
        if (numUser != 0)
        {
            nums.Add(numUser);
        }

        
        }
        while (numUser != 0);
        
        int sum = 0;

        foreach (int data in nums)
        {
            sum += data;
        }

        Console.WriteLine($"The sum is: {sum}");
    }
}