using Database.IRepositories;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories
{
    public class CustomerRepository : Repository<Khach>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<bool> AddIfNotExist(Khach entity)
        {
            var existingEntity = await _dbSet.FirstOrDefaultAsync(e => e.MaKhach == entity.MaKhach);
            if (existingEntity == null)
            {
                return await AddAsync(entity);
            }

            return false;
        }

        public async Task<bool> UpdateAsync(Khach updatedEntity, string id)
        {
            var entity = _context.Khachs.First(x => x.MaKhach == id);
            if (entity == null)
                return false;

            entity.TenKhach = updatedEntity.TenKhach;
            entity.DiaChi = updatedEntity.DiaChi;
            entity.DienThoai = updatedEntity.DienThoai;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}