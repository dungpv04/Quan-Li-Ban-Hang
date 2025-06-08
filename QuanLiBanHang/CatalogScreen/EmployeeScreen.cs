using Database.Models;
using Services.IServices;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class EmployeeScreen : UserControl
    {
        private readonly IEmployeeService _employeeService;
        private string? selectedEmployeeId =>
            dgvEmployee.CurrentRow?.Cells["MaNhanVien"].Value?.ToString();

        public EmployeeScreen(IEmployeeService employeeService)
        {
            InitializeComponent();
            this.AutoScroll = true;
            _employeeService = employeeService;
        }

        private async void EmployeeScreen_Load(object sender, EventArgs e)
        {
            await UpdateGridView();
        }

        private async Task UpdateGridView()
        {
            var employees = await _employeeService.GetAllAsync();
            if (employees != null && employees.Any())
            {
                dgvEmployee.DataSource = employees.ToList();
                dgvEmployee.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
                dgvEmployee.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                dgvEmployee.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvEmployee.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvEmployee.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvEmployee.Columns["DienThoai"].HeaderText = "Điện thoại";
                dgvEmployee.Update();
                dgvEmployee.Refresh();
            }
        }




        private async void btnAdd_Click(object sender, EventArgs e)
        {
            // Xác định giới tính từ RadioButton
            string gioiTinh = rdoMale.Checked ? "Nam" : "Nữ";

            var isAdded = await _employeeService.AddAsync(new NhanVien
            {
                MaNhanVien = txtEmployeeId.Text.Trim(),
                TenNhanVien = txtEmployeeName.Text.Trim(),
                DiaChi = txtAddress.Text.Trim(),
                GioiTinh = gioiTinh,
                NgaySinh = dtpBirthDate.Value,
                DienThoai = txtPhone.Text.Trim()
            });

            if (isAdded)
            {
                await UpdateGridView();
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeId != null)
            {
                // Xác định giới tính từ RadioButton
                string gioiTinh = rdoMale.Checked ? "Nam" : "Nữ";

                var isUpdated = await _employeeService.UpdateAsync(new NhanVien
                {
                    MaNhanVien = txtEmployeeId.Text.Trim(),
                    TenNhanVien = txtEmployeeName.Text.Trim(),
                    DiaChi = txtAddress.Text.Trim(),
                    GioiTinh = gioiTinh, // Sử dụng giới tính đã xác định
                    NgaySinh = dtpBirthDate.Value,
                    DienThoai = txtPhone.Text.Trim()
                }, selectedEmployeeId);

                if (isUpdated)
                {
                    await UpdateGridView();
                    MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeId != null)
            {
                var isDeleted = await _employeeService.DeleteAsync(selectedEmployeeId);
                if (isDeleted)
                {
                    await UpdateGridView();
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
