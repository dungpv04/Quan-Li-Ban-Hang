using Database.Models;
using Shared.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IProductTypeService
    {

        Task<bool> AddIfNotExist(LoaiHang entity);
        Task<bool> AddAsync(LoaiHang entity);
        Task<bool> DeleteAsync(object id);
        Task<IEnumerable<ProductTypeViewModel>> GetAllAsync();
        Task<LoaiHang?> GetByIdAsync(object id);
        Task<bool> UpdateAsync(LoaiHang entity, string id);
    }
}
