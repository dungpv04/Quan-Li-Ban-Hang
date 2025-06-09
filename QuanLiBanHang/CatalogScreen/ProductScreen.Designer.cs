namespace UI
{
    partial class ProductScreen
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
            lblProductId = new Label();
            txtProductId = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblImportPrice = new Label();
            txtImportPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblBrand = new Label();
            cmbBrand = new ComboBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblSupplier = new Label();
            cmbSupplier = new ComboBox();
            lblNote = new Label();
            txtNote = new TextBox();
            picProduct = new PictureBox();
            dgvProduct = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DeepSkyBlue;
            lblTitle.Location = new Point(298, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(187, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HÀNG HÓA";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new Font("Arial", 10F);
            lblProductId.Location = new Point(44, 84);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(62, 16);
            lblProductId.TabIndex = 1;
            lblProductId.Text = "Mã hàng";
            lblProductId.Click += lblProductId_Click;
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Arial", 10F);
            txtProductId.Location = new Point(158, 82);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(176, 23);
            txtProductId.TabIndex = 2;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Arial", 10F);
            lblProductName.Location = new Point(44, 122);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(68, 16);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "Tên hàng";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Arial", 10F);
            txtProductName.Location = new Point(158, 119);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(176, 23);
            txtProductName.TabIndex = 4;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Arial", 10F);
            lblUnitPrice.Location = new Point(44, 159);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(85, 16);
            lblUnitPrice.TabIndex = 5;
            lblUnitPrice.Text = "Đơn giá bán";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Arial", 10F);
            txtUnitPrice.Location = new Point(158, 157);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(176, 23);
            txtUnitPrice.TabIndex = 6;
            // 
            // lblImportPrice
            // 
            lblImportPrice.AutoSize = true;
            lblImportPrice.Font = new Font("Arial", 10F);
            lblImportPrice.Location = new Point(44, 196);
            lblImportPrice.Name = "lblImportPrice";
            lblImportPrice.Size = new Size(93, 16);
            lblImportPrice.TabIndex = 7;
            lblImportPrice.Text = "Đơn giá nhập";
            // 
            // txtImportPrice
            // 
            txtImportPrice.Font = new Font("Arial", 10F);
            txtImportPrice.Location = new Point(158, 194);
            txtImportPrice.Name = "txtImportPrice";
            txtImportPrice.Size = new Size(176, 23);
            txtImportPrice.TabIndex = 8;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Arial", 10F);
            lblQuantity.Location = new Point(44, 234);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 16);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Arial", 10F);
            txtQuantity.Location = new Point(158, 232);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(176, 23);
            txtQuantity.TabIndex = 10;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Arial", 10F);
            lblBrand.Location = new Point(376, 84);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(89, 16);
            lblBrand.TabIndex = 11;
            lblBrand.Text = "Thương hiệu";
            // 
            // cmbBrand
            // 
            cmbBrand.Font = new Font("Arial", 10F);
            cmbBrand.Location = new Point(499, 82);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(176, 24);
            cmbBrand.TabIndex = 12;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Arial", 10F);
            lblCategory.Location = new Point(376, 122);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(70, 16);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Loại hàng";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Arial", 10F);
            cmbCategory.Location = new Point(499, 119);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(176, 24);
            cmbCategory.TabIndex = 14;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Arial", 10F);
            lblSupplier.Location = new Point(376, 159);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(94, 16);
            lblSupplier.TabIndex = 15;
            lblSupplier.Text = "Nhà cung cấp";
            // 
            // cmbSupplier
            // 
            cmbSupplier.Font = new Font("Arial", 10F);
            cmbSupplier.Location = new Point(499, 157);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(176, 24);
            cmbSupplier.TabIndex = 16;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Arial", 10F);
            lblNote.Location = new Point(376, 196);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(56, 16);
            lblNote.TabIndex = 17;
            lblNote.Text = "Ghi chú";
            // 
            // txtNote
            // 
            txtNote.Font = new Font("Arial", 10F);
            txtNote.Location = new Point(499, 194);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(176, 23);
            txtNote.TabIndex = 18;
            // 
            // picProduct
            // 
            picProduct.Location = new Point(700, 82);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(158, 112);
            picProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            picProduct.TabIndex = 22;
            picProduct.TabStop = false;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(10, 281);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 24;
            dgvProduct.Size = new Size(849, 188);
            dgvProduct.TabIndex = 23;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(61, 488);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 28);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(149, 488);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(70, 28);
            btnEdit.TabIndex = 25;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(236, 488);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 28);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ProductScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitle);
            Controls.Add(lblProductId);
            Controls.Add(txtProductId);
            Controls.Add(lblProductName);
            Controls.Add(txtProductName);
            Controls.Add(lblUnitPrice);
            Controls.Add(txtUnitPrice);
            Controls.Add(lblImportPrice);
            Controls.Add(txtImportPrice);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(lblBrand);
            Controls.Add(cmbBrand);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblSupplier);
            Controls.Add(cmbSupplier);
            Controls.Add(lblNote);
            Controls.Add(txtNote);
            Controls.Add(picProduct);
            Controls.Add(dgvProduct);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Name = "ProductScreen";
            Size = new Size(875, 534);
            //Load += this.ProductScreen_Load_1;
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblImportPrice;
        private System.Windows.Forms.TextBox txtImportPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}