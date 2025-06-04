using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class ChiTietHDBan
    {
        [Key, Column(Order = 0)]
        [MaxLength(50)]
        public string MaHDBan { get; set; }
        [Key, Column(Order = 1)]
        [MaxLength(50)]
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiamGia { get; set; }
        public decimal ThanhTien { get; set; }

        [ForeignKey("MaHDBan")]
        public HoaDonBan HoaDonBan { get; set; }
        [ForeignKey("MaHang")]
        public Hang Hang { get; set; }
    }
}