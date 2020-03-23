using System;
using InstrumentStore.Library;
namespace InstrumentStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to our online instrument store!\n\n'manager'\tFor use by managers.\n'customer'For use by customers.");
            string whoIsUsing = Console.ReadLine().ToLower();

            if (whoIsUsing == "manager")
            {
                //ManagerOptions();
            }
            else if(whoIsUsing == "customer")
            {
                //CustomerOptions();
            }



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
                if (whoIsUsing == "customer")
                {
                    helpme = CustomerHelp.StartHelpCustomer();
                }
                else if (whoIsUsing == "manager")
                {
                    helpme = ManagerHelp.StartHelpManager();
                }
            }

            if (!helpme)
            {
                System.Console.WriteLine("Let's get back your order!");

            }
        }
    }
}
