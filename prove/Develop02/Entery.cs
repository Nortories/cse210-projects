
public class Entery
{

    public Entery()
    {
    }
    
    public string Text()
    {
        Prompts prompts = new Prompts();
        prompts.Prompt();

        string entery;
        entery = Console.ReadLine();

        return entery;
    }

    private void Save()
    {
        
    }
}