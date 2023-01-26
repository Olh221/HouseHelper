using House.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace House.Domain.Services
{
    public interface IServiceService
    {
        Task<IEnumerable<Service>> GetAll();
        Task<Service> GetById(int id);
        Task Add(Service service);
        Task<IEnumerable<Service>> Update(Service newService);
        Task Delete(int id);
    }
}
