using House.Data;
using House.Domain.Entities;
using House.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace House.Services.Services
{
    internal class SupplierOrderServices : ISupplierOrderService
    {
        private readonly AppDBContext _context;
        public SupplierOrderServices(AppDBContext context)
        {
            _context = context;
        }

        public Task Add(SupplierOrder supplierOrder)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SupplierOrder>> GetAll()
        {
            var result = await _context.SupplierOrder.AsNoTracking().ToListAsync();
            return result;
        }

        public Task<SupplierOrder> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SupplierOrder>> Update(SupplierOrder newSupplierOrder)
        {
            var entity = await _context.SupplierOrder.FirstOrDefaultAsync(x => x.ID == newSupplierOrder.ID);
            entity.ID = newSupplierOrder.ID;
            await _context.SaveChangesAsync();
            return (IEnumerable<SupplierOrder>)entity;
        }
    }
}
