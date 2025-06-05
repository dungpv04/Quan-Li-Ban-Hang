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

namespace UI
{

    public partial class SupplierScreen : UserControl
    {

        public SupplierScreen()
        {
            InitializeComponent();
            this.AutoScroll = true;
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            string connectionString = "Server=DESKTOP-8U71636\\SQLEXPRESS;Database=store management;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT MaNCC as [Mã NCC], TenNCC as [Tên NCC], DiaChi as [Địa chỉ], DienThoai as [Điện thoại] FROM NhaCungCaps";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvSupplier.DataSource = table;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
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

        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];

            txtSupplierId.Text = row.Cells["Mã NCC"].Value?.ToString();
            txtSupplierName.Text = row.Cells["Tên NCC"].Value?.ToString();
            txtAddress.Text = row.Cells["Địa chỉ"].Value?.ToString();
            txtPhone.Text = row.Cells["Điện thoại"].Value?.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var supplierId = txtSupplierId.Text.Trim();
        }
    }
}
