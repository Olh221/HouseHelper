using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace House.Domain.Entities
{
    public class Supplier
    {
        public int ID { get; set; }
        public User User { get; set; }
        public Service Service { get; set; }

        public ICollection<SupplierOrder> SupplierOrders { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
