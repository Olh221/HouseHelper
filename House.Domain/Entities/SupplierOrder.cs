namespace House.Domain.Entities
{
    public class SupplierOrder
    {
        public int ID { get; set; }
        public decimal OrderPrice { get; set; }
        public Service Service { get; set; }
        public Order Order { get; set; }
        public Feedback Feedback { get; set; }
        public Status Status { get; set; }
        public int OrderID { get; set; }
        public int FeedbackID { get; set; }
        public int StatusID { get; set; }
        public int ServiceID { get; set; }
    }
}
