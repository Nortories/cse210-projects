using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage of grade did you get? ");
        string grade = Console.ReadLine();

        float fGrade = float.Parse(grade);
        string letter;

        if (fGrade >= 90)
        {
            letter = "A";
        }
        else if(fGrade >= 80)
        {
            letter = "B";
        }
        else if(fGrade >= 70)
        {
            letter = "C";
        }        
        else if(fGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter == "D" || letter == "F")
        {
            Console.Write($"You didnt pass with a grade of '{letter}' better luck next time");
        }
        else
        {
            Console.Write($"Congratulations you passed with a '{letter}'");
        }
    }
}