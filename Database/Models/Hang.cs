using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class Hang
    {
        [Key]
        [MaxLength(50)]
        public string MaHang { get; set; }
        [MaxLength(100)]
        public string TenHang { get; set; }
        [MaxLength(50)]
        public string MaLoai { get; set; }
        [MaxLength(50)]
        public string MaThuongHieu { get; set; }
        [MaxLength(50)]
        public string MaNCC { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal DonGiaBan { get; set; }
        [MaxLength(200)]
        public string Anh { get; set; }
        [MaxLength(200)]
        public string GhiChu { get; set; }

        [ForeignKey("MaLoai")]
        public LoaiHang LoaiHang { get; set; }
        [ForeignKey("MaThuongHieu")]
        public ThuongHieu ThuongHieu { get; set; }
        [ForeignKey("MaNCC")]
        public NhaCungCap NhaCungCap { get; set; }

        public ICollection<ChiTietHDNhap> ChiTietHDNhaps { get; set; }
        public ICollection<ChiTietHDBan> ChiTietHDBans { get; set; }
    }
}