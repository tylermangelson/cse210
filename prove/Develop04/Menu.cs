class Menu
{
    public int DisplayMenu()
    {
        int response = 0;
        while (response < 1 || response > 4)
        {

            {
                Console.WriteLine("Welcome to the Mindfulness Activity program!");
                Console.WriteLine("Choose which activity you want to do.");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Listing");
                Console.WriteLine("3. Reflection");
                Console.WriteLine("4. Quit");
                Console.Write("> ");

                response = int.Parse(Console.ReadLine());


            }

        }

        return response;
    }
}

