using Database.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.IRepositories
{
    public interface IEmployeeRepository : IRepository<NhanVien>
    {
        Task<bool> AddAsync(NhanVien entity);
        Task<bool> DeleteAsync(object id);
        Task<IEnumerable<NhanVien>> GetAllAsync();
        Task<NhanVien?> GetByIdAsync(object id);
        Task<bool> UpdateAsync(NhanVien updatedEntity, string id);
    }
}