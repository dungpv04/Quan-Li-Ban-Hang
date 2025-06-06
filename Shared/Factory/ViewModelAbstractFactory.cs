using Database.Models;
using Shared.IFactory;
using Shared.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Factory
{
    public class ViewModelAbstractFactory : IAbstractFactory
    {
        public ProductTypeViewModel createProductTypeViewModel(LoaiHang entity)
        {
            return new ProductTypeViewModel
            {
                MaLoai = entity.MaLoai,
                TenLoai = entity.TenLoai,
                MoTa = entity.MoTa
            };
        }

        public RevenueReportViewModel createRevenueReportViewModel(HoaDonBan hoaDonBan, ChiTietHDBan chiTiet, Hang hang, LoaiHang loaiHang, NhanVien nhanVien, Khach khach)
        {
            return new RevenueReportViewModel
            {
                MaHoaDon = hoaDonBan.MaHDBan,
                NgayBan = hoaDonBan.NgayBan ?? DateTime.MinValue,
                TenNhanVien = nhanVien.TenNhanVien,
                TenKhach = khach.TenKhach,
                TenHang = hang.TenHang,
                TenLoai = loaiHang.TenLoai,
                SoLuong = chiTiet.SoLuong,
                DonGia = chiTiet.DonGia,
                ThanhTien = chiTiet.ThanhTien,
                TongTien = hoaDonBan.TongTien
            };
        }

    }
}
