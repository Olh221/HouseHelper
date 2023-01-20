using System.Collections.Generic;

namespace House.Domain.Entities
{
    public class Service
    {
        public int ID { get; set; }
        public string ServiceName { get; set; }
        public decimal ServicePrice { get; set; }
        public string Description { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
        public ICollection<SupplierOrder> SupplierOrders { get; set; }
    }
}
