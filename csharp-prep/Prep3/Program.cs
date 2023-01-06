using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,100);

        Console.Write("Im thinking of a number between 1 and 100? ");

        Console.WriteLine("Can you guess the magic number? ");
        string guess = Console.ReadLine();
        int guessNum = int.Parse(guess);

        while (guessNum != magicNum)
        {
            if (guessNum > magicNum)
            {
                Console.WriteLine("Lower!");
                Console.Write("Can you guess the magic number? ");
                guess = Console.ReadLine();
                guessNum = int.Parse(guess);
            }
            else
            {
                Console.WriteLine("Higher!");
                Console.Write("Can you guess the magic number? ");
                guess = Console.ReadLine();
                guessNum = int.Parse(guess);
            }
        }
        
        Console.Write("You guessed it!");
    }
}