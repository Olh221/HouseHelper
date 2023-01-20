using System.Collections.Generic;

namespace House.Domain.Entities
{
    public class Status
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<SupplierOrder> SupplierOrders { get; set; }
    }
}
