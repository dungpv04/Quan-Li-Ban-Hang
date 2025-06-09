using System;
using System.ComponentModel.DataAnnotations;

namespace Shared.View_Models
{
    public class ProductViewModel
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "Mã hàng")]
        public string MaHang { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Tên hàng")]
        public string TenHang { get; set; }

        [Display(Name = "Lo?i hàng")]
        public string TenLoai { get; set; }

        [Display(Name = "Th??ng hi?u")]
        public string TenThuongHieu { get; set; }

        [Display(Name = "Nhà cung c?p")]
        public string TenNCC { get; set; }

        [Display(Name = "S? l??ng")]
        public int SoLuong { get; set; }

        [Display(Name = "??n giá nh?p")]
        public decimal DonGiaNhap { get; set; }

        [Display(Name = "??n giá bán")]
        public decimal DonGiaBan { get; set; }

        [MaxLength(200)]
        [Display(Name = "?nh")]
        public string Anh { get; set; }

        [MaxLength(200)]
        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; }
    }
}