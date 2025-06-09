using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Database.Models;
using Services.IServices;
using Shared.IFactory;
using Services.Services;
using Shared.View_Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace UI
{

    public partial class SupplierScreen : UserControl
    {
        private readonly ISupplierService _supplierService;
        private string? selectedSupplierId => dgvSupplier.CurrentRow?.Cells["MaNCC"].Value?.ToString();

        public SupplierScreen(ISupplierService supplierService, IAbstractFactory abstractFactory)
        {
            InitializeComponent();
            this.AutoScroll = true;
            _supplierService = supplierService;

        }

        private async void SupplierScreen_Load(object sender, EventArgs e)
        {
            await updateGridView();
        }

        private async Task updateGridView()
        {
            var productTypes = await _supplierService.GetAllAsync();
            if (productTypes != null && productTypes.Any())
            {
                dgvSupplier.DataSource = productTypes.ToList();
                foreach (DataGridViewColumn column in dgvSupplier.Columns)
                {
                    var prop = typeof(SupplierViewModel).GetProperty(column.DataPropertyName);
                    if (prop != null)
                    {
                        var displayAttr = prop.GetCustomAttribute<DisplayAttribute>();
                        if (displayAttr != null)
                        {
                            column.HeaderText = displayAttr.Name;
                        }
                    }
                }
                dgvSupplier.Update();
                dgvSupplier.Refresh();
            }
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var supplierId = txtSupplierId.Text.Trim();
            var supplierName = txtSupplierName.Text.Trim();
            var address = txtAddress.Text.Trim();
            var phoneNumber = txtPhone.Text.Trim();

            // Kiểm tra trường không được để trống
            if (string.IsNullOrEmpty(supplierId) ||
                string.IsNullOrEmpty(supplierName) ||
                string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra phoneNumber có đúng 10 chữ số
            if (phoneNumber.Length != 10 || !phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra phoneNumber bắt đầu là số 0
            if (!phoneNumber.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var isAdded = await _supplierService.AddIfNotExist(new NhaCungCap
            {
                MaNCC = supplierId,
                TenNCC = supplierName,
                DiaChi = address,
                DienThoai = phoneNumber
            });

            if (isAdded)
            {
                await updateGridView();
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];

            txtSupplierId.Text = row.Cells["MaNCC"].Value?.ToString();
            txtSupplierName.Text = row.Cells["TenNCC"].Value?.ToString();
            txtAddress.Text = row.Cells["DiaChi"].Value?.ToString();
            txtPhone.Text = row.Cells["DienThoai"].Value?.ToString();

        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var supplierId = txtSupplierId.Text.Trim();
            var supplierName = txtSupplierName.Text.Trim();
            var address = txtAddress.Text.Trim();
            var phoneNumber = txtPhone.Text.Trim();

            // Kiểm tra trường không được để trống
            if (string.IsNullOrEmpty(supplierId) ||
                string.IsNullOrEmpty(supplierName) ||
                string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra phoneNumber có đúng 10 chữ số
            if (phoneNumber.Length != 10 || !phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra phoneNumber bắt đầu là số 0
            if (!phoneNumber.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedSupplierId != null)
            {

                var task = await _supplierService.UpdateAsync(new NhaCungCap
                {
                    MaNCC = supplierId,
                    TenNCC = supplierName,
                    DiaChi = address,
                    DienThoai = phoneNumber
                }, selectedSupplierId);
                if (task)
                {
                    await updateGridView();
                    MessageBox.Show("Sửa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa nhà cung cấp thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId != null)
            {
                var task = await _supplierService.DeleteAsync(selectedSupplierId);
                if (task)
                {
                    await updateGridView();
                    MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
