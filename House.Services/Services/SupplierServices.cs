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
    internal class SupplierServices : ISupplierService
    {
        private readonly AppDBContext _context;
        public SupplierServices(AppDBContext context)
        {
            _context = context;
        }

        public Task Add(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Supplier>> GetAll()
        {
            var result = await _context.Supplier.AsNoTracking().ToListAsync();
            return result;
        }

        public Task<Supplier> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Supplier>> Update(Supplier newSupplier)
        {
            var entity = await _context.Supplier.FirstOrDefaultAsync(x => x.ID == newSupplier.ID);
            entity.ID = newSupplier.ID;
            await _context.SaveChangesAsync();
            return (IEnumerable<Supplier>)entity;
        }
    }
}
