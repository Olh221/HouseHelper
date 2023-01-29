using House.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace House.Domain.Services
{
    public interface IStatusService
    {
        Task<IEnumerable<Status>> GetAll();
        Task<Status> GetById(int id);
        Task Add(Status status);
        Task<IEnumerable<Status>> Update(Status newStatus);
        Task Delete(int id);
    }
}
