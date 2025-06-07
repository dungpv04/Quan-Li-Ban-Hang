using Services.IServices;
using Shared.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.ReportScreen
{
    public partial class RevenueReportScreen : UserControl
    {
        private readonly IRevenueReportService _revenueReportService;

        public RevenueReportScreen(IRevenueReportService revenueReportService)
        {
            InitializeComponent();
            this.AutoScroll = true;
            _revenueReportService = revenueReportService;
        }

        private async void RevenueReportScreen_Load(object sender, EventArgs e)
        {
            await UpdateDataGridView();
        }

        private async Task UpdateDataGridView()
        {
            var data = await _revenueReportService.GetAllRevenueAsync(null, null);
            if (data != null && data.Any())
            {
                dgvResult.DataSource = data.ToList();

                dgvResult.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
                dgvResult.Columns["NgayBan"].HeaderText = "Ngày bán";
                dgvResult.Columns["TenNhanVien"].HeaderText = "Nhân viên";
                dgvResult.Columns["TenKhach"].HeaderText = "Khách hàng";
                dgvResult.Columns["TenHang"].HeaderText = "Tên hàng";
                dgvResult.Columns["TenLoai"].HeaderText = "Loại hàng";
                dgvResult.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvResult.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvResult.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dgvResult.Columns["TongTien"].HeaderText = "Tổng tiền";

                dgvResult.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgvResult.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
                dgvResult.Columns["TongTien"].DefaultCellStyle.Format = "N0";

                dgvResult.Columns["NgayBan"].DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvResult.Update();
                dgvResult.Refresh();
            }
        }

        //Thich giu lai nut Hien thi cung duoc
        private async Task UpdateDataGridView(IEnumerable<RevenueReportViewModel> data)
        {
            if (data != null && data.Any())
            {
                dgvResult.DataSource = data.ToList();

                dgvResult.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
                dgvResult.Columns["NgayBan"].HeaderText = "Ngày bán";
                dgvResult.Columns["TenNhanVien"].HeaderText = "Nhân viên";
                dgvResult.Columns["TenKhach"].HeaderText = "Khách hàng";
                dgvResult.Columns["TenHang"].HeaderText = "Tên hàng";
                dgvResult.Columns["TenLoai"].HeaderText = "Loại hàng";
                dgvResult.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvResult.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvResult.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dgvResult.Columns["TongTien"].HeaderText = "Tổng tiền";

                dgvResult.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgvResult.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
                dgvResult.Columns["TongTien"].DefaultCellStyle.Format = "N0";

                dgvResult.Columns["NgayBan"].DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvResult.Update();
                dgvResult.Refresh();
            }
            else
            {
                dgvResult.DataSource = null;
                MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<RevenueReportViewModel> revenueData = null;
                DateTime? fromDate =
                    rdoByRange.Checked ? dtpFromDate.Value : (rdoByDay.Checked ? dtpByDay.Value : null);
                DateTime? toDate = rdoByRange.Checked ? dtpToDate.Value : (rdoByDay.Checked ? dtpByDay.Value : null);

                if (rdoProduct.Checked && !string.IsNullOrWhiteSpace(txtProductId.Text))
                {
                    revenueData =
                        await _revenueReportService.GetRevenueByProductAsync(txtProductId.Text.Trim(), fromDate,
                            toDate);
                }
                else if (rdoCategory.Checked && !string.IsNullOrWhiteSpace(txtCategoryId.Text))
                {
                    revenueData =
                        await _revenueReportService.GetRevenueByCategoryAsync(txtCategoryId.Text.Trim(), fromDate,
                            toDate);
                }
                else if (rdoEmployee.Checked && !string.IsNullOrWhiteSpace(txtEmployeeId.Text))
                {
                    revenueData =
                        await _revenueReportService.GetRevenueByEmployeeAsync(txtEmployeeId.Text.Trim(), fromDate,
                            toDate);
                }

                if (revenueData != null)
                {
                    await UpdateDataGridView(revenueData);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tiêu chí và nhập thông tin tương ứng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? fromDate =
                    rdoByRange.Checked ? dtpFromDate.Value : (rdoByDay.Checked ? dtpByDay.Value : null);
                DateTime? toDate = rdoByRange.Checked ? dtpToDate.Value : (rdoByDay.Checked ? dtpByDay.Value : null);

                var revenueData = await _revenueReportService.GetAllRevenueAsync(fromDate, toDate);
                await UpdateDataGridView(revenueData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            rdoProduct.Checked = false;
            rdoCategory.Checked = false;
            rdoEmployee.Checked = false;
            txtProductId.Clear();
            txtCategoryId.Clear();
            txtEmployeeId.Clear();
            rdoByDay.Checked = false;
            rdoByRange.Checked = false;
            dgvResult.DataSource = null;
        }
    }
}