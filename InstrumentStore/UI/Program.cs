using System;
using InstrumentStore.Library;
using Microsoft.Extensions.Configuration;
using System.IO;
using InstrumentStore.Data.Entities;
using System.Linq;
using InstrumentStore.Library.Entities;
using System.Collections.Generic;

namespace InstrumentStore.App
{
    class Program
    {
        private static readonly StoreDbContext cont = new StoreDbContext();
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our online instrument store!");


#region
            Console.WriteLine("'return'\tFor returning customer\n'new'\t\tFor new customer");
            var who = Console.ReadLine().ToLower();

            while (who != "return" && who != "new")
            {
                Console.WriteLine("Invalid response! Please enter 'return' or 'new'");
                who = Console.ReadLine().ToLower();
            }
            if (who == "return")
            {
                Console.WriteLine("Welcome back!\nWhat is your first name?");
                var tempName1 = Console.ReadLine();

                var retUserF = from Customer in cont.Customers
                              where Customer.FirstName == tempName1
                              select (Customer);

                var custNameF = cont.Customers.FirstOrDefault(c => c.LastName == tempName1);

                Console.WriteLine("What is your last name?");
                var tempName2 = Console.ReadLine();

                var retUserL = from Customer in cont.Customers
                              where Customer.LastName == tempName2
                              select (Customer.LastName);

                var custNameL = cont.Customers.FirstOrDefault(c => c.LastName == tempName2);

                if (custNameF != null && custNameL != null)
                {
                    foreach (var item in retUserF)
                    {
                        Console.WriteLine(item.FirstName);                       
                    }
                }


                // run a query to see if the first and last name already exist in the database and compare it to this one
                // I can only figure out how to compare it to the first name and not first AND last
            }
            else if (who == "new")
            {
                Customer.AddCustomers(cont);
            }
#endregion

#region
            Console.WriteLine("Choose one of the stores below to order from or 'add' to add a new store");

            List<Stores> allStores = cont.Stores.ToList();

            foreach (var items in allStores)
            {
                Console.WriteLine(items.City +"\t"+ items.State);
            }

            var chosenStore = Console.ReadLine().ToLower();

            if (chosenStore == "add")
                {
                    Store.AddStores(cont);
                }
                else if (chosenStore != null)
                {
                                       
                    // use the store that matched as the current store
                }
                else
                {
                    Console.WriteLine("I'm sorry, that store does not exist");
                }
#endregion

            Console.WriteLine("Choose a product from below");

            List<Products> storeProducts = cont.Products.ToList();
        
            foreach (var i in storeProducts)
            {
                Console.WriteLine(i.Name);
            }
            //list all products for this specific store
            var chosenProduct = Console.ReadLine().ToLower();

            Console.WriteLine($"How many {chosenProduct}s would you like to buy");
            var tempQuant = Console.ReadLine();
            Console.WriteLine($"You have selected {tempQuant} {chosenProduct}(s)");

            Console.WriteLine("Would you like to add anything else to this order? y/n");
            var moreStuff = Console.ReadLine().ToLower();

            while(moreStuff != "y" && moreStuff != "n")
            {
                Console.WriteLine("Please enter y or n");
            }
            if(moreStuff == "y")
            {
                Console.WriteLine("What else would you like to add to your order?");
                //add this item to the order list
            }
            else if(moreStuff == "n")
            {
                /*foreach(var i in result)
                {
                    Console.WriteLine();
                }*/
                Console.WriteLine("is this list of items correct? y/n");
                // save final order
            }
        }

    }
}
