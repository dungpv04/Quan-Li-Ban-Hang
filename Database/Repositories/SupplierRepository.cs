using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.IRepositories;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    class SupplierRepository : Repository<NhaCungCap>, ISupplierRepository
    {
        public SupplierRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<bool> AddIfNotExist(NhaCungCap entity)
        {
            var existingEntity = await _dbSet.FirstOrDefaultAsync(e => e.MaNCC == entity.MaNCC || e.DienThoai == entity.DienThoai);
            if (existingEntity == null)
            {
                return await AddAsync(entity);
            }
            return false;
        }

        public async Task<bool> UpdateAsync(NhaCungCap updatedEntity, string id)
        {
            var entity = _context.NhaCungCaps.First(x => x.MaNCC == id);
            if (entity == null)
                return false;

            entity.TenNCC = updatedEntity.TenNCC;
            entity.DiaChi = updatedEntity.DiaChi;
            entity.DienThoai = updatedEntity.DienThoai;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
