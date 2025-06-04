using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Database.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Parameterless constructor for design-time tools
        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<LoaiHang> LoaiHangs { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<Khach> Khachs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Hang> Hangs { get; set; }
        public DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public DbSet<HoaDonBan> HoaDonBans { get; set; }
        public DbSet<ChiTietHDNhap> ChiTietHDNhaps { get; set; }
        public DbSet<ChiTietHDBan> ChiTietHDBans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite keys and key lengths for detail tables
            modelBuilder.Entity<ChiTietHDNhap>()
                .HasKey(c => new { c.MaHDNhap, c.MaHang });
            modelBuilder.Entity<ChiTietHDNhap>()
                .Property(c => c.MaHDNhap).HasMaxLength(50);
            modelBuilder.Entity<ChiTietHDNhap>()
                .Property(c => c.MaHang).HasMaxLength(50);

            modelBuilder.Entity<ChiTietHDBan>()
                .HasKey(c => new { c.MaHDBan, c.MaHang });
            modelBuilder.Entity<ChiTietHDBan>()
                .Property(c => c.MaHDBan).HasMaxLength(50);
            modelBuilder.Entity<ChiTietHDBan>()
                .Property(c => c.MaHang).HasMaxLength(50);

            // Cascade only from parent to detail, restrict all others to avoid multiple cascade paths
            modelBuilder.Entity<ChiTietHDNhap>()
                .HasOne(c => c.HoaDonNhap)
                .WithMany(h => h.ChiTietHDNhaps)
                .HasForeignKey(c => c.MaHDNhap)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChiTietHDNhap>()
                .HasOne(c => c.Hang)
                .WithMany(h => h.ChiTietHDNhaps)
                .HasForeignKey(c => c.MaHang)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChiTietHDBan>()
                .HasOne(c => c.HoaDonBan)
                .WithMany(h => h.ChiTietHDBans)
                .HasForeignKey(c => c.MaHDBan)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChiTietHDBan>()
                .HasOne(c => c.Hang)
                .WithMany(h => h.ChiTietHDBans)
                .HasForeignKey(c => c.MaHang)
                .OnDelete(DeleteBehavior.Restrict);

            // Hang: Restrict all relationships to avoid cascade cycles
            modelBuilder.Entity<Hang>()
                .Property(h => h.MaHang).HasMaxLength(50);
            modelBuilder.Entity<Hang>()
                .HasOne(h => h.LoaiHang)
                .WithMany(l => l.Hangs)
                .HasForeignKey(h => h.MaLoai)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Hang>()
                .HasOne(h => h.ThuongHieu)
                .WithMany(t => t.Hangs)
                .HasForeignKey(h => h.MaThuongHieu)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Hang>()
                .HasOne(h => h.NhaCungCap)
                .WithMany(ncc => ncc.Hangs)
                .HasForeignKey(h => h.MaNCC)
                .OnDelete(DeleteBehavior.Restrict);

            // HoaDonNhap: Restrict delete for NhanVien, NhaCungCap
            modelBuilder.Entity<HoaDonNhap>()
                .HasOne(h => h.NhanVien)
                .WithMany(nv => nv.HoaDonNhaps)
                .HasForeignKey(h => h.MaNhanVien)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDonNhap>()
                .HasOne(h => h.NhaCungCap)
                .WithMany(ncc => ncc.HoaDonNhaps)
                .HasForeignKey(h => h.MaNCC)
                .OnDelete(DeleteBehavior.Restrict);

            // HoaDonBan: Restrict delete for NhanVien, Khach
            modelBuilder.Entity<HoaDonBan>()
                .HasOne(h => h.NhanVien)
                .WithMany(nv => nv.HoaDonBans)
                .HasForeignKey(h => h.MaNhanVien)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDonBan>()
                .HasOne(h => h.Khach)
                .WithMany(kh => kh.HoaDonBans)
                .HasForeignKey(h => h.MaKhach)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}