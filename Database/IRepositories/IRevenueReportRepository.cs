using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.IRepositories
{
    public interface IRevenueReportRepository : IRepository<RevenueReport>
    {
        Task<IEnumerable<dynamic>> GetRawRevenueDataAsync(DateTime? fromDate, DateTime? toDate);
        Task<IEnumerable<dynamic>> GetRawRevenueDataByProductAsync(string productId, DateTime? fromDate, DateTime? toDate);
        Task<IEnumerable<dynamic>> GetRawRevenueDataByCategoryAsync(string categoryId, DateTime? fromDate, DateTime? toDate);
        Task<IEnumerable<dynamic>> GetRawRevenueDataByEmployeeAsync(string employeeId, DateTime? fromDate, DateTime? toDate);
    }
}
