using Microsoft.Extensions.DependencyInjection;
using UI;
using UI.InvoiceScreen;
using UI.ReportScreen;

namespace QuanLiBanHang
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            this.mainTablePanel.RowCount = 0;
            this.mainTablePanel.ColumnCount = 0;
            this.mainTablePanel.RowStyles.Clear();
            this.mainTablePanel.ColumnStyles.Clear();
            this.mainTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.mainTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            this.mainTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            this.mainTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.mainTablePanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.mainTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.ClientSize = new System.Drawing.Size(1450, 705);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ShowScreen<T>() where T : UserControl
        {
            var control = (UserControl)_serviceProvider.GetRequiredService(typeof(T));
            this.mainTablePanel.Controls.Clear();
            this.mainTablePanel.Controls.Add(control, 0, 0);
            control.Anchor = AnchorStyles.None;
        }

        private void loạiHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowScreen<ProductTypeScreen>();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowScreen<ProductScreen>();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowScreen<SupplierScreen>();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowScreen<EmployeeScreen>();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowScreen<CustomerScreen>();
        }

        private void thươngHiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowScreen<BrandScreen>();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowScreen<ImportInvoiceScreen>();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowScreen<ExportInvoiceScreen>();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowScreen<RevenueReportScreen>();
        }
    }

}
