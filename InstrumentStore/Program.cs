using System;
using InstrumentStore.Library;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using InstrumentStore.App.Entities;

namespace InstrumentStore.App
{
    class Program
    {
        private static readonly StoreDbContext cont = new StoreDbContext();

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our online instrument store!");
            Customer.StartCustomer(cont);

            Console.WriteLine(Customer._fullName);

            Customer.CustomerOptions(cont, fullName);






















            /*Console.WriteLine("Choose one of the stores below to order from or 'add' to add a new store");

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
                *//*foreach(var i in result)
                {
                    Console.WriteLine();
                }*//*
                Console.WriteLine("is this list of items correct? y/n");
                // save final order
            }*/
        }




















    }
}
