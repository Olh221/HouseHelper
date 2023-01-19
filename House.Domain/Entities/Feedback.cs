using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace House.Domain.Entities
{
    public class Feedback
    {
        public int ID { get; set; }
        public Supplier Supplier { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
        public ICollection<SupplierOrder> SupplierOrders { get; set; }
    }
}
