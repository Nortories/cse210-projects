using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNum = PromptUserNumber();
        int squNum = SquareNumber(favNum);
        DisplayResult(userName, squNum);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write($"\nPlease enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber ()
    {
        Console.Write($"\nPlease enter your favorite numbe: ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }
    static int SquareNumber (int favNum)
    {
        int squNum = favNum * favNum;
        return squNum;
    }
    static void DisplayResult (string userName, int squNum)
    {
        Console.Write($"\n{userName}, the square of your number is {squNum} ");
        
    }
}