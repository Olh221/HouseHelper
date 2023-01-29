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
    internal class ServiceServices : IServiceService
    {
        private readonly AppDBContext _context;
        public ServiceServices(AppDBContext context)
        {
            _context = context;
        }

        public Task Add(Service service)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Service>> GetAll()
        {
            var result = await _context.Service.AsNoTracking().ToListAsync();
            return result;
        }

        public Task<Service> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Service>> Update(Service newService)
        {
            var entity = await _context.Service.FirstOrDefaultAsync(x => x.ID == newService.ID);
            entity.ID = newService.ID;
            await _context.SaveChangesAsync();
            return (IEnumerable<Service>)entity;
        }
    }
}
