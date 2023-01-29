using House.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace House.Domain.Services
{
    public interface ISupplierService
    {
        Task<IEnumerable<Supplier>> GetAll();
        Task<Supplier> GetById(int id);
        Task Add(Supplier supplier);
        Task<IEnumerable<Supplier>> Update(Supplier newSupplier);
        Task Delete(int id);
    }
}
