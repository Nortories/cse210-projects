using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        System.Console.WriteLine(assignment.GetSummary()+"\n");
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        System.Console.WriteLine(mathAssignment.GetSummary());
        System.Console.WriteLine(mathAssignment.GetHomeworkList()+"\n");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        System.Console.WriteLine(writingAssignment.GetSummary());
        System.Console.WriteLine(writingAssignment.GetWritingInformation()+"\n");
    }
}