using Database.IRepositories;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Hang> _dbSet;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<Hang>();
        }

        public async Task<bool> AddAsync(Hang entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(object id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) return false;
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Hang>> GetAllAsync()
        {
            return await _dbSet
                .Include(h => h.LoaiHang)
                .Include(h => h.ThuongHieu)
                .Include(h => h.NhaCungCap)
                .ToListAsync();
        }

        public async Task<Hang?> GetByIdAsync(object id)
        {
            return await _dbSet
                .Include(h => h.LoaiHang)
                .Include(h => h.ThuongHieu)
                .Include(h => h.NhaCungCap)
                .FirstOrDefaultAsync(h => h.MaHang == id.ToString());
        }

        

        public async Task<bool> UpdateAsync(Hang updatedEntity, string id)
        {
            var entity = _context.Hangs.First(x => x.MaHang == id);
            if (entity == null)
                return false;

            entity.TenHang = updatedEntity.TenHang;
            entity.MaLoai = updatedEntity.MaLoai;         
            entity.MaThuongHieu = updatedEntity.MaThuongHieu; 
            entity.MaNCC = updatedEntity.MaNCC;
            entity.SoLuong = updatedEntity.SoLuong;
            entity.DonGiaNhap = updatedEntity.DonGiaNhap;
            entity.DonGiaBan = updatedEntity.DonGiaBan;
            entity.Anh = updatedEntity.Anh;
            entity.GhiChu = updatedEntity.GhiChu;


            await _context.SaveChangesAsync();
            return true;
        }
    }
}