using InstrumentStore.Library.Entities;
using System;
using System.Collections.Generic;

namespace InstrumentStore.Data.Entities
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
