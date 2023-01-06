using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.   ");
        string userInput = "a";
        List<int> numList = new List<int>();
        int counter = 1;
        int addedNumber = 0;
        int largeNum  = 0;
        int smallNum = 999999999;


        while (userInput != "0")
        {
            Console.Write("Enter number:  ");
            userInput = Console.ReadLine();
            int userNum = int.Parse(userInput);
            counter = ++counter;
            numList.Add(userNum);    
        }

        foreach (int number in numList)
        {
            addedNumber = addedNumber + number;
        }

        foreach (int number in numList)
        {
            if (number > largeNum)
            {
                largeNum = number;
            }
        }

        foreach (int number in numList)
        {
            if(number < smallNum && number > 0 && number != 0)
            {
                smallNum = number;
            }
        }

        numList.Sort();
        

        Console.WriteLine($"The sum is :{addedNumber}");
        Console.WriteLine($"The average is :{(float)addedNumber/((float)counter-2)}");
        Console.WriteLine($"The largest number is: {largeNum}");
        Console.WriteLine($"The smallest positive number is: {smallNum}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int i in numList)
        {
            Console.WriteLine(i);
        }
    }
}