public class Entery
{
    DateTime datetime = DateTime.Now;

    public string _title;
    public string _datetime;
    public string _entery;

    public static string newEntery;


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
        Console.WriteLine($"{promptsList[number]}");
    }
    
     public void Write()
    {
        System.Console.Write("Entery Title >  ");
        _title = Console.ReadLine();
        System.Console.Write("Entery >  ");
        _entery = Console.ReadLine();
        _datetime = datetime.ToString();
        newEntery = ($"\n{_title}\n{_datetime}\n{_entery}\n,");   
    }

}