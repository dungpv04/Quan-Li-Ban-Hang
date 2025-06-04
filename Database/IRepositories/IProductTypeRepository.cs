using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.IRepositories
{
    public interface IProductTypeRepository: IRepository<LoaiHang>
    {
        Task<bool> AddIfNotExist(LoaiHang entity);
        Task<bool> UpdateAsync(LoaiHang updatedEntity, string id);
    }
}
