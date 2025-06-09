namespace UI
{
    partial class BrandScreen
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
            lblBrandId = new Label();
            lblBrandName = new Label();
            lblCountry = new Label();
            lblWebsite = new Label();
            txtBrandId = new TextBox();
            txtBrandName = new TextBox();
            txtCountry = new TextBox();
            txtWebsite = new TextBox();
            dgvBrand = new DataGridView();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBrand).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DodgerBlue;
            lblTitle.Location = new Point(260, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(306, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THƯƠNG HIỆU";
            // 
            // lblBrandId
            // 
            lblBrandId.AutoSize = true;
            lblBrandId.Font = new Font("Arial", 11F);
            lblBrandId.Location = new Point(13, 77);
            lblBrandId.Name = "lblBrandId";
            lblBrandId.Size = new Size(141, 22);
            lblBrandId.TabIndex = 1;
            lblBrandId.Text = "Mã thương hiệu";
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Arial", 11F);
            lblBrandName.Location = new Point(13, 121);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(149, 22);
            lblBrandName.TabIndex = 3;
            lblBrandName.Text = "Tên thương hiệu";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Arial", 11F);
            lblCountry.Location = new Point(13, 165);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(86, 22);
            lblCountry.TabIndex = 5;
            lblCountry.Text = "Quốc gia";
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Font = new Font("Arial", 11F);
            lblWebsite.Location = new Point(13, 208);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(81, 22);
            lblWebsite.TabIndex = 7;
            lblWebsite.Text = "Website";
            // 
            // txtBrandId
            // 
            txtBrandId.Font = new Font("Arial", 11F);
            txtBrandId.Location = new Point(169, 74);
            txtBrandId.Margin = new Padding(3, 4, 3, 4);
            txtBrandId.Name = "txtBrandId";
            txtBrandId.Size = new Size(276, 29);
            txtBrandId.TabIndex = 2;
            // 
            // txtBrandName
            // 
            txtBrandName.Font = new Font("Arial", 11F);
            txtBrandName.Location = new Point(169, 118);
            txtBrandName.Margin = new Padding(3, 4, 3, 4);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(276, 29);
            txtBrandName.TabIndex = 4;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Arial", 11F);
            txtCountry.Location = new Point(169, 162);
            txtCountry.Margin = new Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(276, 29);
            txtCountry.TabIndex = 6;
            // 
            // txtWebsite
            // 
            txtWebsite.Font = new Font("Arial", 11F);
            txtWebsite.Location = new Point(169, 206);
            txtWebsite.Margin = new Padding(3, 4, 3, 4);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(276, 29);
            txtWebsite.TabIndex = 8;
            // 
            // dgvBrand
            // 
            dgvBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBrand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrand.Location = new Point(12, 263);
            dgvBrand.Margin = new Padding(3, 4, 3, 4);
            dgvBrand.Name = "dgvBrand";
            dgvBrand.RowHeadersWidth = 51;
            dgvBrand.RowTemplate.Height = 24;
            dgvBrand.Size = new Size(796, 250);
            dgvBrand.TabIndex = 15;
            dgvBrand.CellClick += dgvBrand_CellClick;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Arial", 11F);
            lblDescription.Location = new Point(485, 74);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(56, 22);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Mô tả";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Arial", 11F);
            txtDescription.Location = new Point(485, 118);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(323, 117);
            txtDescription.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 10F);
            btnAdd.Location = new Point(139, 533);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 40);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial", 10F);
            btnEdit.Location = new Point(229, 533);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(80, 40);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 10F);
            btnDelete.Location = new Point(319, 533);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 40);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 10F);
            btnSave.Location = new Point(409, 533);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 40);
            btnSave.TabIndex = 19;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Arial", 10F);
            btnCancel.Location = new Point(499, 533);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 40);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Bỏ qua";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial", 10F);
            btnExit.Location = new Point(589, 533);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 40);
            btnExit.TabIndex = 21;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // BrandScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitle);
            Controls.Add(lblBrandId);
            Controls.Add(txtBrandId);
            Controls.Add(lblBrandName);
            Controls.Add(txtBrandName);
            Controls.Add(lblCountry);
            Controls.Add(txtCountry);
            Controls.Add(lblWebsite);
            Controls.Add(txtWebsite);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(dgvBrand);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnExit);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BrandScreen";
            Size = new Size(820, 590);
            Load += BrandScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBrand).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBrandId;
        private System.Windows.Forms.TextBox txtBrandId;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dgvBrand;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
    }
}