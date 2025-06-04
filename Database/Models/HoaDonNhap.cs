using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class HoaDonNhap
    {
        [Key]
        [MaxLength(50)]
        public string MaHDNhap { get; set; }
        [MaxLength(50)]
        public string MaNhanVien { get; set; }
        [MaxLength(50)]
        public string MaNCC { get; set; }
        public DateTime? NgayNhap { get; set; }
        public decimal TongTien { get; set; }

        [ForeignKey("MaNhanVien")]
        public NhanVien NhanVien { get; set; }
        [ForeignKey("MaNCC")]
        public NhaCungCap NhaCungCap { get; set; }

        public ICollection<ChiTietHDNhap> ChiTietHDNhaps { get; set; }
    }
}