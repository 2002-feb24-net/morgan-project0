using InstrumentStore.Library.Entities;
using System;

namespace InstrumentStore.Library
{
    public static class Order
    {
        public static void AddOrders(StoreDbContext cont)
        {
            var newOrder = new Orders();

        }

        public static void ViewCustomerOrder(StoreDbContext cont)
        {

        }

        public static void ViewAllOrdersForStore(StoreDbContext cont)
        {

        }

        public static void StartOrder(StoreDbContext cont)
        {
/*            Console.WriteLine("Choose a product from below");

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

            while (moreStuff != "y" && moreStuff != "n")
            {
                Console.WriteLine("Please enter y or n");
            }
            if (moreStuff == "y")
            {
                Console.WriteLine("What else would you like to add to your order?");
                //add this item to the order list
            }
            else if (moreStuff == "n")
            {
                foreach(var i in result)
                {
                    Console.WriteLine();
                }
               Console.WriteLine("is this list of items correct? y/n");
                // save final order
            }*/
            
        }
    }
}