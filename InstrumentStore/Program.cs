using System;
using InstrumentStore.Library;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using InstrumentStore.Library.Entities;

namespace InstrumentStore.App
{
    class Program
    {
        private static readonly StoreDbContext cont = new StoreDbContext();

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our online instrument store!\n");
            var customer = Customer.StartCustomer(cont);

            Customer.CustomerOptions(cont, customer);           
        }

    }
}
