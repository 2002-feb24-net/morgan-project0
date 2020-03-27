using InstrumentStore.Library.Entities;
using System;

namespace InstrumentStore.Library
{
    class Product
    {
        public static void AddProducts(StoreDbContext cont)
        {
            var newProd = new Products();


            Console.WriteLine("Please enter some information about the product!");
            Console.Write("Product name: ");
            newProd.Name = Console.ReadLine();

            Console.Write("Product category: ");
            newProd.Type = Console.ReadLine();

            Console.Write("Brand: ");
            newProd.Brand = Console.ReadLine();

            Console.Write("Price: ");
            newProd.Price = Decimal.Parse(Console.ReadLine());

            Console.Write("Quantity ");
            newProd.Quantity = Int32.Parse(Console.ReadLine());

            cont.Products.Add(newProd);
            cont.SaveChanges();
        }

        public static void ViewProducts(StoreDbContext cont)
        {

        }
    }
}