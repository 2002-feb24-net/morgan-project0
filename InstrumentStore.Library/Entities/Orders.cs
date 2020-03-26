using System;
using System.Collections.Generic;

namespace InstrumentStore.App.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            ProductOrders = new HashSet<ProductOrders>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Stores Store { get; set; }
        public virtual ICollection<ProductOrders> ProductOrders { get; set; }
    }
}
