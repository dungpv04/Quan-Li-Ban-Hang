using System;
using System.ComponentModel.DataAnnotations;

namespace Shared.View_Models
{
    public class ProductViewModel
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "M� h�ng")]
        public string MaHang { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "T�n h�ng")]
        public string TenHang { get; set; }

        [Display(Name = "Lo?i h�ng")]
        public string TenLoai { get; set; }

        [Display(Name = "Th??ng hi?u")]
        public string TenThuongHieu { get; set; }

        [Display(Name = "Nh� cung c?p")]
        public string TenNCC { get; set; }

        [Display(Name = "S? l??ng")]
        public int SoLuong { get; set; }

        [Display(Name = "??n gi� nh?p")]
        public decimal DonGiaNhap { get; set; }

        [Display(Name = "??n gi� b�n")]
        public decimal DonGiaBan { get; set; }

        [MaxLength(200)]
        [Display(Name = "?nh")]
        public string Anh { get; set; }

        [MaxLength(200)]
        [Display(Name = "Ghi ch�")]
        public string GhiChu { get; set; }
    }
}