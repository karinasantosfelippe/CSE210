/*
Author: Karina Santos Felippe
*/
namespace Learning05;

class Program
{
    static void Main(string[] args)
    {
        // create a instance from super class Assignment
        Assignment assignment = new("Karina Felippe", "Inheritance");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        // create a instance from sub class MathAssignment
        MathAssignment mathAssignment = new("Roberto Rodrigues", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        // create a instance from sub class WritingAssignment
        WritingAssignment writingAssignment = new("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine();
    }
}