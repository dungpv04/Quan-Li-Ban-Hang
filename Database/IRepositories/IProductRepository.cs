using Database.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.IRepositories
{
    public interface IProductRepository
    {
        Task<bool> AddAsync(Hang entity);
        Task<bool> DeleteAsync(object id);
        Task<IEnumerable<Hang>> GetAllAsync();
        Task<Hang?> GetByIdAsync(object id);
        Task<bool> UpdateAsync(Hang entity , string id);
    }
}