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
            btnSearch = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DeepSkyBlue;
            lblTitle.Location = new Point(340, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(236, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HÀNG HÓA";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new Font("Arial", 10F);
            lblProductId.Location = new Point(50, 112);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(107, 19);
            lblProductId.TabIndex = 1;
            lblProductId.Text = "Mã sản phẩm";
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Arial", 10F);
            txtProductId.Location = new Point(180, 109);
            txtProductId.Margin = new Padding(3, 4, 3, 4);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(200, 27);
            txtProductId.TabIndex = 2;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Arial", 10F);
            lblProductName.Location = new Point(50, 162);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(112, 19);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "Tên sản phẩm";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Arial", 10F);
            txtProductName.Location = new Point(180, 159);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 27);
            txtProductName.TabIndex = 4;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Arial", 10F);
            lblUnitPrice.Location = new Point(50, 212);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(100, 19);
            lblUnitPrice.TabIndex = 5;
            lblUnitPrice.Text = "Đơn giá bán";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Arial", 10F);
            txtUnitPrice.Location = new Point(180, 209);
            txtUnitPrice.Margin = new Padding(3, 4, 3, 4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(200, 27);
            txtUnitPrice.TabIndex = 6;
            // 
            // lblImportPrice
            // 
            lblImportPrice.AutoSize = true;
            lblImportPrice.Font = new Font("Arial", 10F);
            lblImportPrice.Location = new Point(50, 262);
            lblImportPrice.Name = "lblImportPrice";
            lblImportPrice.Size = new Size(109, 19);
            lblImportPrice.TabIndex = 7;
            lblImportPrice.Text = "Đơn giá nhập";
            // 
            // txtImportPrice
            // 
            txtImportPrice.Font = new Font("Arial", 10F);
            txtImportPrice.Location = new Point(180, 259);
            txtImportPrice.Margin = new Padding(3, 4, 3, 4);
            txtImportPrice.Name = "txtImportPrice";
            txtImportPrice.Size = new Size(200, 27);
            txtImportPrice.TabIndex = 8;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Arial", 10F);
            lblQuantity.Location = new Point(50, 312);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(77, 19);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Arial", 10F);
            txtQuantity.Location = new Point(180, 309);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 27);
            txtQuantity.TabIndex = 10;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Arial", 10F);
            lblBrand.Location = new Point(430, 112);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(103, 19);
            lblBrand.TabIndex = 11;
            lblBrand.Text = "Thương hiệu";
            // 
            // cmbBrand
            // 
            cmbBrand.Font = new Font("Arial", 10F);
            cmbBrand.Location = new Point(570, 109);
            cmbBrand.Margin = new Padding(3, 4, 3, 4);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(200, 27);
            cmbBrand.TabIndex = 12;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Arial", 10F);
            lblCategory.Location = new Point(430, 162);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(81, 19);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Loại hàng";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Arial", 10F);
            cmbCategory.Location = new Point(570, 159);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 27);
            cmbCategory.TabIndex = 14;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Arial", 10F);
            lblSupplier.Location = new Point(430, 212);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(111, 19);
            lblSupplier.TabIndex = 15;
            lblSupplier.Text = "Nhà cung cấp";
            // 
            // cmbSupplier
            // 
            cmbSupplier.Font = new Font("Arial", 10F);
            cmbSupplier.Location = new Point(570, 209);
            cmbSupplier.Margin = new Padding(3, 4, 3, 4);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(200, 27);
            cmbSupplier.TabIndex = 16;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Arial", 10F);
            lblNote.Location = new Point(430, 262);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(66, 19);
            lblNote.TabIndex = 17;
            lblNote.Text = "Ghi chú";
            // 
            // txtNote
            // 
            txtNote.Font = new Font("Arial", 10F);
            txtNote.Location = new Point(570, 259);
            txtNote.Margin = new Padding(3, 4, 3, 4);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(200, 27);
            txtNote.TabIndex = 18;
            // 
            // picProduct
            // 
            picProduct.Location = new Point(800, 109);
            picProduct.Margin = new Padding(3, 4, 3, 4);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(180, 150);
            picProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            picProduct.TabIndex = 22;
            picProduct.TabStop = false;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(12, 375);
            dgvProduct.Margin = new Padding(3, 4, 3, 4);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 24;
            dgvProduct.Size = new Size(970, 250);
            dgvProduct.TabIndex = 23;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(70, 650);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 38);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(170, 650);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(80, 38);
            btnEdit.TabIndex = 25;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(270, 650);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 38);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(570, 650);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 38);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(790, 650);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 38);
            btnExit.TabIndex = 31;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // ProductScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Controls.Add(btnSearch);
            Controls.Add(btnExit);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductScreen";
            Size = new Size(1000, 712);
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
    }
}