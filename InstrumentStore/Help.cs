using System;

namespace InstrumentStore
{
    class Help
    {
        
        public static bool StartHelp()
        {

            System.Console.WriteLine("Select an option below that best represents your issue.\n'account'\n'order'\n'product'\n'store'");
            System.Console.WriteLine("If you have no more questions, type 'done' to go back to the previous page");

            string helpResponse = System.Console.ReadLine().ToLower();

            if (helpResponse == "done")
            {
                System.Console.WriteLine("No more help needed");
                return false;
            }
            else if (helpResponse != "account" && helpResponse != "order" && helpResponse != "product" && helpResponse != "store")
            {
                System.Console.WriteLine("Sorry, I can't help you with that...");
                return true;
            }
            else
            {
                System.Console.WriteLine("Lets help you with that!");
                if (helpResponse == "account")
                {
                    AccountHelp();
                }
                else if (helpResponse == "order")
                {
                    OrderHelp();
                }
                else if (helpResponse == "product")
                {
                    ProductHelp();
                }
                else if (helpResponse == "store")
                {
                    StoreHelp();
                }
            return true;
            }
        }

        static void AccountHelp()
        {

        }

        static void OrderHelp()
        {

        }

        static void ProductHelp()
        {

        }

        static void StoreHelp()
        {

        }

    }
}