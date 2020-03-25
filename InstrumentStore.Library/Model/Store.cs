using System;
using System.Collections.Generic;
using InstrumentStore.Data.Entities;
using InstrumentStore.Library.Entities;

namespace InstrumentStore.Library
{
    public static class Store
    {
        public static void AddStores(StoreDbContext cont)
        {
            var newStore = new Stores();
            Console.WriteLine("Please enter some information about the store!");

            Console.Write("City: ");
            newStore.City = Console.ReadLine();

            Console.Write("State: ");
            newStore.State = Console.ReadLine();

            cont.Stores.Add(newStore);
            cont.SaveChanges();
        }
    }
}