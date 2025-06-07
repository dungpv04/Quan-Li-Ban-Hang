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
using Services.Services;
using Shared.IFactory;
using Shared.View_Models;

namespace UI
{
    public partial class BrandScreen : UserControl
    {
        private readonly IBrandService _brandService;

        private string? selectedBrandId =>
            dgvBrand.CurrentRow?.Cells["MaThuongHieu"].Value?.ToString();

        public BrandScreen(IBrandService brandService, IAbstractFactory abstractFactory)
        {
            InitializeComponent();
            this.AutoScroll = true;
            _brandService = brandService;
        }

        private async Task updateGridView()
        {

            var brands = await _brandService.GetAllAsync();
            if (brands != null && brands.Any())
            {
                dgvBrand.DataSource = brands.ToList();
                foreach (DataGridViewColumn column in dgvBrand.Columns)
                {
                    var prop = typeof(BrandViewModel).GetProperty(column.DataPropertyName);
                    if (prop != null)
                    {
                        var displayAttr = prop.GetCustomAttribute<DisplayAttribute>();
                        if (displayAttr != null)
                        {
                            column.HeaderText = displayAttr.Name;
                        }
                    }
                }

                dgvBrand.Update();
                dgvBrand.Refresh();
            }
        }

        private async void BrandScreen_Load(object sender, EventArgs e)
        {
            await updateGridView();
        }

        private void dgvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBrand.Rows[e.RowIndex];

            txtBrandId.Text = row.Cells["MaThuongHieu"].Value?.ToString();
            txtBrandName.Text = row.Cells["TenThuongHieu"].Value?.ToString();
            txtCountry.Text = row.Cells["Nuoc"].Value?.ToString();
            txtWebsite.Text = row.Cells["Website"].Value?.ToString();
            txtDescription.Text = row.Cells["MoTa"].Value?.ToString();

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var isAdded = await _brandService.AddIfNotExist(new ThuongHieu
            {
                MaThuongHieu = txtBrandId.Text.Trim(),
                TenThuongHieu = txtBrandName.Text.Trim(),
                Nuoc = txtCountry.Text.Trim(),
                Website = txtWebsite.Text.Trim(),
                MoTa = txtDescription.Text.Trim()
            });

            if (isAdded)
            {
                await updateGridView();
                MessageBox.Show("Thêm thương hiệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thương hiệu thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedBrandId != null)
            {
                string maThuongHieu = txtBrandId.Text.Trim();
                string tenThuongHieu = txtBrandName.Text.Trim();
                string nuoc = txtCountry.Text.Trim();
                string website = txtWebsite.Text.Trim();
                string moTa = txtDescription.Text.Trim();
                var task = await _brandService.UpdateAsync(new ThuongHieu
                {
                    MaThuongHieu = maThuongHieu,
                    TenThuongHieu = tenThuongHieu,
                    Nuoc = nuoc,
                    Website = website,
                    MoTa = moTa
                }, selectedBrandId);
                if (task)
                {
                    await updateGridView();
                    MessageBox.Show("Sửa thương hiệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thương hiệu thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thương hiệu cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBrandId != null)
            {
                var task = await _brandService.DeleteAsync(selectedBrandId);
                if (task)
                {
                    await updateGridView();
                    MessageBox.Show("Xóa thương hiệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thương hiệu thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thương hiệu cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
