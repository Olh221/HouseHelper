using System.Collections.Generic;

namespace House.Domain.Entities
{
    public class Supplier
    {
        public int ID { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
        public int ServiceID { get; set; }
        public Service Service { get; set; }
        public ICollection<SupplierOrder> SupplierOrders { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
