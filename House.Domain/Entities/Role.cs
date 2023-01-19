using System;
using System.Collections.Generic;
using System.Text;

namespace House.Domain.Entities
{
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
    }
}
