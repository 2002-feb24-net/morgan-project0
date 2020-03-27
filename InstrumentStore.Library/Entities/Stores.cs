using System;
using System.Collections.Generic;

namespace InstrumentStore.Library.Entities
{
    public partial class Stores
    {
        public Stores()
        {
            Customers = new HashSet<Customers>();
            Orders = new HashSet<Orders>();
            Products = new HashSet<Products>();
        }

        public int StoreId { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
