using House.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace House.Domain.Services
{
    public interface ISupplierOrderService
    {
        Task<IEnumerable<SupplierOrder>> GetAll();
        Task<SupplierOrder> GetById(int id);
        Task Add(SupplierOrder supplierOrder);
        Task<IEnumerable<SupplierOrder>> Update(SupplierOrder newSupplierOrder);
        Task Delete(int id);
    }
}
