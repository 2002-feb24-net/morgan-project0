using System;
using System.Collections.Generic;

namespace InstrumentStore.Library.Entities
{
    public partial class Stores
    {
        public Stores()
        {
            Orders = new HashSet<Orders>();
        }

        public int StoreId { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
