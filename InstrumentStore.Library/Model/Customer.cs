using InstrumentStore.Library.Entities;
using System;
using System.Linq;

namespace InstrumentStore.Library
{
    public class Customer
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

            Console.WriteLine("Default Store is set to Macon, Georgia");

            cont.Customers.Add(newCust);
            cont.SaveChanges();

            StartCustomer(cont);
        }

        public static Customers StartCustomer(StoreDbContext cont)
        {
            Console.WriteLine("'return'\tFor returning customer\n'new'\t\tFor new customer");
            var who = Console.ReadLine().ToLower();
            Customers customer = new Customers();
            while (who != "return" && who != "new")
            {
                Console.WriteLine("Invalid response! Please enter 'return' or 'new'");
                who = Console.ReadLine().ToLower();
            }
            if (who == "return")
            {
                customer = ReturningCustomer(cont);
            }
            else if (who == "new")
            {
                Customer.AddCustomers(cont);
            }
            return customer;
        }

        public static void CustomerOptions(StoreDbContext cont, Customers p)
        {
            Beginning:
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

                var storeInfo = cont.Stores.FirstOrDefault(s => s.StoreId == p.StoreId);

                string loca = "n";

                AfterStoreLocation:

                if (storeInfo == null)
                {
                    goto StoreLocation;
                }
                else
                {
                    Console.WriteLine($"Your current store is {storeInfo.City}, {storeInfo.State}");
            
                    Console.WriteLine("Is this store location okay? (y/n)");
                    loca = Console.ReadLine().ToLower();
                }

                StoreLocation:

                while (loca != "y" && loca != "n")
                {
                    Console.WriteLine("Please enter 'y' or 'n' to confirm store location");
                    loca = Console.ReadLine().ToLower();
                }

                if (loca == "y")
                {
                    //save changes to Customers.StoreID for the current user and then go back to the CustomerOptions(cont, person);
                    //cont.Customers.Update(cont.Customers);
                    //cont.SaveChanges();
                }
                else if (loca == "n")
                {
                    //for each store in the database, display city and state 
                    Console.WriteLine("1    Atlanta, Georgia");
                    Console.WriteLine("2    Macon, Georgia");
                    Console.WriteLine("3    Savannah, Georgia");
                    Console.WriteLine("4    Houston, Texas");
                    Console.WriteLine("5    Austin, Texas");
                    Console.WriteLine("6    Dallas, Texas");

                    var cityChoice = Int32.Parse(Console.ReadLine()) + 2;

                    while (cityChoice < 3 && cityChoice > 8)
                    {
                        Console.WriteLine("Please enter a valid value from the options above");                        
                    }
                    p.StoreId = cityChoice;
                    storeInfo = cont.Stores.FirstOrDefault(s => s.StoreId == p.StoreId);
                    Console.WriteLine($"Your store is {storeInfo.City}, {storeInfo.State}");
                    cont.SaveChanges();
                    goto AfterStoreLocation;
                }
                goto Beginning;
            }
            else if (custSelect == "order")
            {
                Console.WriteLine("Here is a list of current products for your store"); 
                var allProds = from prods in cont.Products
                               where prods.StoreId == p.StoreId
                               select prods;

                allProds.ToList();
                foreach (var pr in allProds)
                {
                    Console.WriteLine($"{ pr.Name} { pr.Price} {pr.Quantity}");
                }

                Console.WriteLine("Enter the name of a product you would like to buy");
                var wants = Console.ReadLine().ToLower();

                Products product = new Products();
                foreach (var pr in allProds)
                {
                    if(pr.Name.ToLower() == wants)
                    {
                        product = pr;
                    }
                }
                
                Console.WriteLine($"How many {wants}s would you like to buy?");
                var wantQuant = Int32.Parse(Console.ReadLine());

                while(wantQuant >= product.Quantity)
                {
                    Console.WriteLine("Please enter a valid quantity");
                }

                Console.WriteLine($"You have added {wantQuant} {wants}(s) to your cart.");

                Console.WriteLine("Would you like to proceed to checkout?(y/n)");
                var response = Console.ReadLine().ToLower();

                Orders order = new Orders();
                while (response != "y" && response != "n")
                {
                    Console.WriteLine("Please enter 'y' or 'n' to checkout!");
                    response = Console.ReadLine();
                }

                if (response == "y")
                {
                    Console.WriteLine("Lets proceed to checkout");
                    order.CustomerId = p.CustomerId;
                    order.ProductId = product.ProductId;
                    order.StoreId = p.StoreId;
                    order.Date = DateTime.Now;
                    order.Quantities = wantQuant;
                    order.TotalPrice = (wantQuant * product.Price);
                }
                else if(response == "n")
                {
                    goto Beginning;
                }

            }
            else if (custSelect == "history")
            {

                var orderHist = from hist in cont.Orders
                                where hist.CustomerId == p.CustomerId
                                select hist;

                Orders order = new Orders();
                foreach (var o in orderHist)
                {
                    Console.WriteLine($"{o.OrderId} {o.CustomerId} {o.ProductId} {o.Date} {o.Quantities} {o.TotalPrice}");
                }
            }
            goto Beginning;
        }

        public static Customers ReturningCustomer(StoreDbContext cont)
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
                Console.WriteLine($"Hey there, {custFull.FullName}!");
            }
            return custFull;
        }
    }    
}