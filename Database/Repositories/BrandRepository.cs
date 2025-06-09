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
    public class BrandRepository: Repository<ThuongHieu>, IBrandRepository
    {
        public BrandRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<bool> AddIfNotExist(ThuongHieu entity)
        {
            var existingEntity = await _dbSet.FirstOrDefaultAsync(e => e.MaThuongHieu == entity.MaThuongHieu || e.TenThuongHieu == entity.TenThuongHieu);
            if (existingEntity == null)
            {
                return await AddAsync(entity);
            }
            return false;
        }

        public async Task<bool> UpdateAsync(ThuongHieu updatedEntity, string id)
        {
            var entity = _context.ThuongHieus.First(x => x.MaThuongHieu == id);
            if (entity == null)
                return false;

            entity.TenThuongHieu = updatedEntity.TenThuongHieu;
            entity.Nuoc = updatedEntity.Nuoc;
            entity.Website = updatedEntity.Website;
            entity.MoTa = updatedEntity.MoTa;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
