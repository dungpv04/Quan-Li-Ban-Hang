using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Models;
using Services.IServices;
using Shared.IFactory;
using Shared.View_Models;

namespace UI
{
    public partial class CustomerScreen : UserControl
    {
        private readonly ICustomerService _customerService;
        private string? selectedCustomerId => dgvCustomer.CurrentRow?.Cells["MaKhach"].Value?.ToString();

        public CustomerScreen(ICustomerService customerService, IAbstractFactory abstractFactory)
        {
            InitializeComponent();
            this.AutoScroll = true;
            _customerService = customerService;

            // Wire up events
            this.Load += CustomerScreen_Load;
            btnAdd.Click += btnThem_Click;
            btnEdit.Click += btnSua_Click;
            btnDelete.Click += btnXoa_Click;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var isAdded = await _customerService.AddAsync(new Khach
                {
                    MaKhach = txtCustomerId.Text.Trim(),
                    TenKhach = txtCustomerName.Text.Trim(),
                    DiaChi = txtAddress.Text.Trim(),
                    DienThoai = txtPhone.Text.Trim()
                });

                if (isAdded)
                {
                    await updateGridView();
                    ClearTextBoxes();
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void CustomerScreen_Load(object sender, EventArgs e)
        {
            await updateGridView();
        }

        private async Task updateGridView()
        {
            try
            {
                var customers = await _customerService.GetAllAsync();
                if (customers != null && customers.Any())
                {
                    dgvCustomer.DataSource = customers.ToList();
                    foreach (DataGridViewColumn column in dgvCustomer.Columns)
                    {
                        var prop = typeof(CustomerViewModel).GetProperty(column.DataPropertyName);
                        if (prop != null)
                        {
                            var displayAttr = prop.GetCustomAttribute<DisplayAttribute>();
                            if (displayAttr != null)
                            {
                                column.HeaderText = displayAttr.Name;
                            }
                        }
                    }

                    dgvCustomer.Update();
                    dgvCustomer.Refresh();
                }
                else
                {
                    dgvCustomer.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId != null)
            {
                try
                {
                    string maKhach = txtCustomerId.Text.Trim();
                    string tenKhach = txtCustomerName.Text.Trim();
                    string diaChi = txtAddress.Text.Trim();
                    string dienThoai = txtPhone.Text.Trim();

                    var task = await _customerService.UpdateAsync(new Khach
                    {
                        MaKhach = maKhach,
                        TenKhach = tenKhach,
                        DiaChi = diaChi,
                        DienThoai = dienThoai
                    }, selectedCustomerId);

                    if (task)
                    {
                        await updateGridView();
                        ClearTextBoxes();
                        MessageBox.Show("Sửa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa khách hàng thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi sửa khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId != null)
            {
                try
                {
                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var task = await _customerService.DeleteAsync(selectedCustomerId);
                        if (task)
                        {
                            await updateGridView();
                            ClearTextBoxes();
                            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa khách hàng thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                txtCustomerId.Text = row.Cells["MaKhach"].Value?.ToString();
                txtCustomerName.Text = row.Cells["TenKhach"].Value?.ToString();
                txtAddress.Text = row.Cells["DiaChi"].Value?.ToString();
                txtPhone.Text = row.Cells["DienThoai"].Value?.ToString();
            }
        }

        private void ClearTextBoxes()
        {
            txtCustomerId.Clear();
            txtCustomerName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }
    }
}