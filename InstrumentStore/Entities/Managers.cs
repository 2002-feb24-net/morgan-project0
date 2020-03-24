using System;
using System.Collections.Generic;

namespace InstrumentStore.App.Entities
{
    public partial class Managers
    {
        public Managers()
        {
            StoreManagers = new HashSet<StoreManagers>();
        }

        public int ManagerId { get; set; }
        public int StoreId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual Stores Store { get; set; }
        public virtual ICollection<StoreManagers> StoreManagers { get; set; }
    }
}
