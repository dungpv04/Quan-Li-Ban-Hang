namespace UI
{
    partial class ProductTypeScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblMaLoai = new Label();
            lblTenLoai = new Label();
            lblMoTa = new Label();
            txtMaLoai = new TextBox();
            txtTenLoai = new TextBox();
            txtMoTa = new TextBox();
            dgvLoaiHang = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiHang).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DodgerBlue;
            lblTitle.Location = new Point(220, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(241, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LOẠI HÀNG";
            // 
            // lblMaLoai
            // 
            lblMaLoai.AutoSize = true;
            lblMaLoai.BackColor = Color.White;
            lblMaLoai.Font = new Font("Arial", 12F);
            lblMaLoai.Location = new Point(67, 119);
            lblMaLoai.Name = "lblMaLoai";
            lblMaLoai.Size = new Size(122, 23);
            lblMaLoai.TabIndex = 1;
            lblMaLoai.Text = "Mã loại hàng";
            // 
            // lblTenLoai
            // 
            lblTenLoai.AutoSize = true;
            lblTenLoai.BackColor = Color.White;
            lblTenLoai.Font = new Font("Arial", 12F);
            lblTenLoai.Location = new Point(67, 171);
            lblTenLoai.Name = "lblTenLoai";
            lblTenLoai.Size = new Size(127, 23);
            lblTenLoai.TabIndex = 2;
            lblTenLoai.Text = "Tên loại hàng";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.BackColor = Color.White;
            lblMoTa.Font = new Font("Arial", 12F);
            lblMoTa.Location = new Point(67, 224);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(61, 23);
            lblMoTa.TabIndex = 3;
            lblMoTa.Text = "Mô tả";
            // 
            // txtMaLoai
            // 
            txtMaLoai.Font = new Font("Arial", 12F);
            txtMaLoai.Location = new Point(210, 115);
            txtMaLoai.Margin = new Padding(3, 4, 3, 4);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(315, 30);
            txtMaLoai.TabIndex = 4;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Font = new Font("Arial", 12F);
            txtTenLoai.Location = new Point(210, 168);
            txtTenLoai.Margin = new Padding(3, 4, 3, 4);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(315, 30);
            txtTenLoai.TabIndex = 5;
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Arial", 12F);
            txtMoTa.Location = new Point(210, 220);
            txtMoTa.Margin = new Padding(3, 4, 3, 4);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(315, 30);
            txtMoTa.TabIndex = 6;
            // 
            // dgvLoaiHang
            // 
            dgvLoaiHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiHang.Location = new Point(65, 300);
            dgvLoaiHang.Margin = new Padding(3, 4, 3, 4);
            dgvLoaiHang.Name = "dgvLoaiHang";
            dgvLoaiHang.RowHeadersWidth = 51;
            dgvLoaiHang.RowTemplate.Height = 24;
            dgvLoaiHang.Size = new Size(550, 188);
            dgvLoaiHang.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Arial", 10F);
            btnThem.Location = new Point(65, 512);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 44);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Arial", 10F);
            btnSua.Location = new Point(170, 512);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 44);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Arial", 10F);
            btnXoa.Location = new Point(275, 512);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 44);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // ProductTypeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitle);
            Controls.Add(lblMaLoai);
            Controls.Add(lblTenLoai);
            Controls.Add(lblMoTa);
            Controls.Add(txtMaLoai);
            Controls.Add(txtTenLoai);
            Controls.Add(txtMoTa);
            Controls.Add(dgvLoaiHang);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductTypeScreen";
            Size = new Size(731, 576);
            Load += ProductTypeScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoaiHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaLoai;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.DataGridView dgvLoaiHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}
