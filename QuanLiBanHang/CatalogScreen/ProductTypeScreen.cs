using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Models;
using Services.IServices;
using Shared.IFactory;
namespace UI
{
    public partial class ProductTypeScreen : UserControl
    {
        private readonly IProductTypeService _productTypeService;
        private string? selectedProductTypeId => dgvLoaiHang.CurrentRow?.Cells["MaLoai"].Value?.ToString();
        public ProductTypeScreen(IProductTypeService productTypeService, IAbstractFactory abstractFactory)
        {
            InitializeComponent();
            this.AutoScroll = true;
            _productTypeService = productTypeService;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            var isAdded = await _productTypeService.AddAsync(new LoaiHang
            {
                MaLoai = txtMaLoai.Text.Trim(),
                TenLoai = txtTenLoai.Text.Trim(),
                MoTa = txtMoTa.Text.Trim()
            });

            if (isAdded)
            {
                await updateGridView();
                MessageBox.Show("Thêm loại hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm loại hàng thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ProductTypeScreen_Load(object sender, EventArgs e)
        {
            await updateGridView();
        }

        private async Task updateGridView()
        {
            var productTypes = await _productTypeService.GetAllAsync();
            if (productTypes != null && productTypes.Any())
            {
                dgvLoaiHang.DataSource = productTypes.ToList();
                dgvLoaiHang.Columns["MaLoai"].HeaderText = "Mã loại hàng";
                dgvLoaiHang.Columns["TenLoai"].HeaderText = "Tên loại hàng";
                dgvLoaiHang.Columns["MoTa"].HeaderText = "Mô tả";
                dgvLoaiHang.Update();
                dgvLoaiHang.Refresh();
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedProductTypeId != null)
            {
                string maLoai = txtMaLoai.Text.Trim();
                string tenLoai = txtTenLoai.Text.Trim();
                string moTa = txtMoTa.Text.Trim();

                var task = await _productTypeService.UpdateAsync(new LoaiHang
                {
                    MaLoai = maLoai,
                    TenLoai = tenLoai,
                    MoTa = moTa
                }, selectedProductTypeId);
                if(task)
                {
                    await updateGridView();
                    MessageBox.Show("Sửa loại hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa loại hàng thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedProductTypeId != null)
            {
                var task = await _productTypeService.DeleteAsync(selectedProductTypeId);
                if (task)
                {
                    await updateGridView();
                    MessageBox.Show("Xóa loại hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa loại hàng thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
