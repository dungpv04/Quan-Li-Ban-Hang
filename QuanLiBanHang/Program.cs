using Database.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using Shared;
using System;
using UI;
using UI.InvoiceScreen;
using UI.ReportScreen;
namespace QuanLiBanHang
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // Đăng ký tất cả services
            services.AddDatabase();
            services.AddServices();
            services.AddShared();
            services.AddScoped<MainForm>();
            services.AddScoped<ProductTypeScreen>();
            services.AddScoped<ProductScreen>();
            services.AddScoped<SupplierScreen>();
            services.AddScoped<EmployeeScreen>();
            services.AddScoped<CustomerScreen>();
            services.AddScoped<BrandScreen>();
            services.AddScoped<ImportInvoiceScreen>();
            services.AddScoped<ExportInvoiceScreen>();
            services.AddScoped<RevenueReportScreen>();

            var serviceProvider = services.BuildServiceProvider();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var mainForm = serviceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }
    }
}