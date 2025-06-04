namespace UI.InvoiceScreen
{
    partial class ExportInvoiceScreen
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
            // Title
            this.lblTitle = new System.Windows.Forms.Label();

            // GroupBox General Info
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblInvoiceId = new System.Windows.Forms.Label();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.lblExportDate = new System.Windows.Forms.Label();
            this.dtpExportDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.cmbEmployeeId = new System.Windows.Forms.ComboBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.cmbCustomerId = new System.Windows.Forms.ComboBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();

            // GroupBox Product Info
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.cmbProductId = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();

            // DataGridView
            this.dgvDetail = new System.Windows.Forms.DataGridView();

            // Labels, Textbox for Remove Hint, Total, Money In Words
            this.lblRemoveHint = new System.Windows.Forms.Label();
            this.lblMoneyInWords = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();

            // Buttons
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancelInvoice = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            // Search section
            this.lblSearchInvoiceId = new System.Windows.Forms.Label();
            this.cmbSearchInvoiceId = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();

            // ---- Initialize Controls Layout ----

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(270, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(381, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HÓA ĐƠN BÁN HÀNG";

            // grpGeneral
            this.grpGeneral.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblInvoiceId, this.txtInvoiceId,
                this.lblExportDate, this.dtpExportDate,
                this.lblEmployeeId, this.cmbEmployeeId,
                this.lblEmployeeName, this.txtEmployeeName,
                this.lblCustomerId, this.cmbCustomerId,
                this.lblCustomerName, this.txtCustomerName,
                this.lblCustomerAddress, this.txtCustomerAddress,
                this.lblCustomerPhone, this.txtCustomerPhone
            });
            this.grpGeneral.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.grpGeneral.Location = new System.Drawing.Point(30, 90);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(820, 155);
            this.grpGeneral.TabIndex = 1;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "Thông tin chung";

            // lblInvoiceId
            this.lblInvoiceId.Text = "Mã hóa đơn";
            this.lblInvoiceId.Location = new System.Drawing.Point(10, 30);
            this.lblInvoiceId.Size = new System.Drawing.Size(90, 23);
            // txtInvoiceId
            this.txtInvoiceId.Location = new System.Drawing.Point(110, 27);
            this.txtInvoiceId.Size = new System.Drawing.Size(200, 23);

            // lblExportDate
            this.lblExportDate.Text = "Ngày bán";
            this.lblExportDate.Location = new System.Drawing.Point(10, 63);
            this.lblExportDate.Size = new System.Drawing.Size(90, 23);
            // dtpExportDate
            this.dtpExportDate.Location = new System.Drawing.Point(110, 60);
            this.dtpExportDate.Size = new System.Drawing.Size(200, 23);

            // lblEmployeeId
            this.lblEmployeeId.Text = "Mã nhân viên";
            this.lblEmployeeId.Location = new System.Drawing.Point(10, 96);
            this.lblEmployeeId.Size = new System.Drawing.Size(90, 23);
            // cmbEmployeeId
            this.cmbEmployeeId.Location = new System.Drawing.Point(110, 93);
            this.cmbEmployeeId.Size = new System.Drawing.Size(200, 23);

            // lblEmployeeName
            this.lblEmployeeName.Text = "Tên nhân viên";
            this.lblEmployeeName.Location = new System.Drawing.Point(10, 129);
            this.lblEmployeeName.Size = new System.Drawing.Size(100, 23);
            // txtEmployeeName
            this.txtEmployeeName.Location = new System.Drawing.Point(110, 126);
            this.txtEmployeeName.Size = new System.Drawing.Size(200, 23);

            // lblCustomerId
            this.lblCustomerId.Text = "Mã khách hàng";
            this.lblCustomerId.Location = new System.Drawing.Point(340, 30);
            this.lblCustomerId.Size = new System.Drawing.Size(110, 23);
            // cmbCustomerId
            this.cmbCustomerId.Location = new System.Drawing.Point(460, 27);
            this.cmbCustomerId.Size = new System.Drawing.Size(120, 23);

            // lblCustomerName
            this.lblCustomerName.Text = "Tên khách hàng";
            this.lblCustomerName.Location = new System.Drawing.Point(340, 63);
            this.lblCustomerName.Size = new System.Drawing.Size(120, 23);
            // txtCustomerName
            this.txtCustomerName.Location = new System.Drawing.Point(460, 60);
            this.txtCustomerName.Size = new System.Drawing.Size(120, 23);

            // lblCustomerAddress
            this.lblCustomerAddress.Text = "Địa chỉ";
            this.lblCustomerAddress.Location = new System.Drawing.Point(340, 96);
            this.lblCustomerAddress.Size = new System.Drawing.Size(80, 23);
            // txtCustomerAddress
            this.txtCustomerAddress.Location = new System.Drawing.Point(460, 93);
            this.txtCustomerAddress.Size = new System.Drawing.Size(160, 23);

            // lblCustomerPhone
            this.lblCustomerPhone.Text = "Điện thoại";
            this.lblCustomerPhone.Location = new System.Drawing.Point(340, 129);
            this.lblCustomerPhone.Size = new System.Drawing.Size(80, 23);
            // txtCustomerPhone
            this.txtCustomerPhone.Location = new System.Drawing.Point(460, 126);
            this.txtCustomerPhone.Size = new System.Drawing.Size(160, 23);

            // grpProduct
            this.grpProduct.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblProductId, this.cmbProductId,
                this.lblProductName, this.txtProductName,
                this.lblQuantity, this.txtQuantity,
                this.lblUnitPrice, this.txtUnitPrice,
                this.lblDiscount, this.txtDiscount,
                this.lblAmount, this.txtAmount,
                this.dgvDetail, this.lblRemoveHint, this.lblMoneyInWords,
                this.lblTotal, this.txtTotal
            });
            this.grpProduct.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.grpProduct.Location = new System.Drawing.Point(30, 260);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(820, 340);
            this.grpProduct.TabIndex = 2;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Thông tin các mặt hàng";

            // lblProductId
            this.lblProductId.Text = "Mã hàng";
            this.lblProductId.Location = new System.Drawing.Point(10, 30);
            this.lblProductId.Size = new System.Drawing.Size(65, 23);
            // cmbProductId
            this.cmbProductId.Location = new System.Drawing.Point(80, 27);
            this.cmbProductId.Size = new System.Drawing.Size(100, 23);

            // lblProductName
            this.lblProductName.Text = "Tên hàng";
            this.lblProductName.Location = new System.Drawing.Point(190, 30);
            this.lblProductName.Size = new System.Drawing.Size(70, 23);
            // txtProductName
            this.txtProductName.Location = new System.Drawing.Point(260, 27);
            this.txtProductName.Size = new System.Drawing.Size(120, 23);

            // lblQuantity
            this.lblQuantity.Text = "Số lượng";
            this.lblQuantity.Location = new System.Drawing.Point(390, 30);
            this.lblQuantity.Size = new System.Drawing.Size(60, 23);
            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(450, 27);
            this.txtQuantity.Size = new System.Drawing.Size(60, 23);

            // lblUnitPrice
            this.lblUnitPrice.Text = "Đơn giá";
            this.lblUnitPrice.Location = new System.Drawing.Point(520, 30);
            this.lblUnitPrice.Size = new System.Drawing.Size(60, 23);
            // txtUnitPrice
            this.txtUnitPrice.Location = new System.Drawing.Point(590, 27);
            this.txtUnitPrice.Size = new System.Drawing.Size(90, 23);

            // lblDiscount
            this.lblDiscount.Text = "Giảm giá %";
            this.lblDiscount.Location = new System.Drawing.Point(690, 30);
            this.lblDiscount.Size = new System.Drawing.Size(80, 23);
            // txtDiscount
            this.txtDiscount.Location = new System.Drawing.Point(770, 27);
            this.txtDiscount.Size = new System.Drawing.Size(40, 23);

            // lblAmount
            this.lblAmount.Text = "Thành tiền";
            this.lblAmount.Location = new System.Drawing.Point(10, 60);
            this.lblAmount.Size = new System.Drawing.Size(80, 23);
            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(100, 57);
            this.txtAmount.Size = new System.Drawing.Size(110, 23);
            this.txtAmount.ReadOnly = true;

            // dgvDetail
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(10, 90);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 24;
            this.dgvDetail.Size = new System.Drawing.Size(800, 120);
            this.dgvDetail.TabIndex = 22;

            // lblRemoveHint
            this.lblRemoveHint.ForeColor = System.Drawing.Color.Red;
            this.lblRemoveHint.Location = new System.Drawing.Point(10, 213);
            this.lblRemoveHint.Size = new System.Drawing.Size(280, 20);
            this.lblRemoveHint.Text = "Kích đúp một dòng để xóa";

            // lblMoneyInWords
            this.lblMoneyInWords.Location = new System.Drawing.Point(10, 235);
            this.lblMoneyInWords.Size = new System.Drawing.Size(500, 22);
            this.lblMoneyInWords.Text = "Bằng chữ: ...";

            // lblTotal
            this.lblTotal.Location = new System.Drawing.Point(650, 235);
            this.lblTotal.Size = new System.Drawing.Size(70, 22);
            this.lblTotal.Text = "Tổng tiền";

            // txtTotal
            this.txtTotal.Location = new System.Drawing.Point(730, 233);
            this.txtTotal.Size = new System.Drawing.Size(80, 22);
            this.txtTotal.ReadOnly = true;

            // btnAddInvoice
            this.btnAddInvoice.Location = new System.Drawing.Point(140, 615);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(100, 32);
            this.btnAddInvoice.TabIndex = 30;
            this.btnAddInvoice.Text = "Thêm hóa đơn";
            this.btnAddInvoice.UseVisualStyleBackColor = true;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(250, 615);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 32);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;

            // btnCancelInvoice
            this.btnCancelInvoice.Location = new System.Drawing.Point(340, 615);
            this.btnCancelInvoice.Name = "btnCancelInvoice";
            this.btnCancelInvoice.Size = new System.Drawing.Size(100, 32);
            this.btnCancelInvoice.TabIndex = 32;
            this.btnCancelInvoice.Text = "Hủy hóa đơn";
            this.btnCancelInvoice.UseVisualStyleBackColor = true;

            // btnPrint
            this.btnPrint.Location = new System.Drawing.Point(450, 615);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 32);
            this.btnPrint.TabIndex = 33;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.UseVisualStyleBackColor = true;

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(560, 615);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 32);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;

            // lblSearchInvoiceId
            this.lblSearchInvoiceId.Location = new System.Drawing.Point(30, 670);
            this.lblSearchInvoiceId.Size = new System.Drawing.Size(80, 22);
            this.lblSearchInvoiceId.Text = "Mã hóa đơn";

            // cmbSearchInvoiceId
            this.cmbSearchInvoiceId.Location = new System.Drawing.Point(120, 668);
            this.cmbSearchInvoiceId.Size = new System.Drawing.Size(230, 22);

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(360, 667);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 26);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;

            // ExportInvoiceScreen
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 710);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancelInvoice);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSearchInvoiceId);
            this.Controls.Add(this.cmbSearchInvoiceId);
            this.Controls.Add(this.btnSearch);
            this.Name = "ExportInvoiceScreen";
            this.Text = "Hóa đơn bán";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label lblInvoiceId;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.Label lblExportDate;
        private System.Windows.Forms.DateTimePicker dtpExportDate;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.ComboBox cmbEmployeeId;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.ComboBox cmbCustomerId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerPhone;
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