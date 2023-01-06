using System;

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;
        while (runProgram != false)
        {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,100);

        Console.Write("\nIm thinking of a number between 1 and 100? ");

        Console.Write("\nCan you guess the magic number? ");
        string guess = Console.ReadLine();
        int guessNum = int.Parse(guess);
        int counter = 1;

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
            counter = ++counter;
        }
        
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {counter} guesses");
        Console.Write("\nDo you want to play again? Y/N ");
        string playAgain = Console.ReadLine();

        if(playAgain.ToLower() != "y")
        {
            Console.WriteLine("Thanks for playing");
            runProgram = false;
        }
        
        }
    }
}