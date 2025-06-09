using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Models;

namespace Database.IRepositories
{
    public interface ISupplierRepository: IRepository<NhaCungCap>
    {
        Task<bool> AddIfNotExist(NhaCungCap entity);
        Task<bool> UpdateAsync(NhaCungCap updatedEntity, string id);
    }
}
