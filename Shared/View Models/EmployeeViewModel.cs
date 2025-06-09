using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.View_Models
{
    public class EmployeeViewModel
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "Mã nhân viên")]
        public string MaNhanVien { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Tên nhân viên")]
        public string TenNhanVien { get; set; }

        [MaxLength(200)]
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [MaxLength(10)]
        [Display(Name = "Giới tính")]
        public string GioiTinh { get; set; }

        [Display(Name = "Ngày sinh")]
        public DateTime? NgaySinh { get; set; }

        [MaxLength(20)]
        [Display(Name = "Điện thoại")]
        public string DienThoai { get; set; }
    }
}