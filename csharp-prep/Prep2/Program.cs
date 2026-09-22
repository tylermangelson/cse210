using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
string letterGrade = "N/A";

        Console.Write("What is your grade %: ");
        string gradeFromUser = Console.ReadLine();

        int studentGrade = int.Parse(gradeFromUser);

        if (studentGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (studentGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (studentGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (studentGrade >= 60)
        {
            letterGrade = "D";
        }
        else if (studentGrade < 60)
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Grade: {letterGrade}");

        
        if (studentGrade > 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry. You failed this course :( better luck next time pal.");
        }
        
        
    
    }
}