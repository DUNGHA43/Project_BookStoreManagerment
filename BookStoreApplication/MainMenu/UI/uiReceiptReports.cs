using BLL;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI
{
    public partial class uiReceiptReports : UserControl
    {
        private readonly BookReceiptBLL receipts;
        private string status = "year";
        public uiReceiptReports()
        {
            InitializeComponent();
            receipts = new BookReceiptBLL();
            rdoY.Checked = true;
            cbxY.Text = "2024";
            LoadTableYear();
        }

        private async void LoadTableYear()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await receipts.StatisticalReceiptByYearAsync(Convert.ToInt32(cbxY.Text.Trim()));

            gcTable.DataSource = binding;
            gvTable.PopulateColumns();
        }
        private async void LoadTableMonth()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await receipts.StatisticalReceiptByMonthAsync(Convert.ToInt32(cbxM.Text.Trim()),
                Convert.ToInt32(cbxY.Text.Trim()));

            gcTable.DataSource = binding;
            gvTable.PopulateColumns();
        }
        private async void LoadTableQuater()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await receipts.StatisticalReceiptByQuaterAsync(Convert.ToInt32(cbxM.Text.Trim()),
                Convert.ToInt32(cbxY.Text.Trim()));

            gcTable.DataSource = binding;
            gvTable.PopulateColumns();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void rdoM_Click(object sender, EventArgs e)
        {
            string[] month = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            cbxM.DataSource = month;
            lbM.Text = "Tháng:";
            status = "month";
            cbxM.Enabled = true;
        }

        private void rdoQ_CheckedChanged(object sender, EventArgs e)
        {
            string[] quater = { "1", "2", "3", "4" };
            cbxM.DataSource = quater;
            lbM.Text = "Quý:";
            status = "quater";
            cbxM.Enabled = true;
        }

        private void rdoY_CheckedChanged(object sender, EventArgs e)
        {
            cbxM.Enabled = false;
            status = "year";
        }

        private void btnSatistical_Click(object sender, EventArgs e)
        {
            if (status.Equals("year"))
            {
                LoadTableYear();
            }
            if (status.Equals("month"))
            {
                LoadTableMonth();
            }
            if (status.Equals("quater"))
            {
                LoadTableQuater();
            }
        }
    }
}
