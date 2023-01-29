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
    internal class RoleServices : IRoleService
    {
        private readonly AppDBContext _context;
        public RoleServices(AppDBContext context)
        {
            _context = context;
        }

        public Task Add(Role user)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Role>> GetAll()
        {
            var result = await _context.Role.AsNoTracking().ToListAsync();
            return result;
        }

        public Task<Role> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Role>> Update(Role newRole)
        {
            var entity = await _context.Role.FirstOrDefaultAsync(x => x.ID == newRole.ID);
            entity.ID = newRole.ID;
            await _context.SaveChangesAsync();
            return (IEnumerable<Role>)entity;
        }
    }
}
