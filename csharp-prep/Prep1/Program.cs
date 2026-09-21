using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;
        Console.Write("Enter first name: ");
        firstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {firstName} {lastName}");
    }

}