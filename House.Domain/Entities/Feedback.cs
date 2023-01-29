using System.Collections.Generic;

namespace House.Domain.Entities
{
    public class Feedback
    {
        public int ID { get; set; }
        public Supplier Supplier { get; set; }
        public int SupplierID { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
        public ICollection<SupplierOrder> SupplierOrders { get; set; }
    }
}
