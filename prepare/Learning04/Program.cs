using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment TestAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(TestAssignment.GetSummary());
    }
}