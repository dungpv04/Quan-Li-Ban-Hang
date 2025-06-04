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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBrandId = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.txtBrandId = new System.Windows.Forms.TextBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.dgvBrand = new System.Windows.Forms.DataGridView();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.picBrand = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrand)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(350, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THƯƠNG HIỆU";

            // lblBrandId
            this.lblBrandId.AutoSize = true;
            this.lblBrandId.Font = new System.Drawing.Font("Arial", 11F);
            this.lblBrandId.Location = new System.Drawing.Point(50, 120);
            this.lblBrandId.Name = "lblBrandId";
            this.lblBrandId.Size = new System.Drawing.Size(120, 22);
            this.lblBrandId.TabIndex = 1;
            this.lblBrandId.Text = "Mã thương hiệu";

            // txtBrandId
            this.txtBrandId.Font = new System.Drawing.Font("Arial", 11F);
            this.txtBrandId.Location = new System.Drawing.Point(200, 117);
            this.txtBrandId.Name = "txtBrandId";
            this.txtBrandId.Size = new System.Drawing.Size(250, 29);
            this.txtBrandId.TabIndex = 2;

            // lblBrandName
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Arial", 11F);
            this.lblBrandName.Location = new System.Drawing.Point(50, 155);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(127, 22);
            this.lblBrandName.TabIndex = 3;
            this.lblBrandName.Text = "Tên thương hiệu";

            // txtBrandName
            this.txtBrandName.Font = new System.Drawing.Font("Arial", 11F);
            this.txtBrandName.Location = new System.Drawing.Point(200, 152);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(250, 29);
            this.txtBrandName.TabIndex = 4;

            // lblCountry
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Arial", 11F);
            this.lblCountry.Location = new System.Drawing.Point(50, 190);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(76, 22);
            this.lblCountry.TabIndex = 5;
            this.lblCountry.Text = "Quốc gia";

            // txtCountry
            this.txtCountry.Font = new System.Drawing.Font("Arial", 11F);
            this.txtCountry.Location = new System.Drawing.Point(200, 187);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(250, 29);
            this.txtCountry.TabIndex = 6;

            // lblWebsite
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Font = new System.Drawing.Font("Arial", 11F);
            this.lblWebsite.Location = new System.Drawing.Point(50, 225);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(68, 22);
            this.lblWebsite.TabIndex = 7;
            this.lblWebsite.Text = "Website";

            // txtWebsite
            this.txtWebsite.Font = new System.Drawing.Font("Arial", 11F);
            this.txtWebsite.Location = new System.Drawing.Point(200, 222);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(250, 29);
            this.txtWebsite.TabIndex = 8;

            // picBrand
            this.picBrand.Location = new System.Drawing.Point(540, 90);
            this.picBrand.Name = "picBrand";
            this.picBrand.Size = new System.Drawing.Size(230, 120);
            this.picBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBrand.TabIndex = 9;
            this.picBrand.TabStop = false;

            // lblImage
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Arial", 11F);
            this.lblImage.Location = new System.Drawing.Point(500, 225);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(36, 22);
            this.lblImage.TabIndex = 10;
            this.lblImage.Text = "Ảnh";

            // txtImage
            this.txtImage.Font = new System.Drawing.Font("Arial", 11F);
            this.txtImage.Location = new System.Drawing.Point(540, 222);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(170, 29);
            this.txtImage.TabIndex = 11;

            // btnOpenImage
            this.btnOpenImage.Font = new System.Drawing.Font("Arial", 10F);
            this.btnOpenImage.Location = new System.Drawing.Point(720, 222);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(60, 29);
            this.btnOpenImage.TabIndex = 12;
            this.btnOpenImage.Text = "Open";
            this.btnOpenImage.UseVisualStyleBackColor = true;

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 11F);
            this.lblDescription.Location = new System.Drawing.Point(500, 262);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(53, 22);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Mô tả";

            // txtDescription
            this.txtDescription.Font = new System.Drawing.Font("Arial", 11F);
            this.txtDescription.Location = new System.Drawing.Point(540, 259);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(240, 80);
            this.txtDescription.TabIndex = 14;

            // dgvBrand
            this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrand.Location = new System.Drawing.Point(40, 300);
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.RowHeadersWidth = 51;
            this.dgvBrand.RowTemplate.Height = 24;
            this.dgvBrand.Size = new System.Drawing.Size(440, 200);
            this.dgvBrand.TabIndex = 15;

            // btnAdd
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAdd.Location = new System.Drawing.Point(40, 520);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 32);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;

            // btnEdit
            this.btnEdit.Font = new System.Drawing.Font("Arial", 10F);
            this.btnEdit.Location = new System.Drawing.Point(130, 520);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 32);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;

            // btnDelete
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F);
            this.btnDelete.Location = new System.Drawing.Point(220, 520);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 32);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;

            // btnSave
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSave.Location = new System.Drawing.Point(310, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 32);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;

            // btnCancel
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCancel.Location = new System.Drawing.Point(400, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 32);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = true;

            // btnExit
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F);
            this.btnExit.Location = new System.Drawing.Point(490, 520);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 32);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;

            // BrandScreen
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 570);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBrandId);
            this.Controls.Add(this.txtBrandId);
            this.Controls.Add(this.lblBrandName);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.picBrand);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dgvBrand);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Name = "BrandScreen";
            this.Text = "Thương hiệu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.PictureBox picBrand;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button btnOpenImage;
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