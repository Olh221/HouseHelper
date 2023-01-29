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
    internal class StatusServices : IStatusService
    {
        private readonly AppDBContext _context;
        public StatusServices(AppDBContext context)
        {
            _context = context;
        }

        public Task Add(Status status)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Status>> GetAll()
        {
            var result = await _context.Status.AsNoTracking().ToListAsync();
            return result;
        }

        public Task<Status> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Status>> Update(Status newStatus)
        {
            var entity = await _context.Status.FirstOrDefaultAsync(x => x.ID == newStatus.ID);
            entity.ID = newStatus.ID;
            await _context.SaveChangesAsync();
            return (IEnumerable<Status>)entity;
        }
    }
}
