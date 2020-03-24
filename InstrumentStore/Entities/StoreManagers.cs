using System;
using System.Collections.Generic;

namespace InstrumentStore.App.Entities
{
    public partial class StoreManagers
    {
        public int StoreManagersId { get; set; }
        public int StoreId { get; set; }
        public int ManagerId { get; set; }

        public virtual Managers Manager { get; set; }
        public virtual Stores Store { get; set; }
    }
}
