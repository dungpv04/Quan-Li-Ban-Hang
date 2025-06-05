namespace UI
{
    partial class SupplierScreen
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
            lblSupplierId = new Label();
            lblSupplierName = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            txtSupplierId = new TextBox();
            txtSupplierName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            dgvSupplier = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DodgerBlue;
            lblTitle.Location = new Point(210, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "NHÀ CUNG CẤP";
            // 
            // lblSupplierId
            // 
            lblSupplierId.AutoSize = true;
            lblSupplierId.Font = new Font("Arial", 11F);
            lblSupplierId.Location = new Point(40, 137);
            lblSupplierId.Name = "lblSupplierId";
            lblSupplierId.Size = new Size(81, 22);
            lblSupplierId.TabIndex = 1;
            lblSupplierId.Text = "Mã NCC";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Arial", 11F);
            lblSupplierName.Location = new Point(40, 188);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(89, 22);
            lblSupplierName.TabIndex = 3;
            lblSupplierName.Text = "Tên NCC";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Arial", 11F);
            lblAddress.Location = new Point(379, 137);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(67, 22);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Arial", 11F);
            lblPhone.Location = new Point(379, 188);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(94, 22);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Điện thoại";
            // 
            // txtSupplierId
            // 
            txtSupplierId.Font = new Font("Arial", 11F);
            txtSupplierId.Location = new Point(150, 133);
            txtSupplierId.Margin = new Padding(3, 4, 3, 4);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(170, 29);
            txtSupplierId.TabIndex = 2;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Arial", 11F);
            txtSupplierName.Location = new Point(150, 184);
            txtSupplierName.Margin = new Padding(3, 4, 3, 4);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(170, 29);
            txtSupplierName.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 11F);
            txtAddress.Location = new Point(474, 133);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(210, 29);
            txtAddress.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 11F);
            txtPhone.Location = new Point(474, 184);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(210, 29);
            txtPhone.TabIndex = 8;
            // 
            // dgvSupplier
            // 
            dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new Point(35, 251);
            dgvSupplier.Margin = new Padding(3, 4, 3, 4);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.RowTemplate.Height = 24;
            dgvSupplier.Size = new Size(650, 225);
            dgvSupplier.TabIndex = 9;
            dgvSupplier.CellClick += dgvSupplier_CellClick;
            dgvSupplier.CellContentClick += dgvSupplier_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 10F);
            btnAdd.Location = new Point(84, 504);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 40);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial", 10F);
            btnEdit.Location = new Point(175, 504);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(85, 40);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 10F);
            btnDelete.Location = new Point(266, 504);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 40);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 10F);
            btnSave.Location = new Point(357, 504);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 40);
            btnSave.TabIndex = 13;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Arial", 10F);
            btnCancel.Location = new Point(448, 504);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 40);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Bỏ qua";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial", 10F);
            btnExit.Location = new Point(539, 504);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(85, 40);
            btnExit.TabIndex = 15;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // SupplierScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitle);
            Controls.Add(lblSupplierId);
            Controls.Add(txtSupplierId);
            Controls.Add(lblSupplierName);
            Controls.Add(txtSupplierName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(dgvSupplier);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnExit);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SupplierScreen";
            Size = new Size(720, 588);
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
    }
}
