using House.Data;
using House.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppHouseHelper.Data.Interfaces;

namespace WebAppHouseHelper.Data.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly AppDBContext _context;
      
        public OrderServices(AppDBContext context)
        {
            _context = context;
        }
    }
}
