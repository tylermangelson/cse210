using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int birthYear;
        PromptUserBirthYear(out birthYear);

        int squared = SquareNumber(number);

        DisplayResult(name, squared, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("What year were you born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squared, int birhtYear)
    {
        int age = DateTime.Now.Year - birhtYear;

        Console.WriteLine($"{name}, the square of your number is {squared}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}