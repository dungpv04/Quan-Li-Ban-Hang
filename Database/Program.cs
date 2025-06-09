using Database.Models;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Bogus;

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

            //// Apply migrations
            //using (var context = new AppDbContext(optionsBuilder.Options))
            //{
            //    Console.WriteLine("Applying migrations...");
            //    context.Database.Migrate();
            //    Console.WriteLine("Migrations applied successfully.");
            //}

            //var context = new AppDbContext();

            //// Clear DB trước khi thêm dữ liệu mới (nếu cần reset)
            //context.ChiTietHDNhaps.RemoveRange(context.ChiTietHDNhaps);
            //context.ChiTietHDBans.RemoveRange(context.ChiTietHDBans);
            //context.HoaDonNhaps.RemoveRange(context.HoaDonNhaps);
            //context.HoaDonBans.RemoveRange(context.HoaDonBans);
            //context.Hangs.RemoveRange(context.Hangs);
            //context.Khachs.RemoveRange(context.Khachs);
            //context.NhanViens.RemoveRange(context.NhanViens);
            //context.NhaCungCaps.RemoveRange(context.NhaCungCaps);
            //context.LoaiHangs.RemoveRange(context.LoaiHangs);
            //context.ThuongHieus.RemoveRange(context.ThuongHieus);
            //context.SaveChanges();

            //// 1. ThuongHieus
            //var thuongHieuFaker = new Faker<ThuongHieu>()
            //    .RuleFor(x => x.MaThuongHieu, f => f.Random.Guid().ToString())
            //    .RuleFor(x => x.TenThuongHieu, f => f.Company.CompanyName())
            //    .RuleFor(x => x.MoTa, f => f.Lorem.Sentence())
            //    .RuleFor(x => x.Nuoc, f => f.Address.Country())
            //    .RuleFor(x => x.Website, f => f.Internet.Url());

            //var thuongHieus = thuongHieuFaker.Generate(5);
            //context.ThuongHieus.AddRange(thuongHieus);
            //context.SaveChanges();

            //// 2. LoaiHangs
            //var loaiHangFaker = new Faker<LoaiHang>()
            //    .RuleFor(x => x.MaLoai, f => f.Random.Guid().ToString())
            //    .RuleFor(x => x.TenLoai, f => f.Commerce.Department())
            //    .RuleFor(x => x.MoTa, f => f.Lorem.Sentence());

            //var loaiHangs = loaiHangFaker.Generate(5);
            //context.LoaiHangs.AddRange(loaiHangs);
            //context.SaveChanges();

            //// 3. NhaCungCaps
            //var nccFaker = new Faker<NhaCungCap>()
            //    .RuleFor(x => x.MaNCC, f => f.Random.Guid().ToString())
            //    .RuleFor(x => x.TenNCC, f => f.Company.CompanyName())
            //    .RuleFor(x => x.DiaChi, f => f.Address.FullAddress())
            //    .RuleFor(x => x.DienThoai, f =>
            //    {
            //        var phone = f.Phone.PhoneNumber();
            //        return phone.Length > 20 ? phone.Substring(0, 20) : phone;
            //    });// đảm bảo không vượt quá 20 ký tự

            //var nccs = nccFaker.Generate(5);
            //context.NhaCungCaps.AddRange(nccs);
            //context.SaveChanges();

            //// 4. NhanViens
            //var nhanVienFaker = new Faker<NhanVien>()
            //    .RuleFor(x => x.MaNhanVien, f => f.Random.Guid().ToString())
            //    .RuleFor(x => x.TenNhanVien, f => f.Name.FullName())
            //    .RuleFor(x => x.GioiTinh, f => f.PickRandom("Nam", "Nữ"))
            //    .RuleFor(x => x.DiaChi, f => f.Address.FullAddress())
            //    .RuleFor(x => x.DienThoai, f =>
            //    {
            //        var phone = f.Phone.PhoneNumber();
            //        return phone.Length > 20 ? phone.Substring(0, 20) : phone;
            //    })
            //    .RuleFor(x => x.NgaySinh, f => f.Date.Past(30, DateTime.Today.AddYears(-18)));

            //var nhanViens = nhanVienFaker.Generate(5);
            //context.NhanViens.AddRange(nhanViens);

            //// 5. Khachs
            //var khachFaker = new Faker<Khach>()
            //    .RuleFor(x => x.MaKhach, f => f.Random.Guid().ToString())
            //    .RuleFor(x => x.TenKhach, f => f.Name.FullName())
            //    .RuleFor(x => x.DiaChi, f => f.Address.FullAddress())
            //    .RuleFor(x => x.DienThoai, f =>
            //    {
            //        var phone = f.Phone.PhoneNumber();
            //        return phone.Length > 20 ? phone.Substring(0, 20) : phone;
            //    });

            //var khachs = khachFaker.Generate(5);
            //context.Khachs.AddRange(khachs);

            //// 6. Hangs
            //var hangFaker = new Faker<Hang>()
            //    .RuleFor(x => x.MaHang, f => f.Random.Guid().ToString())
            //    .RuleFor(x => x.TenHang, f => f.Commerce.ProductName())
            //    .RuleFor(x => x.SoLuong, f => f.Random.Int(10, 200))
            //    .RuleFor(x => x.DonGiaNhap, f => f.Random.Decimal(10, 200))
            //    .RuleFor(x => x.DonGiaBan, (f, h) => h.DonGiaNhap + f.Random.Decimal(5, 100))
            //    .RuleFor(x => x.Anh, f => f.Image.PicsumUrl())
            //    .RuleFor(x => x.GhiChu, f => f.Lorem.Sentence())
            //    .RuleFor(x => x.MaLoai, f => f.PickRandom(loaiHangs).MaLoai)
            //    .RuleFor(x => x.MaNCC, f => f.PickRandom(nccs).MaNCC)
            //    .RuleFor(x => x.MaThuongHieu, f => f.PickRandom(thuongHieus).MaThuongHieu);

            //var hangs = hangFaker.Generate(10);
            //context.Hangs.AddRange(hangs);
            //context.SaveChanges();

            //// 7. HoaDonNhaps + ChiTietHDNhaps
            //var hoaDonNhapFaker = new Faker<HoaDonNhap>()
            //    .RuleFor(x => x.MaHDNhap, f => f.Random.Guid().ToString())
            //    .RuleFor(x => x.MaNCC, f => f.PickRandom(nccs).MaNCC)
            //    .RuleFor(x => x.MaNhanVien, f => f.PickRandom(nhanViens).MaNhanVien)
            //    .RuleFor(x => x.NgayNhap, f => f.Date.Recent())
            //    .RuleFor(x => x.TongTien, 0); // Cập nhật sau

            //var hoaDonNhaps = hoaDonNhapFaker.Generate(5);
            //context.HoaDonNhaps.AddRange(hoaDonNhaps);
            //context.SaveChanges();

            //var chiTietNhapList = new List<ChiTietHDNhap>();
            //var usedKeys = new HashSet<string>();
            //var faker = new Faker();

            //while (chiTietNhapList.Count < 10)
            //{
            //    var maHD = faker.PickRandom(hoaDonNhaps).MaHDNhap;
            //    var maHang = faker.PickRandom(hangs).MaHang;
            //    var key = $"{maHD}|{maHang}";

            //    if (usedKeys.Contains(key)) continue;
            //    usedKeys.Add(key);

            //    var soLuong = faker.Random.Int(1, 10);
            //    var donGia = faker.Random.Decimal(10, 200);
            //    var chietKhau = faker.Random.Decimal(0, 10);
            //    var thanhTien = (donGia * soLuong) - chietKhau;

            //    chiTietNhapList.Add(new ChiTietHDNhap
            //    {
            //        MaHDNhap = maHD,
            //        MaHang = maHang,
            //        SoLuong = soLuong,
            //        DonGia = donGia,
            //        ChietKhau = chietKhau,
            //        ThanhTien = thanhTien
            //    });
            //}

            //context.ChiTietHDNhaps.AddRange(chiTietNhapList);

            //// 8. HoaDonBans + ChiTietHDBans
            //var hoaDonBanFaker = new Faker<HoaDonBan>()
            //    .RuleFor(x => x.MaHDBan, f => f.Random.Guid().ToString())
            //    .RuleFor(x => x.MaKhach, f => f.PickRandom(khachs).MaKhach)
            //    .RuleFor(x => x.MaNhanVien, f => f.PickRandom(nhanViens).MaNhanVien)
            //    .RuleFor(x => x.NgayBan, f => f.Date.Recent())
            //    .RuleFor(x => x.TongTien, 0); // cập nhật sau

            //var hoaDonBans = hoaDonBanFaker.Generate(5);
            //context.HoaDonBans.AddRange(hoaDonBans);

            //var chiTietBanList = new List<ChiTietHDBan>();

            //while (chiTietBanList.Count < 10)
            //{
            //    var maHDBan = faker.PickRandom(hoaDonBans).MaHDBan;
            //    var maHang = faker.PickRandom(hangs).MaHang;
            //    var key = $"{maHDBan}|{maHang}";

            //    if (usedKeys.Contains(key)) continue;
            //    usedKeys.Add(key);

            //    var soLuong = faker.Random.Int(1, 5);
            //    var donGia = faker.Random.Decimal(50, 500);
            //    var giamGia = faker.Random.Decimal(0, 20);
            //    var thanhTien = (donGia * soLuong) - giamGia;

            //    chiTietBanList.Add(new ChiTietHDBan
            //    {
            //        MaHDBan = maHDBan,
            //        MaHang = maHang,
            //        SoLuong = soLuong,
            //        DonGia = donGia,
            //        GiamGia = giamGia,
            //        ThanhTien = thanhTien
            //    });
            //}

            //context.ChiTietHDBans.AddRange(chiTietBanList);


            //// 9. Cập nhật tổng tiền
            //foreach (var hd in hoaDonBans)
            //    hd.TongTien = chiTietBanList.Where(x => x.MaHDBan == hd.MaHDBan).Sum(x => x.ThanhTien);

            //foreach (var hd in hoaDonNhaps)
            //    hd.TongTien = chiTietNhapList.Where(x => x.MaHDNhap == hd.MaHDNhap).Sum(x => x.ThanhTien);

            //// Save tất cả vào DB
            //context.SaveChanges();

            //Console.WriteLine("Dữ liệu giả đã được tạo và lưu thành công.");
        }
    }
}