using System;
using System.Collections.Generic;

namespace House.Domain.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
        public ICollection<SupplierOrder> SupplierOrders { get; set; }
    }
}
