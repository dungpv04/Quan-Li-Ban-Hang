namespace UI
{
    partial class EmployeeScreen
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
            lblEmployeeId = new Label();
            lblEmployeeName = new Label();
            lblAddress = new Label();
            lblBirthDate = new Label();
            lblPhone = new Label();
            lblGender = new Label();
            txtEmployeeId = new TextBox();
            txtEmployeeName = new TextBox();
            txtAddress = new TextBox();
            dtpBirthDate = new DateTimePicker();
            txtPhone = new TextBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            dgvEmployee = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DodgerBlue;
            lblTitle.Location = new Point(166, 56);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(187, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "NHÂN VIÊN";
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Font = new Font("Arial", 11F);
            lblEmployeeId.Location = new Point(101, 127);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(93, 17);
            lblEmployeeId.TabIndex = 1;
            lblEmployeeId.Text = "Mã nhân viên";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Arial", 11F);
            lblEmployeeName.Location = new Point(101, 159);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(99, 17);
            lblEmployeeName.TabIndex = 3;
            lblEmployeeName.Text = "Tên nhân viên";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Arial", 11F);
            lblAddress.Location = new Point(101, 192);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(53, 17);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Arial", 11F);
            lblBirthDate.Location = new Point(411, 127);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(72, 17);
            lblBirthDate.TabIndex = 7;
            lblBirthDate.Text = "Ngày sinh";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Arial", 11F);
            lblPhone.Location = new Point(411, 164);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(92, 17);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Số điện thoại";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Arial", 11F);
            lblGender.Location = new Point(411, 202);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(62, 17);
            lblGender.TabIndex = 11;
            lblGender.Text = "Giới tính";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Font = new Font("Arial", 11F);
            txtEmployeeId.Location = new Point(201, 124);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(176, 24);
            txtEmployeeId.TabIndex = 2;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Arial", 11F);
            txtEmployeeName.Location = new Point(201, 157);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(176, 24);
            txtEmployeeName.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 11F);
            txtAddress.Location = new Point(201, 189);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(176, 24);
            txtAddress.TabIndex = 6;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Font = new Font("Arial", 11F);
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(499, 124);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(140, 24);
            dtpBirthDate.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 11F);
            txtPhone.Location = new Point(499, 161);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(140, 24);
            txtPhone.TabIndex = 10;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Font = new Font("Arial", 10F);
            rdoMale.Location = new Point(499, 202);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(53, 20);
            rdoMale.TabIndex = 12;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Font = new Font("Arial", 10F);
            rdoFemale.Location = new Point(565, 202);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(43, 20);
            rdoFemale.TabIndex = 13;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(101, 244);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 24;
            dgvEmployee.Size = new Size(538, 169);
            dgvEmployee.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 10F);
            btnAdd.Location = new Point(101, 441);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 30);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial", 10F);
            btnEdit.Location = new Point(179, 441);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(70, 30);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 10F);
            btnDelete.Location = new Point(258, 441);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 30);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // EmployeeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitle);
            Controls.Add(lblEmployeeId);
            Controls.Add(txtEmployeeId);
            Controls.Add(lblEmployeeName);
            Controls.Add(txtEmployeeName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblBirthDate);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblGender);
            Controls.Add(rdoMale);
            Controls.Add(rdoFemale);
            Controls.Add(dgvEmployee);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Name = "EmployeeScreen";
            Size = new Size(744, 506);
            Load += EmployeeScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}