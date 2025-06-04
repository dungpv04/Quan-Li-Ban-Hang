namespace UI.InvoiceScreen
{
    partial class ImportInvoiceScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            grpGeneral = new GroupBox();
            lblInvoiceId = new Label();
            txtInvoiceId = new TextBox();
            lblImportDate = new Label();
            dtpImportDate = new DateTimePicker();
            lblEmployeeId = new Label();
            cmbEmployeeId = new ComboBox();
            lblEmployeeName = new Label();
            txtEmployeeName = new TextBox();
            lblSupplierId = new Label();
            cmbSupplierId = new ComboBox();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblSupplierAddress = new Label();
            txtSupplierAddress = new TextBox();
            lblSupplierPhone = new Label();
            txtSupplierPhone = new TextBox();
            grpProduct = new GroupBox();
            lblProductId = new Label();
            cmbProductId = new ComboBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            dgvDetail = new DataGridView();
            lblRemoveHint = new Label();
            lblMoneyInWords = new Label();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnAddInvoice = new Button();
            btnSave = new Button();
            btnCancelInvoice = new Button();
            btnPrint = new Button();
            btnExit = new Button();
            lblSearchInvoiceId = new Label();
            cmbSearchInvoiceId = new ComboBox();
            btnSearch = new Button();
            grpGeneral.SuspendLayout();
            grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DodgerBlue;
            lblTitle.Location = new Point(270, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(460, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // grpGeneral
            // 
            grpGeneral.Controls.Add(lblInvoiceId);
            grpGeneral.Controls.Add(txtInvoiceId);
            grpGeneral.Controls.Add(lblImportDate);
            grpGeneral.Controls.Add(dtpImportDate);
            grpGeneral.Controls.Add(lblEmployeeId);
            grpGeneral.Controls.Add(cmbEmployeeId);
            grpGeneral.Controls.Add(lblEmployeeName);
            grpGeneral.Controls.Add(txtEmployeeName);
            grpGeneral.Controls.Add(lblSupplierId);
            grpGeneral.Controls.Add(cmbSupplierId);
            grpGeneral.Controls.Add(lblSupplierName);
            grpGeneral.Controls.Add(txtSupplierName);
            grpGeneral.Controls.Add(lblSupplierAddress);
            grpGeneral.Controls.Add(txtSupplierAddress);
            grpGeneral.Controls.Add(lblSupplierPhone);
            grpGeneral.Controls.Add(txtSupplierPhone);
            grpGeneral.Font = new Font("Arial", 10F, FontStyle.Bold);
            grpGeneral.Location = new Point(30, 112);
            grpGeneral.Margin = new Padding(3, 4, 3, 4);
            grpGeneral.Name = "grpGeneral";
            grpGeneral.Padding = new Padding(3, 4, 3, 4);
            grpGeneral.Size = new Size(825, 194);
            grpGeneral.TabIndex = 1;
            grpGeneral.TabStop = false;
            grpGeneral.Text = "Thông tin chung";
            // 
            // lblInvoiceId
            // 
            lblInvoiceId.Location = new Point(10, 38);
            lblInvoiceId.Name = "lblInvoiceId";
            lblInvoiceId.Size = new Size(104, 29);
            lblInvoiceId.TabIndex = 0;
            lblInvoiceId.Text = "Mã hóa đơn";
            // 
            // txtInvoiceId
            // 
            txtInvoiceId.Location = new Point(120, 34);
            txtInvoiceId.Margin = new Padding(3, 4, 3, 4);
            txtInvoiceId.Name = "txtInvoiceId";
            txtInvoiceId.Size = new Size(200, 27);
            txtInvoiceId.TabIndex = 1;
            // 
            // lblImportDate
            // 
            lblImportDate.Location = new Point(10, 79);
            lblImportDate.Name = "lblImportDate";
            lblImportDate.Size = new Size(94, 29);
            lblImportDate.TabIndex = 2;
            lblImportDate.Text = "Ngày nhập";
            // 
            // dtpImportDate
            // 
            dtpImportDate.Location = new Point(110, 75);
            dtpImportDate.Margin = new Padding(3, 4, 3, 4);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(246, 27);
            dtpImportDate.TabIndex = 3;
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.Location = new Point(10, 120);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(118, 29);
            lblEmployeeId.TabIndex = 4;
            lblEmployeeId.Text = "Mã nhân viên";
            // 
            // cmbEmployeeId
            // 
            cmbEmployeeId.Location = new Point(134, 117);
            cmbEmployeeId.Margin = new Padding(3, 4, 3, 4);
            cmbEmployeeId.Name = "cmbEmployeeId";
            cmbEmployeeId.Size = new Size(200, 27);
            cmbEmployeeId.TabIndex = 5;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.Location = new Point(10, 161);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(127, 29);
            lblEmployeeName.TabIndex = 6;
            lblEmployeeName.Text = "Tên nhân viên";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(143, 158);
            txtEmployeeName.Margin = new Padding(3, 4, 3, 4);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(200, 27);
            txtEmployeeName.TabIndex = 7;
            // 
            // lblSupplierId
            // 
            lblSupplierId.Location = new Point(340, 38);
            lblSupplierId.Name = "lblSupplierId";
            lblSupplierId.Size = new Size(80, 29);
            lblSupplierId.TabIndex = 8;
            lblSupplierId.Text = "Mã NCC";
            // 
            // cmbSupplierId
            // 
            cmbSupplierId.Location = new Point(430, 34);
            cmbSupplierId.Margin = new Padding(3, 4, 3, 4);
            cmbSupplierId.Name = "cmbSupplierId";
            cmbSupplierId.Size = new Size(120, 27);
            cmbSupplierId.TabIndex = 9;
            // 
            // lblSupplierName
            // 
            lblSupplierName.Location = new Point(385, 78);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(80, 29);
            lblSupplierName.TabIndex = 10;
            lblSupplierName.Text = "Tên NCC";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(476, 75);
            txtSupplierName.Margin = new Padding(3, 4, 3, 4);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(120, 27);
            txtSupplierName.TabIndex = 11;
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.Location = new Point(375, 120);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(80, 29);
            lblSupplierAddress.TabIndex = 12;
            lblSupplierAddress.Text = "Địa chỉ";
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Location = new Point(460, 117);
            txtSupplierAddress.Margin = new Padding(3, 4, 3, 4);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.Size = new Size(150, 27);
            txtSupplierAddress.TabIndex = 13;
            // 
            // lblSupplierPhone
            // 
            lblSupplierPhone.Location = new Point(362, 161);
            lblSupplierPhone.Name = "lblSupplierPhone";
            lblSupplierPhone.Size = new Size(103, 29);
            lblSupplierPhone.TabIndex = 14;
            lblSupplierPhone.Text = "Điện thoại";
            // 
            // txtSupplierPhone
            // 
            txtSupplierPhone.Location = new Point(471, 158);
            txtSupplierPhone.Margin = new Padding(3, 4, 3, 4);
            txtSupplierPhone.Name = "txtSupplierPhone";
            txtSupplierPhone.Size = new Size(150, 27);
            txtSupplierPhone.TabIndex = 15;
            // 
            // grpProduct
            // 
            grpProduct.Controls.Add(lblProductId);
            grpProduct.Controls.Add(cmbProductId);
            grpProduct.Controls.Add(lblProductName);
            grpProduct.Controls.Add(txtProductName);
            grpProduct.Controls.Add(lblQuantity);
            grpProduct.Controls.Add(txtQuantity);
            grpProduct.Controls.Add(lblUnitPrice);
            grpProduct.Controls.Add(txtUnitPrice);
            grpProduct.Controls.Add(lblDiscount);
            grpProduct.Controls.Add(txtDiscount);
            grpProduct.Controls.Add(lblAmount);
            grpProduct.Controls.Add(txtAmount);
            grpProduct.Controls.Add(dgvDetail);
            grpProduct.Controls.Add(lblRemoveHint);
            grpProduct.Controls.Add(lblMoneyInWords);
            grpProduct.Controls.Add(lblTotal);
            grpProduct.Controls.Add(txtTotal);
            grpProduct.Font = new Font("Arial", 10F, FontStyle.Bold);
            grpProduct.Location = new Point(30, 325);
            grpProduct.Margin = new Padding(3, 4, 3, 4);
            grpProduct.Name = "grpProduct";
            grpProduct.Padding = new Padding(3, 4, 3, 4);
            grpProduct.Size = new Size(825, 425);
            grpProduct.TabIndex = 2;
            grpProduct.TabStop = false;
            grpProduct.Text = "Thông tin các mặt hàng";
            // 
            // lblProductId
            // 
            lblProductId.Location = new Point(10, 38);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(80, 29);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã hàng";
            // 
            // cmbProductId
            // 
            cmbProductId.Location = new Point(90, 34);
            cmbProductId.Margin = new Padding(3, 4, 3, 4);
            cmbProductId.Name = "cmbProductId";
            cmbProductId.Size = new Size(100, 27);
            cmbProductId.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.Location = new Point(10, 77);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(83, 29);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Tên hàng";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(99, 76);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(120, 27);
            txtProductName.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.Location = new Point(204, 34);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(86, 29);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(296, 31);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(60, 27);
            txtQuantity.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.Location = new Point(362, 33);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(81, 29);
            lblUnitPrice.TabIndex = 6;
            lblUnitPrice.Text = "Đơn giá";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(440, 30);
            txtUnitPrice.Margin = new Padding(3, 4, 3, 4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(90, 27);
            txtUnitPrice.TabIndex = 7;
            // 
            // lblDiscount
            // 
            lblDiscount.Location = new Point(536, 33);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(94, 29);
            lblDiscount.TabIndex = 8;
            lblDiscount.Text = "Chiết khấu %";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(636, 30);
            txtDiscount.Margin = new Padding(3, 4, 3, 4);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(50, 27);
            txtDiscount.TabIndex = 9;
            // 
            // lblAmount
            // 
            lblAmount.Location = new Point(476, 81);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(94, 29);
            lblAmount.TabIndex = 10;
            lblAmount.Text = "Thành tiền";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(576, 81);
            txtAmount.Margin = new Padding(3, 4, 3, 4);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(110, 27);
            txtAmount.TabIndex = 11;
            // 
            // dgvDetail
            // 
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(10, 112);
            dgvDetail.Margin = new Padding(3, 4, 3, 4);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowHeadersWidth = 51;
            dgvDetail.RowTemplate.Height = 24;
            dgvDetail.Size = new Size(770, 150);
            dgvDetail.TabIndex = 22;
            // 
            // lblRemoveHint
            // 
            lblRemoveHint.ForeColor = Color.Red;
            lblRemoveHint.Location = new Point(10, 266);
            lblRemoveHint.Name = "lblRemoveHint";
            lblRemoveHint.Size = new Size(280, 25);
            lblRemoveHint.TabIndex = 23;
            lblRemoveHint.Text = "Kích đúp một dòng để xóa";
            // 
            // lblMoneyInWords
            // 
            lblMoneyInWords.Location = new Point(10, 294);
            lblMoneyInWords.Name = "lblMoneyInWords";
            lblMoneyInWords.Size = new Size(500, 28);
            lblMoneyInWords.TabIndex = 24;
            lblMoneyInWords.Text = "Bằng chữ: ...";
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(550, 294);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 28);
            lblTotal.TabIndex = 25;
            lblTotal.Text = "Tổng tiền";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(630, 291);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(150, 27);
            txtTotal.TabIndex = 26;
            // 
            // btnAddInvoice
            // 
            btnAddInvoice.Location = new Point(140, 769);
            btnAddInvoice.Margin = new Padding(3, 4, 3, 4);
            btnAddInvoice.Name = "btnAddInvoice";
            btnAddInvoice.Size = new Size(100, 40);
            btnAddInvoice.TabIndex = 30;
            btnAddInvoice.Text = "Thêm hóa đơn";
            btnAddInvoice.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(250, 769);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 40);
            btnSave.TabIndex = 31;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancelInvoice
            // 
            btnCancelInvoice.Location = new Point(340, 769);
            btnCancelInvoice.Margin = new Padding(3, 4, 3, 4);
            btnCancelInvoice.Name = "btnCancelInvoice";
            btnCancelInvoice.Size = new Size(100, 40);
            btnCancelInvoice.TabIndex = 32;
            btnCancelInvoice.Text = "Hủy hóa đơn";
            btnCancelInvoice.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(450, 769);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(100, 40);
            btnPrint.TabIndex = 33;
            btnPrint.Text = "In hóa đơn";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(560, 769);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 40);
            btnExit.TabIndex = 34;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblSearchInvoiceId
            // 
            lblSearchInvoiceId.Location = new Point(30, 838);
            lblSearchInvoiceId.Name = "lblSearchInvoiceId";
            lblSearchInvoiceId.Size = new Size(80, 28);
            lblSearchInvoiceId.TabIndex = 35;
            lblSearchInvoiceId.Text = "Mã hóa đơn";
            // 
            // cmbSearchInvoiceId
            // 
            cmbSearchInvoiceId.Location = new Point(120, 835);
            cmbSearchInvoiceId.Margin = new Padding(3, 4, 3, 4);
            cmbSearchInvoiceId.Name = "cmbSearchInvoiceId";
            cmbSearchInvoiceId.Size = new Size(200, 28);
            cmbSearchInvoiceId.TabIndex = 36;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(330, 834);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 32);
            btnSearch.TabIndex = 36;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // ImportInvoiceScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitle);
            Controls.Add(grpGeneral);
            Controls.Add(grpProduct);
            Controls.Add(btnAddInvoice);
            Controls.Add(btnSave);
            Controls.Add(btnCancelInvoice);
            Controls.Add(btnPrint);
            Controls.Add(btnExit);
            Controls.Add(lblSearchInvoiceId);
            Controls.Add(cmbSearchInvoiceId);
            Controls.Add(btnSearch);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ImportInvoiceScreen";
            Size = new Size(926, 888);
            grpGeneral.ResumeLayout(false);
            grpGeneral.PerformLayout();
            grpProduct.ResumeLayout(false);
            grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label lblInvoiceId;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.Label lblImportDate;
        private System.Windows.Forms.DateTimePicker dtpImportDate;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.ComboBox cmbEmployeeId;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.ComboBox cmbSupplierId;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.Label lblSupplierPhone;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.ComboBox cmbProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Label lblRemoveHint;
        private System.Windows.Forms.Label lblMoneyInWords;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancelInvoice;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSearchInvoiceId;
        private System.Windows.Forms.ComboBox cmbSearchInvoiceId;
        private System.Windows.Forms.Button btnSearch;
    }
}