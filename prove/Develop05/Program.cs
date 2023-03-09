using System;
using System.ComponentModel;

class Program
{
    //Globale vars
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        bool runProgram = true;
        while(runProgram)
        {
            System.Console.WriteLine($"\nYou have {DisplayPoints(goals)} points");
            DisplayMenu();
            string choice = System.Console.ReadLine(); //Logic
                switch (choice)
                {
                    case "1":
                        CreateGoal(goals);
                        break;
                    case "2":
                        ListGoal(goals);
                        break;
                    case "3":
                        SaveGoal(goals);
                        break;
                    case "4":
                        LoadGoal(goals);
                        break;
                    case "5":
                        RecordEvent(goals);
                        break;
                    case "6":
                        DeleteGoal(goals);
                        break;
                    case "7":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
        }
    }

    static void DeleteGoal(List<Goal> goals)
    {
        System.Console.WriteLine();//Just gives spacing
        int counter = 1;
        foreach (Goal g in goals)
        {
            string goalString = g.DisplayGoal();
            System.Console.WriteLine($"{counter}. {goalString}");
            counter++;
        }
        System.Console.WriteLine("\nWitch Goal do you want to DELETE? >    ");
        int choice = Convert.ToInt16(System.Console.ReadLine());

        goals.RemoveAt(choice-1); //remove object in goal list at user choice
    }

    static void DisplayMenu() //Menu
    {
        System.Console.WriteLine("\n1. Create New Goal");
        System.Console.WriteLine("2. List Goals");
        System.Console.WriteLine("3. Save Goals");
        System.Console.WriteLine("4. Load Goals");
        System.Console.WriteLine("5. Record Event");
        System.Console.WriteLine("6. Delete Goal");
        System.Console.WriteLine("7. Quit");
        System.Console.WriteLine("Select a choice from the menu >    ");
    }

    static void CreateGoal(List<Goal> goals)
    {
        System.Console.WriteLine("\n1. Simple Goal");
        System.Console.WriteLine("2. Eternal Goal");
        System.Console.WriteLine("3. Checklist Goal");
        System.Console.WriteLine("Witch goal type would you like to make? >    ");
        string choice = System.Console.ReadLine();

        System.Console.Write("\nWhat is the name of your goal? >    ");
        string name = System.Console.ReadLine();

        System.Console.Write("\nGive a discription >    ");
        string discription = System.Console.ReadLine();

        System.Console.Write("\nSet the points for the goal >    ");
        int value = Convert.ToInt32(System.Console.ReadLine());

            switch(choice) //Logic
            {
                case "1":
                    SimpleGoal simpleGoal = new SimpleGoal(name, discription, value);
                    goals.Add(simpleGoal);
                    break;
                case "2":
                //eternal goal
                    EternalGoal eternalGoal = new EternalGoal(name, discription, value);
                    goals.Add(eternalGoal);
                    break;
                case "3":
                //Check list goal
                    System.Console.WriteLine("\nHow many times do you need to do this, to accomplish the goal for bonus points? >    ");
                    int goalCount = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("\nSet bonus points when you've completed the entire goal >    ");
                    int bonusPoint = Convert.ToInt32(System.Console.ReadLine());
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, discription, value, goalCount, bonusPoint);
                    goals.Add(checklistGoal);
                    break;                   
            }
    }

    static void ListGoal(List<Goal> goals)
    {
        System.Console.WriteLine();//spacing
        foreach (Goal g in goals)
        {
            switch(TypeDescriptor.GetClassName(g)) //Gets object type
            {
                case "SimpleGoal":
                    string simpString = g.DisplayGoal();
                    System.Console.WriteLine(simpString);
                    break;
                case "EternalGoal":
                    string EternalString = g.DisplayGoal();
                    System.Console.WriteLine($"{EternalString}");
                    break;
                case "ChecklistGoal":
                    string checklistGoal = g.DisplayGoal();
                    System.Console.WriteLine($"{checklistGoal}");
                    break;
            }            
        }
        System.Console.WriteLine("Enter to return to menu");
        System.Console.ReadLine();
    }

    static void SaveGoal(List<Goal> goals)
    {
       string filename = ("goal_data.txt");

       using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal g in goals)
            {
                string goalString = g.DisplayGoal(true);
                outputFile.WriteLine($"{g} |{goalString}");
            }
        }
    }

    static void LoadGoal(List<Goal> goals)
    {
        goals.Clear();
        string filename = "goal_data.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string type = parts[0];

            string isComplete;
            string name;
            string discription;
            int value;
            int currentCount;
            int goalCount;
            int bonusPoint;

            switch(type)
            {
                //If loading SimpleGoals
                case "SimpleGoal ":
                    isComplete = parts[1]; //Skips parts[0] string object type
                    name = parts[2];
                    discription = parts[3];
                    value = Convert.ToInt32(parts[4]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, discription, value);
                    if (isComplete == ("[X] "))
                    simpleGoal.SetTrue();
                    goals.Add(simpleGoal);
                    break;

                case "EternalGoal ":
                    //load eternal goal from txt
                    isComplete = parts[1]; //Skips parts[0] string object type
                    name = parts[2];
                    discription = parts[3];
                    value = Convert.ToInt32(parts[4]);
                    currentCount = Convert.ToInt32(parts[5]); //loads currentCount
                    EternalGoal eternalGoal = new EternalGoal(name, discription, value, currentCount);
                    if (isComplete == ("[X] "))
                    eternalGoal.SetTrue();
                    goals.Add(eternalGoal);
                    break;

                case "ChecklistGoal ":
                    //load ChecklistGoal from txt
                    isComplete = parts[1]; //Skips parts[0] string object type
                    name = parts[2];
                    discription = parts[3];
                    value = Convert.ToInt32(parts[4]);
                    currentCount = Convert.ToInt32(parts[5]); //loading currentCount
                    goalCount = Convert.ToInt32(parts[6]); //loading goalCount
                    bonusPoint = Convert.ToInt32(parts[7]);// loading bonusPoint
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, discription, value, currentCount, goalCount, bonusPoint);
                    if (isComplete == ("[X] "))
                    checklistGoal.SetTrue();
                    goals.Add(checklistGoal);
                    break;
            }
        }
    }

    static void RecordEvent(List<Goal> goals)
    {
        System.Console.WriteLine();//spacing
        int counter = 1;
        foreach (Goal g in goals)
        {
            string goalString = g.DisplayGoal();
            System.Console.WriteLine($"{counter}. {goalString}");
            counter++;
        }
        System.Console.WriteLine("\nWitch Goal did you complete? >    ");
        int choice = Convert.ToInt16(System.Console.ReadLine());

        Goal updateGoal = goals[choice-1];
        updateGoal.SetTrue();
    }

    static int DisplayPoints(List<Goal> goals)
    {
        int points = 0;
        foreach (Goal g in goals)
        {
            points = points + g.GetPoints();        
        }
        return points;
    }
}