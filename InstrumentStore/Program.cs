using System;
using InstrumentStore.App.Entities;
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
                Managers.ManagerOptions();
            }
            else if(whoIsUsing == "customer")
            {
                Customers.CustomerOptions();
            }
        }
    }
}
