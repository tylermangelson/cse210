using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
    Assignment myAssignment = new Assignment("Tyler", "Pre-calculus");
    Console.WriteLine(myAssignment.GetSummary());

    }
    
}