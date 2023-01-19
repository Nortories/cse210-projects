public class Entery
{
    DateTime datetime = DateTime.Now;

    public string _title;
    public string _datetime;
    public string _entery;

    //Stores most recent entery to static string
    public static string newEntery;

    //Randomly gets and writes one of the elements from the prompts list.
    public void Prompt()
    {
        Random rand = new Random();

        // Add/Remove prompts
        string[] prompts = 
        {
        "What did you eat for breakfast? ",
        "How was the weather today? ",
        "What is something new you learned? ",
        "Where where you at lunch? ",
        "What are your plans for tomorrow? "
        };

        //Creates list and populates from 'prompts'
        List<string> promptsList = new List<string>(prompts);

        //Generate a random number between 0 and elements in the list
        var number = rand.Next(0, (promptsList.Count));

        //Writes a random element from promptsList
        newEntery = promptsList[number];
        Console.WriteLine($"{newEntery} ");
    }
    
    //Gets userinput for title and journal entery then stores the entery in static var newEntery.
     public void Write()
    {
        System.Console.Write("Entery Title > ");
        _title = Console.ReadLine();
        System.Console.Write("Entery > ");
        _entery = Console.ReadLine();
        _datetime = datetime.ToString();
        newEntery = newEntery + ($"\n{_title}\n{_datetime}\n{_entery}\n,");   
        System.Console.WriteLine("Thank you for your Journal entery\n");
    }

}