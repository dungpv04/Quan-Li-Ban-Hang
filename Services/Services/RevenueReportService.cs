using Database.IRepositories;
using Database.Models;
using Services.IServices;
using Shared.IFactory;
using Shared.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace Services.Services
{
    public class RevenueReportService : IRevenueReportService
    {
        private readonly IRevenueReportRepository _repository;
        private readonly IAbstractFactory _abstractFactory;

        public RevenueReportService(IRevenueReportRepository repository, IAbstractFactory abstractFactory)
        {
            _repository = repository;
            _abstractFactory = abstractFactory;
        }

        public async Task<IEnumerable<RevenueReportViewModel>> GetRevenueByProductAsync(string productId, DateTime? fromDate, DateTime? toDate)
        {
            var rawData = await _repository.GetRawRevenueDataByProductAsync(productId, fromDate, toDate);
            return ConvertToViewModels(rawData);
        }

        public async Task<IEnumerable<RevenueReportViewModel>> GetRevenueByCategoryAsync(string categoryId, DateTime? fromDate, DateTime? toDate)
        {
            var rawData = await _repository.GetRawRevenueDataByCategoryAsync(categoryId, fromDate, toDate);
            return ConvertToViewModels(rawData);
        }

        public async Task<IEnumerable<RevenueReportViewModel>> GetRevenueByEmployeeAsync(string employeeId, DateTime? fromDate, DateTime? toDate)
        {
            var rawData = await _repository.GetRawRevenueDataByEmployeeAsync(employeeId, fromDate, toDate);
            return ConvertToViewModels(rawData);
        }

        public async Task<IEnumerable<RevenueReportViewModel>> GetAllRevenueAsync(DateTime? fromDate, DateTime? toDate)
        {
            var rawData = await _repository.GetRawRevenueDataAsync(fromDate, toDate);
            return ConvertToViewModels(rawData);
        }

        private IEnumerable<RevenueReportViewModel> ConvertToViewModels(IEnumerable<dynamic> rawData)
        {
            return rawData.Select(x =>
            {
                var type = x.GetType();
                var hoaDonBan = (HoaDonBan)type.GetProperty("HoaDonBan").GetValue(x);
                var chiTiet = (ChiTietHDBan)type.GetProperty("ChiTiet").GetValue(x);
                var hang = (Hang)type.GetProperty("Hang").GetValue(x);
                var loaiHang = (LoaiHang)type.GetProperty("LoaiHang").GetValue(x);
                var nhanVien = (NhanVien)type.GetProperty("NhanVien").GetValue(x);
                var khach = (Khach)type.GetProperty("Khach").GetValue(x);

                return _abstractFactory.createRevenueReportViewModel(
                    hoaDonBan, chiTiet, hang, loaiHang, nhanVien, khach
                );
            }).ToList();
        }

    }
}