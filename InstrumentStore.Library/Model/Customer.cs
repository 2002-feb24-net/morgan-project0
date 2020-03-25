using System;
using InstrumentStore.Library.Entities;

namespace InstrumentStore.Library
{
    public static class Customer
    {
        public static void AddCustomers(StoreDbContext cont)
        {
            var newCust = new Customers();
            Console.WriteLine("Please enter some information about you!");
            Console.Write("[Required] First name: ");
            newCust.FirstName = Console.ReadLine();

            Console.Write("[Required] Last name: ");
            newCust.LastName = Console.ReadLine();

            Console.Write("Phone: ");
            newCust.Phone = Console.ReadLine();

            Console.Write("Email: ");
            newCust.Email = Console.ReadLine();

            Console.Write("Street: ");
            newCust.Address = Console.ReadLine();

            Console.Write("City: ");
            newCust.City = Console.ReadLine();

            Console.Write("State: ");
            newCust.State = Console.ReadLine();

            cont.Customers.Add(newCust);
            cont.SaveChanges();
        }
    }
}