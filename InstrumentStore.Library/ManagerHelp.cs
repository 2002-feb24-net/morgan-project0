using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentStore.Library
{
    public class ManagerHelp
    {
        public static bool StartHelpManager()
        {

            System.Console.WriteLine("Select an option below that best represents your issue.\n'account'\n'order'\n'product'\n'store'");
            System.Console.WriteLine("'done'\tGo back to the previous page");

            string helpResponse = System.Console.ReadLine().ToLower();

            if (helpResponse == "done")
            {
                Console.WriteLine("No more help needed");
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
                    AccountHelpManager();
                }
                else if (helpResponse == "order")
                {
                    OrderHelpManager();
                }
                else if (helpResponse == "product")
                {
                    ProductHelpManager();
                }
                else if (helpResponse == "store")
                {
                    StoreHelpManager();
                }
                return true;
            }
        }

        static void AccountHelpManager()
        {

        }

        static void OrderHelpManager()
        {

        }

        static void ProductHelpManager()
        {

        }

        static void StoreHelpManager()
        {

        }
    }
}
