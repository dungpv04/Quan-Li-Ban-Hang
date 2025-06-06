using Shared.View_Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IRevenueReportService
    {
        Task<IEnumerable<RevenueReportViewModel>> GetRevenueByProductAsync(string productId, DateTime? fromDate, DateTime? toDate);
        Task<IEnumerable<RevenueReportViewModel>> GetRevenueByCategoryAsync(string categoryId, DateTime? fromDate, DateTime? toDate);
        Task<IEnumerable<RevenueReportViewModel>> GetRevenueByEmployeeAsync(string employeeId, DateTime? fromDate, DateTime? toDate);
        Task<IEnumerable<RevenueReportViewModel>> GetAllRevenueAsync(DateTime? fromDate, DateTime? toDate);
    }
}