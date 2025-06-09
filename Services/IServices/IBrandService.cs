using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Models;
using Shared.View_Models;

namespace Services.IServices
{
    public interface IBrandService
    {
        Task<bool> AddIfNotExist(ThuongHieu entity);
        Task<bool> AddAsync(ThuongHieu entity);
        Task<bool> DeleteAsync(object id);
        Task<IEnumerable<BrandViewModel>> GetAllAsync();
        Task<ThuongHieu?> GetByIdAsync(object id);
        Task<bool> UpdateAsync(ThuongHieu entity, string id);
    }
}
