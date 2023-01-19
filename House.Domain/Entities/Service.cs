using System;
using System.Collections.Generic;
using System.Text;

namespace House.Domain.Entities
{
    public class Service
    {
        public int ID { get; set; }
        public string ServiceName { get; set; }
        public int ServicePrice { get; set; }
        public string Description { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
    }
}
