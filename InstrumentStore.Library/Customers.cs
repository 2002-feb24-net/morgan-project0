using System;

namespace InstrumentStore
{
    public static class Customers
    {

        public static void CustomerOptions()
        {
            Console.WriteLine("'products'\tSelection of products we have.\n'stores'\tList of stores.\n'help'\tQuestions about any of these options");

            bool helpme = false;

            string response = Console.ReadLine().ToLower();
            Console.WriteLine("\n\n");

            if (response == "help")
            {
                helpme = true;
            }

            while (helpme)
            {
                    helpme = CustomerHelp.StartHelpCustomer();
            }

            if (!helpme)
            {
                System.Console.WriteLine("Let's get back your order!");
            }
        }
        
    }
}