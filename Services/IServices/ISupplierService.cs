using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Models;
using Shared.View_Models;

namespace Services.IServices
{
    public interface ISupplierService
    {
        Task<bool> AddIfNotExist(NhaCungCap entity);
        Task<bool> AddAsync(NhaCungCap entity);
        Task<bool> DeleteAsync(object id);
        Task<IEnumerable<SupplierViewModel>> GetAllAsync();
        Task<NhaCungCap?> GetByIdAsync(object id);
        Task<bool> UpdateAsync(NhaCungCap entity, string id);
    }
}
