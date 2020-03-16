using System;

namespace InstrumentStore
{
    public class CustomerHelp
    {
        
        public static bool StartHelpCustomer()
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
                    AccountHelpCustomer();
                }
                else if (helpResponse == "order")
                {
                    OrderHelpCustomer();
                }
                else if (helpResponse == "product")
                {
                    ProductHelpCustomer();
                }
                else if (helpResponse == "store")
                {
                    StoreHelpCustomer();
                }
            return true;
            }
        }

        static void AccountHelpCustomer()
        {

        }

        static void OrderHelpCustomer()
        {

        }

        static void ProductHelpCustomer()
        {

        }

        static void StoreHelpCustomer()
        {


        }

    }
}