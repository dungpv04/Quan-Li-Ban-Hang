using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class HoaDonBan
    {
        [Key]
        [MaxLength(50)]
        public string MaHDBan { get; set; }
        [MaxLength(50)]
        public string MaNhanVien { get; set; }
        [MaxLength(50)]
        public string MaKhach { get; set; }
        public DateTime? NgayBan { get; set; }
        public decimal TongTien { get; set; }

        [ForeignKey("MaNhanVien")]
        public NhanVien NhanVien { get; set; }
        [ForeignKey("MaKhach")]
        public Khach Khach { get; set; }

        public ICollection<ChiTietHDBan> ChiTietHDBans { get; set; }
    }
}