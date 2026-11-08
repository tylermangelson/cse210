using System;

class Program
{
    public static void Main(String[] args)
    {
        Menu myMenu = new Menu();

        int response = 0;
        while (response != 5)
        {

            Console.Clear();

            response = myMenu.DisplayMenu();

            switch (response)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case 2:

                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();                    
                    break;

                case 3:

                    break;

                case 4:

                    break;
            }
        }
    }
}
