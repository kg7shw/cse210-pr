using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment TestAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(TestAssignment.GetSummary());

        MathAssignment TestMathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(TestMathAssignment.GetHomeworkList());

        WritingAssignment TestWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(TestWritingAssignment.GetWritingInformation());


    }
}