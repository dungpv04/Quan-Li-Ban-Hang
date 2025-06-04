namespace UI.ReportScreen
{
    partial class RevenueReportScreen
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
            this.lblTitle = new System.Windows.Forms.Label();

            // GroupBox cho tiêu chí thống kê
            this.grpCriteria = new System.Windows.Forms.GroupBox();
            this.rdoProduct = new System.Windows.Forms.RadioButton();
            this.rdoCategory = new System.Windows.Forms.RadioButton();
            this.rdoEmployee = new System.Windows.Forms.RadioButton();

            // GroupBox cho nhập tiêu chí
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();

            // GroupBox cho khoảng thời gian
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.rdoByDay = new System.Windows.Forms.RadioButton();
            this.dtpByDay = new System.Windows.Forms.DateTimePicker();
            this.rdoByRange = new System.Windows.Forms.RadioButton();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();

            // DataGridView kết quả
            this.dgvResult = new System.Windows.Forms.DataGridView();

            // Nút chức năng
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            // Label
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(110, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO DOANH THU";

            // grpCriteria
            this.grpCriteria.Controls.Add(this.rdoProduct);
            this.grpCriteria.Controls.Add(this.rdoCategory);
            this.grpCriteria.Controls.Add(this.rdoEmployee);
            this.grpCriteria.Font = new System.Drawing.Font("Arial", 10F);
            this.grpCriteria.Location = new System.Drawing.Point(48, 96);
            this.grpCriteria.Name = "grpCriteria";
            this.grpCriteria.Size = new System.Drawing.Size(225, 117);
            this.grpCriteria.TabIndex = 1;
            this.grpCriteria.TabStop = false;
            this.grpCriteria.Text = "Chọn tiêu chí thống kê";

            // rdoProduct
            this.rdoProduct.AutoSize = true;
            this.rdoProduct.Location = new System.Drawing.Point(18, 30);
            this.rdoProduct.Name = "rdoProduct";
            this.rdoProduct.Size = new System.Drawing.Size(94, 23);
            this.rdoProduct.TabIndex = 2;
            this.rdoProduct.TabStop = true;
            this.rdoProduct.Text = "Hàng hóa";
            this.rdoProduct.UseVisualStyleBackColor = true;

            // rdoCategory
            this.rdoCategory.AutoSize = true;
            this.rdoCategory.Location = new System.Drawing.Point(18, 59);
            this.rdoCategory.Name = "rdoCategory";
            this.rdoCategory.Size = new System.Drawing.Size(97, 23);
            this.rdoCategory.TabIndex = 3;
            this.rdoCategory.Text = "Loại hàng";
            this.rdoCategory.UseVisualStyleBackColor = true;

            // rdoEmployee
            this.rdoEmployee.AutoSize = true;
            this.rdoEmployee.Location = new System.Drawing.Point(18, 88);
            this.rdoEmployee.Name = "rdoEmployee";
            this.rdoEmployee.Size = new System.Drawing.Size(85, 23);
            this.rdoEmployee.TabIndex = 4;
            this.rdoEmployee.Text = "Nhân sự";
            this.rdoEmployee.UseVisualStyleBackColor = true;

            // grpInput
            this.grpInput.Controls.Add(this.lblProductId);
            this.grpInput.Controls.Add(this.txtProductId);
            this.grpInput.Controls.Add(this.lblCategoryId);
            this.grpInput.Controls.Add(this.txtCategoryId);
            this.grpInput.Controls.Add(this.lblEmployeeId);
            this.grpInput.Controls.Add(this.txtEmployeeId);
            this.grpInput.Font = new System.Drawing.Font("Arial", 10F);
            this.grpInput.Location = new System.Drawing.Point(290, 96);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(307, 117);
            this.grpInput.TabIndex = 5;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Phần nhập tiêu chí";

            // lblProductId
            this.lblProductId.Location = new System.Drawing.Point(15, 27);
            this.lblProductId.Text = "Mã hàng hóa";
            this.lblProductId.Size = new System.Drawing.Size(100, 23);

            // txtProductId
            this.txtProductId.Location = new System.Drawing.Point(130, 24);
            this.txtProductId.Size = new System.Drawing.Size(160, 23);

            // lblCategoryId
            this.lblCategoryId.Location = new System.Drawing.Point(15, 55);
            this.lblCategoryId.Text = "Mã loại hàng";
            this.lblCategoryId.Size = new System.Drawing.Size(100, 23);

            // txtCategoryId
            this.txtCategoryId.Location = new System.Drawing.Point(130, 52);
            this.txtCategoryId.Size = new System.Drawing.Size(160, 23);

            // lblEmployeeId
            this.lblEmployeeId.Location = new System.Drawing.Point(15, 83);
            this.lblEmployeeId.Text = "Mã nhân viên";
            this.lblEmployeeId.Size = new System.Drawing.Size(100, 23);

            // txtEmployeeId
            this.txtEmployeeId.Location = new System.Drawing.Point(130, 80);
            this.txtEmployeeId.Size = new System.Drawing.Size(160, 23);

            // grpTime
            this.grpTime.Controls.Add(this.rdoByDay);
            this.grpTime.Controls.Add(this.dtpByDay);
            this.grpTime.Controls.Add(this.rdoByRange);
            this.grpTime.Controls.Add(this.dtpFromDate);
            this.grpTime.Controls.Add(this.lblFrom);
            this.grpTime.Controls.Add(this.dtpToDate);
            this.grpTime.Controls.Add(this.lblTo);
            this.grpTime.Font = new System.Drawing.Font("Arial", 10F);
            this.grpTime.Location = new System.Drawing.Point(48, 225);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(549, 77);
            this.grpTime.TabIndex = 6;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Khoảng thời gian";

            // rdoByDay
            this.rdoByDay.AutoSize = true;
            this.rdoByDay.Location = new System.Drawing.Point(17, 32);
            this.rdoByDay.Name = "rdoByDay";
            this.rdoByDay.Size = new System.Drawing.Size(92, 23);
            this.rdoByDay.TabIndex = 7;
            this.rdoByDay.TabStop = true;
            this.rdoByDay.Text = "Theo ngày:";
            this.rdoByDay.UseVisualStyleBackColor = true;

            // dtpByDay
            this.dtpByDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpByDay.CustomFormat = "dd/MM/yyyy";
            this.dtpByDay.Location = new System.Drawing.Point(115, 31);
            this.dtpByDay.Name = "dtpByDay";
            this.dtpByDay.Size = new System.Drawing.Size(95, 23);

            // rdoByRange
            this.rdoByRange.AutoSize = true;
            this.rdoByRange.Location = new System.Drawing.Point(225, 32);
            this.rdoByRange.Name = "rdoByRange";
            this.rdoByRange.Size = new System.Drawing.Size(109, 23);
            this.rdoByRange.TabIndex = 8;
            this.rdoByRange.Text = "Theo khoảng:";
            this.rdoByRange.UseVisualStyleBackColor = true;

            // lblFrom
            this.lblFrom.Location = new System.Drawing.Point(335, 35);
            this.lblFrom.Size = new System.Drawing.Size(25, 15);
            this.lblFrom.Text = "Từ:";

            // dtpFromDate
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Location = new System.Drawing.Point(360, 31);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(95, 23);

            // lblTo
            this.lblTo.Location = new System.Drawing.Point(460, 35);
            this.lblTo.Size = new System.Drawing.Size(36, 15);
            this.lblTo.Text = "Đến:";

            // dtpToDate
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Location = new System.Drawing.Point(495, 31);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(95, 23);

            // dgvResult
            this.dgvResult.Location = new System.Drawing.Point(48, 320);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(560, 200);

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(130, 540);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;

            // btnShow
            this.btnShow.Location = new System.Drawing.Point(230, 540);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(90, 32);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Hiển thị";
            this.btnShow.UseVisualStyleBackColor = true;

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(330, 540);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(430, 540);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 32);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;

            // RevenueReportScreen
            this.ClientSize = new System.Drawing.Size(657, 600);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpCriteria);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Name = "RevenueReportScreen";
            this.Text = "BÁO CÁO DOANH THU";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.RadioButton rdoProduct;
        private System.Windows.Forms.RadioButton rdoCategory;
        private System.Windows.Forms.RadioButton rdoEmployee;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.RadioButton rdoByDay;
        private System.Windows.Forms.DateTimePicker dtpByDay;
        private System.Windows.Forms.RadioButton rdoByRange;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
    }
}