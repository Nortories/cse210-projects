class Prompts
{
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
        int number = rand.Next(0, (1-(promptsList.Count)));

        //Writes a random element from promptsList
        Console.WriteLine(promptsList[number]);
    }

}