using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Authentication;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new();
        bool cont = true;
        while (cont == true)
        {
            Console.Write("Add number to list (0 to stop): ");
            int newNum = int.Parse(Console.ReadLine());
            numbers.Add(newNum);
            if (newNum == 0)
            {
                numbers.RemoveAt(numbers.Count - 1);
                cont = false;
            }

        }

        int sum = 0;
        int numCount = numbers.Count;

        Console.WriteLine($"Amount: {numCount}");
        Console.WriteLine("List:");

        int largest = -999999;
        int smallest = 999999;
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
            if (number < smallest)
            {
                smallest = number;
            }

        }
        Console.WriteLine($"Sum: {sum}");

        double avg = (double)sum / numCount;
        var sorted = new List<int>(numbers);
        sorted.Sort();

        Console.WriteLine($"Avg: {avg}");
        Console.WriteLine($"Smallest: {smallest}");
        Console.WriteLine($"Largest: {largest}");
        Console.WriteLine($"Sorted list:");
        foreach (int number in sorted)
        {
            Console.WriteLine(number);
        }



    }
}