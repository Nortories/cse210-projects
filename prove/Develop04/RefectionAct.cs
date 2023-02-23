class RefectionAct : Activity
{

    public RefectionAct()
    {}
    public RefectionAct(int duration)
    : base (duration, "Refection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {}

    private string RandPromt()
    {
        List<string> refectPromt = new List<string>{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."};
        Random rand = new Random();
        int randNum = rand.Next(0, (refectPromt.Count));
        return refectPromt[randNum];
    }

    private string RandQu()
    {
        List<string> listOfQu = new List<string>{
"Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"};
        Random rand = new Random();
        int randNum = rand.Next(0, (listOfQu.Count));
        return listOfQu[randNum];
    }

    public void Refect()
    {
        System.Console.Clear();
        base.OpenActivity();
        System.Console.WriteLine($"\n{RandPromt()}");
        base.pause(7);
        System.Console.Clear();

        double addSeconds = _duration;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(addSeconds);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {    
            System.Console.WriteLine(RandQu());
            base.Spinner(6);
            System.Console.Clear();
            currentTime = DateTime.Now;
        }
        base.EndActivity();
        System.Console.Clear();
        Program.SelectAct();
        {
            
        };
    }
}