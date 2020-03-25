using System;
using System.Collections.Generic;

namespace InstrumentStore.Library.Entities
{
    public partial class ProductOrders
    {
        public int ProductOrderId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int? Quantity { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
