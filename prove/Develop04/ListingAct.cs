class ListingAct : Activity
{
    public ListingAct()
    {}
    public ListingAct(int duration)
    : base (duration, "Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}

    private string RandPromt()
    {
        List<string> listPromt = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"};
        Random rand = new Random();
        int randNum = rand.Next(0, (listPromt.Count));
        return listPromt[randNum];
    }
    public void CreateItem()
    {

    }
    public void List()
    {
        double addSeconds = _duration;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(addSeconds);
        DateTime currentTime = DateTime.Now;

        System.Console.Clear();
        base.OpenActivity();
        System.Console.WriteLine($"\n{RandPromt()}");
        base.CountDownTimer(9);
        System.Console.WriteLine("List as many items as you can");

        List<string> item = new List<string>();

        while (currentTime < futureTime)
        {
            string addToList = System.Console.ReadLine();
            item.Add(addToList);
            currentTime = DateTime.Now;
        }
        System.Console.Clear();
        System.Console.WriteLine($"You listed {(item.Count)} item(s) in {_duration} seconds great job!");
        System.Console.WriteLine($"Would you like to see the item(s) you listed?    y/n");
        string showList = (System.Console.ReadLine());
        System.Console.Clear();
        if (showList.ToLower() == "y")
        {
            foreach (string i in item)
            {
                System.Console.WriteLine(i);
            }
            base.Spinner(9);

        }
        else
        {
            System.Console.Clear();
            Program.SelectAct();
        };
        System.Console.Clear();
        Program.SelectAct();
    }
}