using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.View_Models
{
    public class SupplierViewModel
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "Mã NCC")]
        public string MaNCC { get; set; }

        [MaxLength(100)]
        [Display(Name = "Tên NCC")]
        public string TenNCC { get; set; }

        [MaxLength(200)]
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [MaxLength(20)]
        [Display(Name = "Điện thoại")]
        public string DienThoai { get; set; }
    }
}
