using System.ComponentModel;
using System.Diagnostics;

class BaseActivity
{

    private string _name;
    private string _description;
    private int _duration;
    
    public BaseActivity()
    {
        
    }

    public BaseActivity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    
    }

    public BaseActivity(string name, int duration)
    {
        
    }













    // public void RunCountDownMessage(string message, int seconds)
    // {
    //     Console.CursorVisible = false;
    //     for(int i=seconds; i>=1; i--)
    //     {
    //         Console.Clear();
    //         Console.Write($"{message} - {i}");
    //         Thread.Sleep(1000);
    //     }
    //     Console.CursorVisible = true;
    // }

    // public void DisplaySpinnerMessage(string message, int seconds)
    // {
    //     Console.CursorVisible = false;
    //     Console.Clear();
    //     Console.Write($"{message} ");
    //     DateTime endtime = DateTime.Now.AddSeconds(seconds);

    //     while (DateTime.Now < endtime)
    //     {
    //         Console.Write("-");
    //         Thread.Sleep(200);
    //         Console.Write("\b");
    //         Console.Write("\\");
    //         Thread.Sleep(200);
    //         Console.Write("\b");
    //         Console.Write("|");
    //         Thread.Sleep(200);
    //         Console.Write("\b");
    //         Console.Write("/");
    //         Thread.Sleep(200);
    //         Console.Write("\b");
        
    //     }

        

    //     Console.CursorVisible = true;
    // }
}