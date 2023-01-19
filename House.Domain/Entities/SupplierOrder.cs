using System;
using System.Collections.Generic;
using System.Text;

namespace House.Domain.Entities
{
    public class SupplierOrder
    {
        public int ID { get; set; }
        public int OrderPrice { get; set; }
        public Service Service { get; set; }
        public Order Order { get; set; }
        public Feedback Feedback { get; set; }
        public Status Status { get; set; }
    }
}
