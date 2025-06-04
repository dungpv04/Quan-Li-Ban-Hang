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
    public class ProductTypeRepository : Repository<LoaiHang>, IProductTypeRepository
    {
        public ProductTypeRepository(AppDbContext context) : base(context) { }

        public async Task<bool> AddIfNotExist(LoaiHang entity)
        {
            var existingEntity = await _dbSet.FirstOrDefaultAsync(e => e.MaLoai == entity.MaLoai);
            if (existingEntity == null)
            {
                return await AddAsync(entity);
            }
            return false;
        }

        public async Task<bool> UpdateAsync(LoaiHang updatedEntity, string id)
        {
            var entity = _context.LoaiHangs.First(x => x.MaLoai == id);
            if (entity == null)
                return false;

            entity.TenLoai = updatedEntity.TenLoai;
            entity.MoTa = updatedEntity.MoTa;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
