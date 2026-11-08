class BreathingActivity : BaseActivity
{
    public BreathingActivity() : base("Breathing Activity" , "This activity will help you focus on your breathing to relax and slow down.")
    {
    }

    public void Run()
    {
        DisplayName();
        DisplayDescription();
        DateTime endTime = GetDuration();
        SpinnerMessage();

        while (DateTime.Now < endTime)
        {
            Console.CursorVisible = false;
            CountDownMessage("Breathe in ", 5);
            Console.WriteLine();
            CountDownMessage("Breathe out ", 5);
            Console.WriteLine();
            Console.CursorVisible = true;
        }

        CompletionMessage();
        Thread.Sleep(3000);
        
    }

     
}