using System;
using System.Linq;
using InstrumentStore.App.Entities;

namespace InstrumentStore.Library
{
    public class Customer
    {
        public static string _fullName { get; set; }
        //add a private property. We are going to set it in the customer and retreive it in the program
        //need to SET this from the return value from ReturningCustomer()


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

            StartCustomer(cont);
        }

        public static void StartCustomer(StoreDbContext cont)
        {
            Console.WriteLine("'return'\tFor returning customer\n'new'\t\tFor new customer");
            var who = Console.ReadLine().ToLower();

            while (who != "return" && who != "new")
            {
                Console.WriteLine("Invalid response! Please enter 'return' or 'new'");
                who = Console.ReadLine().ToLower();
            }
            if (who == "return")
            {
                ReturningCustomer(cont);
            }
            else if (who == "new")
            {
                Customer.AddCustomers(cont);
            }
        }

        public static void CustomerOptions(StoreDbContext cont, string wholeName)
        {

            Console.WriteLine("'store'\t\tTo view or change your store location\n" +
                              "'order'\t\tOrder products from your default store\n" +
                              "'history'\tSee the history of all your orders");
            var custSelect = Console.ReadLine().ToLower();

            while (custSelect != "store" && custSelect != "order" && custSelect != "history")
            {
                Console.WriteLine("Please enter a correct response!");
            }

            if (custSelect == "store")
            {
/*                var custList = from Customers in cont.Customers
                               where Customers.FullName == wholeName
                               select (Customers);

                var storeList = from Stores in cont.Stores
                                select (Stores);

                var custStore = from Customers in cont.Customers join Stores in cont.Stores on Customers.StoreId equals Stores.StoreId
                                select (Stores);


                                var custFull = cont.Customers.FirstOrDefault(s => s.City == custStore);

                                Console.WriteLine($"Your current store is {custStore}");*/
            }
            else if (custSelect == "order")
            {

            }
            else if (custSelect == "history")
            {
                // display all orders with 
            }
        }

        public static void SetCustomerStore(StoreDbContext cont)
        {

        }

        public static void ViewAllCustomers(StoreDbContext cont)
        {

        }
        public static string ReturningCustomer(StoreDbContext cont)
        {

            Console.WriteLine("Welcome back!\nWhat is your first and last name?");
            var tempName = Console.ReadLine();

            var retUserFull = from Customer in cont.Customers
                              where Customer.FullName == tempName
                              select (Customer);

            var custFull = cont.Customers.FirstOrDefault(c => c.FullName == tempName);


            if (custFull == null)
            {
                Console.WriteLine("We don't see you account in our database...");
                Customer.StartCustomer(cont);

            }
            else if (custFull != null)
            {
                Console.WriteLine($"Hey there, {tempName}!");
            }
            return tempName;
        }
    }    
}