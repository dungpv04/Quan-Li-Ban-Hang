using Database.Models;
using Shared.View_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IProductService
    {
        Task<bool> AddAsync(Hang entity);
        Task<bool> DeleteAsync(object id);
        Task<IEnumerable<ProductViewModel>> GetAllAsync();
        
        Task<Hang?> GetByIdAsync(object id);
        Task<bool> UpdateAsync(Hang entity, string id);
        Task<IEnumerable<LoaiHang>> GetAllCategoriesAsync();
        Task<IEnumerable<ThuongHieu>> GetAllBrandsAsync();
        Task<IEnumerable<NhaCungCap>> GetAllSuppliersAsync();
    }
}