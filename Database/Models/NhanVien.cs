using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class NhanVien
    {
        [Key]
        [MaxLength(50)]
        public string MaNhanVien { get; set; }
        [MaxLength(100)]
        public string TenNhanVien { get; set; }
        [MaxLength(200)]
        public string DiaChi { get; set; }
        [MaxLength(10)]
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        [MaxLength(20)]
        public string DienThoai { get; set; }

        public ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
        public ICollection<HoaDonBan> HoaDonBans { get; set; }
    }
}