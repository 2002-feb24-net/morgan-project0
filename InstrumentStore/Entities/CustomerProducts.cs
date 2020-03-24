using System;
using System.Collections.Generic;

namespace InstrumentStore.App.Entities
{
    public partial class CustomerProducts
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Products Product { get; set; }
    }
}
