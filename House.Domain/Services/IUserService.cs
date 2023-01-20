using House.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace House.Domain.Services
{
    public abstract class IUserServices
    {
         Task<IEnumerable<User>> GetAll();
         User GetById(int id);
         User Create(int id);
         void Add(User user);
         User Update(int id, User newUser);
         User Delete(int id);
    }
}
