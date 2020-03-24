using System;
using System.Collections.Generic;

namespace InstrumentStore.App.Entities
{
    public partial class Stores
    {
        public Stores()
        {
            Customers = new HashSet<Customers>();
            Managers = new HashSet<Managers>();
            Orders = new HashSet<Orders>();
            StoreManagers = new HashSet<StoreManagers>();
            StoreProducts = new HashSet<StoreProducts>();
        }

        public int StoreId { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Managers> Managers { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<StoreManagers> StoreManagers { get; set; }
        public virtual ICollection<StoreProducts> StoreProducts { get; set; }
    }
}
