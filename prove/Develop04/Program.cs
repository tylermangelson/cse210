using System;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity activity = new BaseActivity();
        activity.RunCountDownMessage("Hello", 5);
        activity.DisplaySpinnerMessage("Well done", 10);

        DateTime endTime = DateTime.Now.AddSeconds(15);

        while (DateTime.Now < endTime)
        {
            activity.RunCountDownMessage("Breathe In . . . ", 4);
            activity.RunCountDownMessage("Breathe In . . . ", 6);

        }
        
    }

    
}