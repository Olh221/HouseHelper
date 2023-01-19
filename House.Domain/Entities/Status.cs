using System;
using System.Collections.Generic;
using System.Text;

namespace House.Domain.Entities
{
    public class Status
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SupplierOrder SupplierOrder { get; set; }
    }
}
