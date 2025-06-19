using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.IRepositories
{
    public interface ICustomerRepository : IRepository<Khach>
    {
        Task<bool> AddIfNotExist(Khach entity);
        Task<bool> UpdateAsync(Khach updatedEntity, string id);
    }
}