using System.Collections.Generic;


namespace House.Domain.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public Role Role{ get; set; }
        public int RoleID { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
    }
}
