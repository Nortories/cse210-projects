
public class Entery
{
    public void Text()
    {
        Prompts prompts = new Prompts();
        prompts.Prompt();

        string entery;
        entery = Console.ReadLine();
    }

    public void Save()
    {
        File.WriteAllLinesAsync(save, text);

    }
}