using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Models;

namespace Database.IRepositories
{
    public interface IBrandRepository: IRepository<ThuongHieu>
    {
        Task<bool> AddIfNotExist(ThuongHieu entity);
        Task<bool> UpdateAsync(ThuongHieu updatedEntity, string id);
    }
}
