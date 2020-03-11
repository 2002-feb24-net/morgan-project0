using System;

namespace InstrumentStore
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.BackgroundColor = ConsoleColor.Blue;
            // Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine(value.PadRight(Console.WindowWidth - 1));
            // Console.ResetColor();

            Console.WriteLine("Hello! Welcome to our instrument store! \n\nIf you would like to see a selection of products we have, type 'products'. \nTo see a list of store locations, type 'stores'. \nfor a list of any other options, type 'help'.");

            bool helpme = false;

            string response = System.Console.ReadLine().ToLower();
            System.Console.WriteLine("\n\n");

            if (response == "help")
            {
                helpme = true;
            }

            while (helpme)
            {
                helpme = Help.StartHelp();
                
            }

            if (!helpme)
            {
                System.Console.WriteLine("Let's start your order!");

            }
        }
    }
}
