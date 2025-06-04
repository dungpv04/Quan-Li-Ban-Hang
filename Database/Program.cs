using Database.Models;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Database
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            // Build configuration to read appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Get connection string
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Set up DbContext options
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            // Apply migrations
            using (var context = new AppDbContext(optionsBuilder.Options))
            {
                Console.WriteLine("Applying migrations...");
                context.Database.Migrate();
                Console.WriteLine("Migrations applied successfully.");
            }
        }
    }
}