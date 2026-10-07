using System;

class Program
{
    // static int subtract(int a, int b)
    // {
    //     return a - b;
    // }

static double FindSmallest(List<double>data)
    {
       double smallest = data[0];
       foreach (double num in data)
        {
            if (num < smallest)
            {
                smallest = num;
            }

        } 
        return smallest;
    }
    static void Main()
    {
        List<double>data = new List<double>{9, 1, 2, 3};
       double smallest = FindSmallest(data);

       Console.WriteLine(smallest);

    }
    // {
    //     int diff = subtract(2, 3);
    //     Console.WriteLine(diff);

    //     string[] names = {"Ann", "Ben", "Tyler"};

    //     foreach (string name in names)
    //     {
    //         Console.WriteLine(name);

    //     }

    //     for (int i = 0; i < names.Length; i++)
    //     {
    //         Console.WriteLine($"{i}: {names[i]}");
    //     }
    // }







}