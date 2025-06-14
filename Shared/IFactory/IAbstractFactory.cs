﻿using Database.Models;
using Shared.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.IFactory
{
    public interface IAbstractFactory
    {
        ProductTypeViewModel createProductTypeViewModel(LoaiHang entity);
        BrandViewModel createBrandViewModel(ThuongHieu entity);
        SupplierViewModel createSupplierViewModel(NhaCungCap entity);
        EmployeeViewModel createEmployeeViewModel(NhanVien entity);
        ProductViewModel createProductViewModel(Hang entity);
        RevenueReportViewModel createRevenueReportViewModel(HoaDonBan hoaDonBan, ChiTietHDBan chiTiet, Hang hang, LoaiHang loaiHang, NhanVien nhanVien, Khach khach);
    }
}
