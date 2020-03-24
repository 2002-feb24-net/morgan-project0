using System;
using System.Collections.Generic;

namespace InstrumentStore.App.Entities
{
    public partial class Products
    {
        public Products()
        {
            CustomerProducts = new HashSet<CustomerProducts>();
            Orders = new HashSet<Orders>();
            ProductOrders = new HashSet<ProductOrders>();
            StoreProducts = new HashSet<StoreProducts>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<CustomerProducts> CustomerProducts { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<ProductOrders> ProductOrders { get; set; }
        public virtual ICollection<StoreProducts> StoreProducts { get; set; }
    }
}
