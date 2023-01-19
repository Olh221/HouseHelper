using System;
using System.Collections.Generic;
using System.Text;

namespace House.Domain.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public User User { get; set; }
        public ICollection<SupplierOrder> SupplierOrder { get; set; }
    }
}
