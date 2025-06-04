namespace QuanLiBanHang
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuCatalog;
        private System.Windows.Forms.ToolStripMenuItem menuInvoice;
        private System.Windows.Forms.ToolStripMenuItem menuSearch;
        private System.Windows.Forms.ToolStripMenuItem menuReport;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picBackground;

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            menuCatalog = new ToolStripMenuItem();
            loạiHàngHóaToolStripMenuItem = new ToolStripMenuItem();
            hàngHóaToolStripMenuItem = new ToolStripMenuItem();
            nhàCungCấpToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thươngHiệuToolStripMenuItem = new ToolStripMenuItem();
            menuInvoice = new ToolStripMenuItem();
            hóaĐơnNhậpToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnBánHàngToolStripMenuItem = new ToolStripMenuItem();
            menuSearch = new ToolStripMenuItem();
            menuReport = new ToolStripMenuItem();
            báoCáoDoanhThuToolStripMenuItem = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            lblTitle = new Label();
            picBackground = new PictureBox();
            mainTablePanel = new TableLayoutPanel();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuCatalog, menuInvoice, menuSearch, menuReport, menuHelp, menuExit });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1432, 28);
            menuStrip.TabIndex = 0;
            // 
            // menuCatalog
            // 
            menuCatalog.DropDownItems.AddRange(new ToolStripItem[] { loạiHàngHóaToolStripMenuItem, hàngHóaToolStripMenuItem, nhàCungCấpToolStripMenuItem, nhânViênToolStripMenuItem, kháchHàngToolStripMenuItem, thươngHiệuToolStripMenuItem });
            menuCatalog.Name = "menuCatalog";
            menuCatalog.Size = new Size(90, 24);
            menuCatalog.Text = "Danh mục";
            // 
            // loạiHàngHóaToolStripMenuItem
            // 
            loạiHàngHóaToolStripMenuItem.Name = "loạiHàngHóaToolStripMenuItem";
            loạiHàngHóaToolStripMenuItem.Size = new Size(224, 26);
            loạiHàngHóaToolStripMenuItem.Text = "Loại hàng hóa";
            loạiHàngHóaToolStripMenuItem.Click += loạiHàngHóaToolStripMenuItem_Click;
            // 
            // hàngHóaToolStripMenuItem
            // 
            hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            hàngHóaToolStripMenuItem.Size = new Size(224, 26);
            hàngHóaToolStripMenuItem.Text = "Hàng hóa";
            hàngHóaToolStripMenuItem.Click += hàngHóaToolStripMenuItem_Click;
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            nhàCungCấpToolStripMenuItem.Size = new Size(224, 26);
            nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            nhàCungCấpToolStripMenuItem.Click += nhàCungCấpToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(224, 26);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(224, 26);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // thươngHiệuToolStripMenuItem
            // 
            thươngHiệuToolStripMenuItem.Name = "thươngHiệuToolStripMenuItem";
            thươngHiệuToolStripMenuItem.Size = new Size(224, 26);
            thươngHiệuToolStripMenuItem.Text = "Thương hiệu";
            thươngHiệuToolStripMenuItem.Click += thươngHiệuToolStripMenuItem_Click;
            // 
            // menuInvoice
            // 
            menuInvoice.DropDownItems.AddRange(new ToolStripItem[] { hóaĐơnNhậpToolStripMenuItem, hóaĐơnBánHàngToolStripMenuItem });
            menuInvoice.Name = "menuInvoice";
            menuInvoice.Size = new Size(81, 24);
            menuInvoice.Text = "Hóa đơn";
            // 
            // hóaĐơnNhậpToolStripMenuItem
            // 
            hóaĐơnNhậpToolStripMenuItem.Name = "hóaĐơnNhậpToolStripMenuItem";
            hóaĐơnNhậpToolStripMenuItem.Size = new Size(224, 26);
            hóaĐơnNhậpToolStripMenuItem.Text = "Hóa đơn nhập hàng";
            hóaĐơnNhậpToolStripMenuItem.Click += hóaĐơnNhậpToolStripMenuItem_Click;
            // 
            // hóaĐơnBánHàngToolStripMenuItem
            // 
            hóaĐơnBánHàngToolStripMenuItem.Name = "hóaĐơnBánHàngToolStripMenuItem";
            hóaĐơnBánHàngToolStripMenuItem.Size = new Size(224, 26);
            hóaĐơnBánHàngToolStripMenuItem.Text = "Hóa đơn bán hàng";
            hóaĐơnBánHàngToolStripMenuItem.Click += hóaĐơnBánHàngToolStripMenuItem_Click;
            // 
            // menuSearch
            // 
            menuSearch.Name = "menuSearch";
            menuSearch.Size = new Size(84, 24);
            menuSearch.Text = "Tìm kiếm";
            // 
            // menuReport
            // 
            menuReport.DropDownItems.AddRange(new ToolStripItem[] { báoCáoDoanhThuToolStripMenuItem });
            menuReport.Name = "menuReport";
            menuReport.Size = new Size(77, 24);
            menuReport.Text = "Báo cáo";
            // 
            // báoCáoDoanhThuToolStripMenuItem
            // 
            báoCáoDoanhThuToolStripMenuItem.Name = "báoCáoDoanhThuToolStripMenuItem";
            báoCáoDoanhThuToolStripMenuItem.Size = new Size(224, 26);
            báoCáoDoanhThuToolStripMenuItem.Text = "Báo cáo doanh thu";
            báoCáoDoanhThuToolStripMenuItem.Click += báoCáoDoanhThuToolStripMenuItem_Click;
            // 
            // menuHelp
            // 
            menuHelp.Name = "menuHelp";
            menuHelp.Size = new Size(66, 24);
            menuHelp.Text = "Hỗ trợ";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(61, 24);
            menuExit.Text = "Thoát";
            menuExit.Click += MenuExit_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(500, 50);
            lblTitle.Margin = new Padding(700, 700, 700, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(379, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CỬA HÀNG MÁY TÍNH";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picBackground
            // 
            picBackground.Dock = DockStyle.Fill;
            picBackground.Location = new Point(0, 0);
            picBackground.Name = "picBackground";
            picBackground.Size = new Size(1432, 659);
            picBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            picBackground.TabIndex = 1;
            picBackground.TabStop = false;
            // 
            // mainTablePanel
            // 
            mainTablePanel.ColumnCount = 1;
            mainTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTablePanel.Location = new Point(0, 31);
            mainTablePanel.Name = "mainTablePanel";
            mainTablePanel.RowCount = 1;
            mainTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTablePanel.Size = new Size(1432, 628);
            mainTablePanel.TabIndex = 2;
            // 
            // MainForm
            // 
            ClientSize = new Size(1432, 659);
            Controls.Add(mainTablePanel);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip);
            Controls.Add(picBackground);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Computer Store Management Software";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private ToolStripMenuItem loạiHàngHóaToolStripMenuItem;
        private ToolStripMenuItem hàngHóaToolStripMenuItem;
        private ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem thươngHiệuToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnNhậpToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnBánHàngToolStripMenuItem;
        private ToolStripMenuItem báoCáoDoanhThuToolStripMenuItem;
        private TableLayoutPanel mainTablePanel;
    }
}
