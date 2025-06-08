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

        public EmployeeViewModel createEmployeeViewModel(NhanVien entity)
        {
            return new EmployeeViewModel
            {
                MaNhanVien = entity.MaNhanVien,
                TenNhanVien = entity.TenNhanVien,
                DiaChi = entity.DiaChi,
                GioiTinh = entity.GioiTinh,
                NgaySinh = entity.NgaySinh,
                DienThoai = entity.DienThoai
            };
        }

        public ProductViewModel createProductViewModel(Hang entity)
        {
            return new ProductViewModel
            {
                MaHang = entity.MaHang,
                TenHang = entity.TenHang,
                TenLoai = entity.LoaiHang?.TenLoai,
                TenThuongHieu = entity.ThuongHieu?.TenThuongHieu,
                TenNCC = entity.NhaCungCap?.TenNCC,
                SoLuong = entity.SoLuong,
                DonGiaNhap = entity.DonGiaNhap,
                DonGiaBan = entity.DonGiaBan,
                Anh = entity.Anh,
                GhiChu = entity.GhiChu
            };
        }
    }
}
