using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class ChiTietHDNhap
    {
        [Key, Column(Order = 0)]
        [MaxLength(50)]
        public string MaHDNhap { get; set; }
        [Key, Column(Order = 1)]
        [MaxLength(50)]
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ChietKhau { get; set; }
        public decimal ThanhTien { get; set; }

        [ForeignKey("MaHDNhap")]
        public HoaDonNhap HoaDonNhap { get; set; }
        [ForeignKey("MaHang")]
        public Hang Hang { get; set; }
    }
}