using House.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace House.Domain.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<Role>> GetAll();
        Task<Role> GetById(int id);
        Task Add(Role role);
        Task<IEnumerable<Role>> Update(Role newRole);
        Task Delete(int id);
    }
}
