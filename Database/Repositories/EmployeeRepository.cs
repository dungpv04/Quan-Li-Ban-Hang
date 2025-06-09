using Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Database.IRepositories;

namespace Database.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<NhanVien> _dbSet;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<NhanVien>();
        }

        public async Task<bool> AddAsync(NhanVien entity)
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

        public async Task<IEnumerable<NhanVien>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<NhanVien?> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(NhanVien updatedEntity, string id)
        {
            var entity = _context.NhanViens.First(x => x.MaNhanVien == id);
            if (entity == null)
                return false;

            entity.TenNhanVien = updatedEntity.TenNhanVien;
            entity.DiaChi = updatedEntity.DiaChi;
            entity.GioiTinh = updatedEntity.GioiTinh;
            entity.NgaySinh = updatedEntity.NgaySinh;
            entity.DienThoai = updatedEntity.DienThoai;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}