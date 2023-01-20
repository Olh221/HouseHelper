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
    public class UserServices : IUserServices
    {
        private readonly AppDBContext _context;
        public UserServices(AppDBContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
            throw new NotImplementedException();
        }
        public void Create(User user) 
        {
            throw new NotImplementedException();
        }
        public void Delete(User user)
        {
            throw new NotImplementedException();
        }
        public void GetById(User user)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            var result = await _context.User.ToListAsync();
            return result;
        }
    }
        // на кожну ентіті - ентіті.сервісб. метод -> , get, getbyid, create, update, delete
}
