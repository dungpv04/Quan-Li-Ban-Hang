using Database.Models;
using Services.IServices;
using Shared.IFactory;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ProductScreen : UserControl
    {
        private readonly IProductService _productService;
        private readonly IAbstractFactory _abstractFactory;
        private string? selectedProductId =>
            dgvProduct.CurrentRow?.Cells["MaHang"].Value?.ToString();

        public ProductScreen(IProductService productService, IAbstractFactory abstractFactory)
        {
            InitializeComponent();
            this.AutoScroll = true;
            _productService = productService;
            _abstractFactory = abstractFactory;
            this.Load += ProductScreen_Load;
        }

        private async void ProductScreen_Load(object sender, EventArgs e)
        {
            await LoadComboBoxes();
            await UpdateGridView();
        }

        private IProductService Get_productService()
        {
            return _productService;
        }

        private async Task LoadComboBoxes()
        {
            try
            {
                // Load Categories
                var categories = await _productService.GetAllCategoriesAsync();
                cmbCategory.DataSource = categories.ToList();
                cmbCategory.DisplayMember = "TenLoai";
                cmbCategory.ValueMember = "MaLoai";

                // Load Brands
                var brands = await _productService.GetAllBrandsAsync();
                cmbBrand.DataSource = brands.ToList();
                cmbBrand.DisplayMember = "TenThuongHieu";
                cmbBrand.ValueMember = "MaThuongHieu";

                // Load Suppliers
                var suppliers = await _productService.GetAllSuppliersAsync();
                cmbSupplier.DataSource = suppliers.ToList();
                cmbSupplier.DisplayMember = "TenNCC";
                cmbSupplier.ValueMember = "MaNCC";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu cho combobox: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UpdateGridView()
        {
            var products = await _productService.GetAllAsync();
            if (products != null && products.Any())
            {
                dgvProduct.DataSource = products.ToList();
                dgvProduct.Columns["MaHang"].HeaderText = "Mã hàng";
                dgvProduct.Columns["TenHang"].HeaderText = "Tên hàng";
                dgvProduct.Columns["TenLoai"].HeaderText = "Loại hàng";
                dgvProduct.Columns["TenThuongHieu"].HeaderText = "Thương hiệu";
                dgvProduct.Columns["TenNCC"].HeaderText = "Nhà cung cấp";
                dgvProduct.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvProduct.Columns["DonGiaNhap"].HeaderText = "Đơn giá nhập";
                dgvProduct.Columns["DonGiaBan"].HeaderText = "Đơn giá bán";
                dgvProduct.Columns["GhiChu"].HeaderText = "Ghi chú";

                // Có thể ẩn cột Anh vì bạn hiển thị riêng bằng PictureBox
                if (dgvProduct.Columns.Contains("Anh"))
                    dgvProduct.Columns["Anh"].Visible = false;

                dgvProduct.Update();
                dgvProduct.Refresh();
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Hang
                {
                    MaHang = txtProductId.Text.Trim(),
                    TenHang = txtProductName.Text.Trim(),
                    MaLoai = cmbCategory.SelectedValue?.ToString(),
                    MaThuongHieu = cmbBrand.SelectedValue?.ToString(),
                    MaNCC = cmbSupplier.SelectedValue?.ToString(),
                    SoLuong = int.Parse(txtQuantity.Text.Trim()),
                    DonGiaNhap = decimal.Parse(txtImportPrice.Text.Trim()),
                    DonGiaBan = decimal.Parse(txtUnitPrice.Text.Trim()),
                    Anh = "", // Xử lý hình ảnh nếu cần
                    GhiChu = txtNote.Text.Trim()
                };

                var isAdded = await _productService.AddAsync(product);
                if (isAdded)
                {
                    await UpdateGridView();
                    MessageBox.Show("Thêm hàng hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm hàng hóa thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProductId != null)
            {
                try
                {
                    // Debugging: Check the selected values
                    string selectedCategory = cmbCategory.SelectedValue?.ToString() ?? "null";
                    string selectedBrand = cmbBrand.SelectedValue?.ToString() ?? "null";
                    string selectedSupplier = cmbSupplier.SelectedValue?.ToString() ?? "null";

                    // For debugging purposes
                    MessageBox.Show($"Category: {selectedCategory}, Brand: {selectedBrand}, Supplier: {selectedSupplier}");

                    var product = new Hang
                    {
                        MaHang = txtProductId.Text.Trim(),
                        TenHang = txtProductName.Text.Trim(),
                        MaLoai = cmbCategory.SelectedValue?.ToString(),
                        MaThuongHieu = cmbBrand.SelectedValue?.ToString(),
                        MaNCC = cmbSupplier.SelectedValue?.ToString(),
                        SoLuong = int.Parse(txtQuantity.Text.Trim()),
                        DonGiaNhap = decimal.Parse(txtImportPrice.Text.Trim()),
                        DonGiaBan = decimal.Parse(txtUnitPrice.Text.Trim()),
                        Anh = "",
                        GhiChu = txtNote.Text.Trim()
                    };

                    var isUpdated = await _productService.UpdateAsync(product, selectedProductId);
                    if (isUpdated)
                    {
                        await UpdateGridView();
                        MessageBox.Show("Sửa hàng hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa hàng hóa thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng hóa cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId != null)
            {
                var isDeleted = await _productService.DeleteAsync(selectedProductId);
                if (isDeleted)
                {
                    await UpdateGridView();
                    MessageBox.Show("Xóa hàng hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa hàng hóa thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng hóa cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Thêm phương thức để cập nhật textbox khi chọn dòng trong datagridview
        private void dgvProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow != null)
            {
                txtProductId.Text = dgvProduct.CurrentRow.Cells["MaHang"].Value?.ToString() ?? "";
                txtProductName.Text = dgvProduct.CurrentRow.Cells["TenHang"].Value?.ToString() ?? "";
                txtQuantity.Text = dgvProduct.CurrentRow.Cells["SoLuong"].Value?.ToString() ?? "";
                txtImportPrice.Text = dgvProduct.CurrentRow.Cells["DonGiaNhap"].Value?.ToString() ?? "";
                txtUnitPrice.Text = dgvProduct.CurrentRow.Cells["DonGiaBan"].Value?.ToString() ?? "";
                txtNote.Text = dgvProduct.CurrentRow.Cells["GhiChu"].Value?.ToString() ?? "";

                // Cập nhật combobox
                SetComboBoxValue(cmbCategory, "TenLoai");
                SetComboBoxValue(cmbBrand, "TenThuongHieu");
                SetComboBoxValue(cmbSupplier, "TenNCC");

                // Hiển thị hình ảnh nếu có
                string anh = dgvProduct.CurrentRow.Cells["Anh"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(anh))
                {
                    try
                    {
                        picProduct.ImageLocation = anh;
                    }
                    catch { }
                }
            }
        }

        private void SetComboBoxValue(ComboBox comboBox, string columnName)
        {
            if (dgvProduct.CurrentRow != null && comboBox.Items.Count > 0)
            {
                string value = dgvProduct.CurrentRow.Cells[columnName].Value?.ToString() ?? "";
                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    var item = comboBox.Items[i];
                    string itemText = comboBox.GetItemText(item);
                    if (itemText == value)
                    {
                        comboBox.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void lblProductId_Click(object sender, EventArgs e)
        {

        }
    }
}
