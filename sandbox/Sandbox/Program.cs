using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static int subtract(int a, int b)
    {
        return a - b;
    }

    static void Main()
    {
        int diff = subtract(2, 3);
        Console.WriteLine(diff);

        string[] names = {"Ann", "Ben", "Tyler"};

        foreach (string name in names)
        {
            Console.WriteLine(name);

        }

        for (int i = 0; i < names.Length; i++)
    }

}