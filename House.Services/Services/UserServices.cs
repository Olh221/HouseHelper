using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using House.Data;
using House.Domain.Entities;
using House.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace House.Services.Services
{
    public class UserServices : IUserService
    {
        private readonly AppDBContext _context;
        public UserServices(AppDBContext context)
        {
            _context = context;
        }

        public Task Add(User user)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var result = await _context.User.AsNoTracking().ToListAsync();
            return result;
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> Update(User newUser)
        {
            var entity = await _context.User.FirstOrDefaultAsync(x => x.ID == newUser.ID);
            entity.ID = newUser.ID;
            await _context.SaveChangesAsync();
            return (IEnumerable<User>)entity;
        }
    }
}
