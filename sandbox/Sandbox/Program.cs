// using System.Reflection.Metadata;

// class Program
// {

//     static double AddNumbers(double x, int y)
//     {
//         return x + y;
//     }

//     static void DisplayGreeting(string name)
//     {
//         Console.WriteLine($"Welcome {name}, pleased to meet you.");
//     }

//     static void Main(string[] args)
//     {

//         DisplayGreeting("Bob");
//         double answer = AddNumbers(12.234, 10);
//         Console.WriteLine(answer);

//     }

// }



using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.Write("What is your height: ");

        int num = int.Parse(Console.ReadLine());

        if (num < 48)
        {
        Console.WriteLine("Sorry, you are too short to ride.");
        }

        else if (num > 78)
        {
            Console.WriteLine("Sorry, you are too tall to ride.");
        }

        else
        {
            Console.WriteLine("Enjoy the ride!");
        }
  
    }
}


