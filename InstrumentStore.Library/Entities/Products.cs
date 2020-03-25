using System;
using System.Collections.Generic;

namespace InstrumentStore.Library.Entities
{
    public partial class Products
    {
        public Products()
        {
            ProductOrders = new HashSet<ProductOrders>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<ProductOrders> ProductOrders { get; set; }
    }
}
