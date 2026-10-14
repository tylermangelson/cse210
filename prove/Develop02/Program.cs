using System;


class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        int response = 0;
        Journal newJournal = new Journal();

        while (response != 5)
        {
            response = myMenu.ProcessMenu();

            switch(response)
            {
                case 1:
                    Console.WriteLine("Create");
                    Entry newEntry = new Entry();
                    newEntry.CreateEntry();
                    newJournal.AddEntry(newEntry);
                    break;
                case 2:
                    Console.WriteLine("Display");
                    newJournal.Display();
                    break;
                case 3:
                    Console.WriteLine("Save");
                    Console.WriteLine("Enter filename: ");
                    string filename = Console.ReadLine();
                    newJournal.SaveEntry(filename);
                    break;
                case 4:
                    Console.WriteLine("Load");
                    Console.WriteLine("Enter filename: ");
                    string readfilename = Console.ReadLine();
                    newJournal.ReadEntry(readfilename);
                    break;
            }
        }
    }
}