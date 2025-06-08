using Database.Models;
using Shared.View_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IEmployeeService
    {
        Task<bool> AddAsync(NhanVien entity);
        Task<bool> DeleteAsync(object id);
        Task<IEnumerable<EmployeeViewModel>> GetAllAsync();
        Task<NhanVien?> GetByIdAsync(object id);
        Task<bool> UpdateAsync(NhanVien entity, string id);
    }
}