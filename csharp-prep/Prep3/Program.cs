using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;

        while (play == true)
        {
            Random randomNum = new Random();
            int num = randomNum.Next(1, 11);
            int guessedNum = 0;
            int guessCount = 0;

            Console.WriteLine("Guess the number!");

            while (guessedNum != num)
            {

                guessedNum = int.Parse(Console.ReadLine());

                if (guessedNum > num)
                {
                    guessCount += 1;
                    Console.WriteLine("Lower...");
                }
                else if (guessedNum < num)
                {
                    guessCount += 1;
                    Console.WriteLine("Higher...");
                }
                else
                {
                    guessCount += 1;
                    Console.Write($"You got it in {guessCount} guesses! Want to keep playing (y/n):");
                    string cont = Console.ReadLine();
                    cont = cont.ToUpper();

                    if (cont == "Y")
                    {
                        play = true;
                    }
                    else
                    {
                        play = false;
                        Console.WriteLine("Let's play again sometime!");
                    }

                }
            }
        }


    }
}