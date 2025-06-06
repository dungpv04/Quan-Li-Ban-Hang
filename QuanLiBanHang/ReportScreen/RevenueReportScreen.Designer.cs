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
            lblTitle = new Label();
            grpCriteria = new GroupBox();
            rdoProduct = new RadioButton();
            rdoCategory = new RadioButton();
            rdoEmployee = new RadioButton();
            grpInput = new GroupBox();
            lblProductId = new Label();
            txtProductId = new TextBox();
            lblCategoryId = new Label();
            txtCategoryId = new TextBox();
            lblEmployeeId = new Label();
            txtEmployeeId = new TextBox();
            grpTime = new GroupBox();
            rdoByDay = new RadioButton();
            dtpByDay = new DateTimePicker();
            rdoByRange = new RadioButton();
            dtpFromDate = new DateTimePicker();
            lblFrom = new Label();
            dtpToDate = new DateTimePicker();
            lblTo = new Label();
            dgvResult = new DataGridView();
            btnSearch = new Button();
            btnShow = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            grpCriteria.SuspendLayout();
            grpInput.SuspendLayout();
            grpTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DodgerBlue;
            lblTitle.Location = new Point(110, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(458, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BÁO CÁO DOANH THU";
            // 
            // grpCriteria
            // 
            grpCriteria.Controls.Add(rdoProduct);
            grpCriteria.Controls.Add(rdoCategory);
            grpCriteria.Controls.Add(rdoEmployee);
            grpCriteria.Font = new Font("Arial", 10F);
            grpCriteria.Location = new Point(48, 96);
            grpCriteria.Name = "grpCriteria";
            grpCriteria.Size = new Size(225, 117);
            grpCriteria.TabIndex = 1;
            grpCriteria.TabStop = false;
            grpCriteria.Text = "Chọn tiêu chí thống kê";
            // 
            // rdoProduct
            // 
            rdoProduct.AutoSize = true;
            rdoProduct.Location = new Point(18, 30);
            rdoProduct.Name = "rdoProduct";
            rdoProduct.Size = new Size(100, 23);
            rdoProduct.TabIndex = 2;
            rdoProduct.TabStop = true;
            rdoProduct.Text = "Hàng hóa";
            rdoProduct.UseVisualStyleBackColor = true;
            // 
            // rdoCategory
            // 
            rdoCategory.AutoSize = true;
            rdoCategory.Location = new Point(18, 59);
            rdoCategory.Name = "rdoCategory";
            rdoCategory.Size = new Size(102, 23);
            rdoCategory.TabIndex = 3;
            rdoCategory.Text = "Loại hàng";
            rdoCategory.UseVisualStyleBackColor = true;
            // 
            // rdoEmployee
            // 
            rdoEmployee.AutoSize = true;
            rdoEmployee.Location = new Point(18, 88);
            rdoEmployee.Name = "rdoEmployee";
            rdoEmployee.Size = new Size(92, 23);
            rdoEmployee.TabIndex = 4;
            rdoEmployee.Text = "Nhân sự";
            rdoEmployee.UseVisualStyleBackColor = true;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(lblProductId);
            grpInput.Controls.Add(txtProductId);
            grpInput.Controls.Add(lblCategoryId);
            grpInput.Controls.Add(txtCategoryId);
            grpInput.Controls.Add(lblEmployeeId);
            grpInput.Controls.Add(txtEmployeeId);
            grpInput.Font = new Font("Arial", 10F);
            grpInput.Location = new Point(290, 96);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(307, 117);
            grpInput.TabIndex = 5;
            grpInput.TabStop = false;
            grpInput.Text = "Phần nhập tiêu chí";
            // 
            // lblProductId
            // 
            lblProductId.Location = new Point(15, 27);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(100, 23);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã hàng hóa";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(130, 24);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(160, 27);
            txtProductId.TabIndex = 1;
            // 
            // lblCategoryId
            // 
            lblCategoryId.Location = new Point(15, 55);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(100, 23);
            lblCategoryId.TabIndex = 2;
            lblCategoryId.Text = "Mã loại hàng";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(130, 52);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(160, 27);
            txtCategoryId.TabIndex = 3;
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.Location = new Point(15, 83);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(100, 23);
            lblEmployeeId.TabIndex = 4;
            lblEmployeeId.Text = "Mã nhân viên";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(130, 80);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(160, 27);
            txtEmployeeId.TabIndex = 5;
            // 
            // grpTime
            // 
            grpTime.Controls.Add(rdoByDay);
            grpTime.Controls.Add(dtpByDay);
            grpTime.Controls.Add(rdoByRange);
            grpTime.Controls.Add(dtpFromDate);
            grpTime.Controls.Add(lblFrom);
            grpTime.Controls.Add(dtpToDate);
            grpTime.Controls.Add(lblTo);
            grpTime.Font = new Font("Arial", 10F);
            grpTime.Location = new Point(48, 225);
            grpTime.Name = "grpTime";
            grpTime.Size = new Size(549, 77);
            grpTime.TabIndex = 6;
            grpTime.TabStop = false;
            grpTime.Text = "Khoảng thời gian";
            // 
            // rdoByDay
            // 
            rdoByDay.AutoSize = true;
            rdoByDay.Location = new Point(17, 32);
            rdoByDay.Name = "rdoByDay";
            rdoByDay.Size = new Size(112, 23);
            rdoByDay.TabIndex = 7;
            rdoByDay.TabStop = true;
            rdoByDay.Text = "Theo ngày:";
            rdoByDay.UseVisualStyleBackColor = true;
            // 
            // dtpByDay
            // 
            dtpByDay.CustomFormat = "dd/MM/yyyy";
            dtpByDay.Format = DateTimePickerFormat.Custom;
            dtpByDay.Location = new Point(115, 31);
            dtpByDay.Name = "dtpByDay";
            dtpByDay.Size = new Size(95, 27);
            dtpByDay.TabIndex = 8;
            // 
            // rdoByRange
            // 
            rdoByRange.AutoSize = true;
            rdoByRange.Location = new Point(225, 32);
            rdoByRange.Name = "rdoByRange";
            rdoByRange.Size = new Size(129, 23);
            rdoByRange.TabIndex = 8;
            rdoByRange.Text = "Theo khoảng:";
            rdoByRange.UseVisualStyleBackColor = true;
            // 
            // dtpFromDate
            // 
            dtpFromDate.CustomFormat = "dd/MM/yyyy";
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.Location = new Point(360, 31);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(95, 27);
            dtpFromDate.TabIndex = 9;
            // 
            // lblFrom
            // 
            lblFrom.Location = new Point(335, 35);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(25, 15);
            lblFrom.TabIndex = 10;
            lblFrom.Text = "Từ:";
            // 
            // dtpToDate
            // 
            dtpToDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Location = new Point(495, 31);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(95, 27);
            dtpToDate.TabIndex = 11;
            // 
            // lblTo
            // 
            lblTo.Location = new Point(460, 35);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(36, 15);
            lblTo.TabIndex = 12;
            lblTo.Text = "Đến:";
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeight = 29;
            dgvResult.Location = new Point(48, 320);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(560, 200);
            dgvResult.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(130, 540);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 32);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(230, 540);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(90, 32);
            btnShow.TabIndex = 10;
            btnShow.Text = "Hiển thị";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(330, 540);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 32);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(430, 540);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 32);
            btnExit.TabIndex = 12;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // RevenueReportScreen
            // 
            Controls.Add(lblTitle);
            Controls.Add(grpCriteria);
            Controls.Add(grpInput);
            Controls.Add(grpTime);
            Controls.Add(dgvResult);
            Controls.Add(btnSearch);
            Controls.Add(btnShow);
            Controls.Add(btnCancel);
            Controls.Add(btnExit);
            Name = "RevenueReportScreen";
            Size = new Size(657, 600);
            grpCriteria.ResumeLayout(false);
            grpCriteria.PerformLayout();
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            grpTime.ResumeLayout(false);
            grpTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
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