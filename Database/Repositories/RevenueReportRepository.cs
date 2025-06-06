using Database.IRepositories;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Repositories
{
    public class RevenueReportRepository : Repository<RevenueReport>, IRevenueReportRepository
    {
        public RevenueReportRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<dynamic>> GetRawRevenueDataAsync(DateTime? fromDate, DateTime? toDate)
        {
            var query = from hdb in _context.HoaDonBans
                        join ct in _context.ChiTietHDBans on hdb.MaHDBan equals ct.MaHDBan
                        join h in _context.Hangs on ct.MaHang equals h.MaHang
                        join lh in _context.LoaiHangs on h.MaLoai equals lh.MaLoai
                        join nv in _context.NhanViens on hdb.MaNhanVien equals nv.MaNhanVien
                        join k in _context.Khachs on hdb.MaKhach equals k.MaKhach
                        where (!fromDate.HasValue || hdb.NgayBan >= fromDate) &&
                              (!toDate.HasValue || hdb.NgayBan <= toDate)
                        select new
                        {
                            HoaDonBan = hdb,
                            ChiTiet = ct,
                            Hang = h,
                            LoaiHang = lh,
                            NhanVien = nv,
                            Khach = k
                        };

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<dynamic>> GetRawRevenueDataByProductAsync(string productId, DateTime? fromDate, DateTime? toDate)
        {
            var query = from hdb in _context.HoaDonBans
                        join ct in _context.ChiTietHDBans on hdb.MaHDBan equals ct.MaHDBan
                        join h in _context.Hangs on ct.MaHang equals h.MaHang
                        join lh in _context.LoaiHangs on h.MaLoai equals lh.MaLoai
                        join nv in _context.NhanViens on hdb.MaNhanVien equals nv.MaNhanVien
                        join k in _context.Khachs on hdb.MaKhach equals k.MaKhach
                        where h.MaHang == productId &&
                              (!fromDate.HasValue || hdb.NgayBan >= fromDate) &&
                              (!toDate.HasValue || hdb.NgayBan <= toDate)
                        select new
                        {
                            HoaDonBan = hdb,
                            ChiTiet = ct,
                            Hang = h,
                            LoaiHang = lh,
                            NhanVien = nv,
                            Khach = k
                        };

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<dynamic>> GetRawRevenueDataByCategoryAsync(string categoryId, DateTime? fromDate, DateTime? toDate)
        {
            var query = from hdb in _context.HoaDonBans
                        join ct in _context.ChiTietHDBans on hdb.MaHDBan equals ct.MaHDBan
                        join h in _context.Hangs on ct.MaHang equals h.MaHang
                        join lh in _context.LoaiHangs on h.MaLoai equals lh.MaLoai
                        join nv in _context.NhanViens on hdb.MaNhanVien equals nv.MaNhanVien
                        join k in _context.Khachs on hdb.MaKhach equals k.MaKhach
                        where lh.MaLoai == categoryId &&
                              (!fromDate.HasValue || hdb.NgayBan >= fromDate) &&
                              (!toDate.HasValue || hdb.NgayBan <= toDate)
                        select new
                        {
                            HoaDonBan = hdb,
                            ChiTiet = ct,
                            Hang = h,
                            LoaiHang = lh,
                            NhanVien = nv,
                            Khach = k
                        };

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<dynamic>> GetRawRevenueDataByEmployeeAsync(string employeeId, DateTime? fromDate, DateTime? toDate)
        {
            var query = from hdb in _context.HoaDonBans
                        join ct in _context.ChiTietHDBans on hdb.MaHDBan equals ct.MaHDBan
                        join h in _context.Hangs on ct.MaHang equals h.MaHang
                        join lh in _context.LoaiHangs on h.MaLoai equals lh.MaLoai
                        join nv in _context.NhanViens on hdb.MaNhanVien equals nv.MaNhanVien
                        join k in _context.Khachs on hdb.MaKhach equals k.MaKhach
                        where nv.MaNhanVien == employeeId &&
                              (!fromDate.HasValue || hdb.NgayBan >= fromDate) &&
                              (!toDate.HasValue || hdb.NgayBan <= toDate)
                        select new
                        {
                            HoaDonBan = hdb,
                            ChiTiet = ct,
                            Hang = h,
                            LoaiHang = lh,
                            NhanVien = nv,
                            Khach = k
                        };

            return await query.ToListAsync();
        }
    }
}