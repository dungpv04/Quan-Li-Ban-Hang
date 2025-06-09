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
        public BrandViewModel createBrandViewModel(ThuongHieu entity)
        {
            return new BrandViewModel
            {
                MaThuongHieu = entity.MaThuongHieu,
                TenThuongHieu = entity.TenThuongHieu,
                Nuoc = entity.Nuoc,
                Website = entity.Website,
                MoTa = entity.MoTa
            };
        }

        public ProductTypeViewModel createProductTypeViewModel(LoaiHang entity)
        {
            return new ProductTypeViewModel
            {
                MaLoai = entity.MaLoai,
                TenLoai = entity.TenLoai,
                MoTa = entity.MoTa
            };
        }

        public SupplierViewModel createSupplierViewModel(NhaCungCap entity)
        {
            return new SupplierViewModel
            {
                MaNCC = entity.MaNCC,
                TenNCC = entity.TenNCC,
                DiaChi = entity.DiaChi,
                DienThoai = entity.DienThoai
            };
        }
    }
}
