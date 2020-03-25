using InstrumentStore.Library.Entities;
using System;
using System.Collections.Generic;

namespace InstrumentStore.Data.Entities
{
    public partial class StoreProducts
    {
        public int StoreProduct { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int Inventory { get; set; }

        public virtual Products Product { get; set; }
        public virtual Stores Store { get; set; }
    }
}
