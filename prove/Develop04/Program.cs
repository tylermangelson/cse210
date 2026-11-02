using System;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity activity = new BaseActivity();
        activity.RunCountDownMessage("Hello", 5);
        activity.DisplaySpinnerMessage("Well done", 10);
        
    }

    
}