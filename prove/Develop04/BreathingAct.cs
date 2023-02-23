class BreathingAct : Activity
{
    public BreathingAct(int duration) 
    :base (duration, "Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}

    public void Breath()
    {
        base.OpenActivity();
        base.pause(3);
        double addSeconds = _duration;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(addSeconds);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
            {
                System.Console.Clear();
                System.Console.Write("Breath in    ");
                base.CountDownTimer(4);
                System.Console.Clear();
                System.Console.Write("Breath out    ");
                base.CountDownTimer(5);
                currentTime = DateTime.Now;
            }
        base.EndActivity();
        System.Console.WriteLine();
        base.Spinner(5);
        System.Console.Clear();
        Program.SelectAct();
    }
}