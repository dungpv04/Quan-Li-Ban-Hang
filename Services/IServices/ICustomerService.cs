using Database.Models;
using Shared.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface ICustomerService
    {
        Task<bool> AddIfNotExist(Khach entity);
        Task<bool> AddAsync(Khach entity);
        Task<bool> DeleteAsync(object id);
        Task<IEnumerable<CustomerViewModel>> GetAllAsync();
        Task<Khach?> GetByIdAsync(object id);
        Task<bool> UpdateAsync(Khach entity, string id);
    }
}