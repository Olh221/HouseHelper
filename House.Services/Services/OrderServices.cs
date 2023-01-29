using House.Data;
using House.Domain.Entities;
using House.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House.Services.Services
{
    public class OrderServices : IOrderService
    {
        private readonly AppDBContext _context;
        public OrderServices(AppDBContext context)
        {
            _context = context;
        }

        public Task Add(Order order)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            var result = await _context.Order.AsNoTracking().ToListAsync();
            return result;
        }

        public Task<Order> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> Update(Order newOrder)
        {
            var entity = await _context.Order.FirstOrDefaultAsync(x => x.ID == newOrder.ID);
            entity.ID = newOrder.ID;
            await _context.SaveChangesAsync();
            return (IEnumerable<Order>)entity;
        }
    }
}
