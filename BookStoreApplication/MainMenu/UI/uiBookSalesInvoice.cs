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
    public partial class uiBookSalesInvoice : UserControl
    {
        public uiBookSalesInvoice()
        {
            InitializeComponent();
        }

        private void btnInvoiceDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBookSalesInvoiceDetail frmBookSalesInvoiceDetail = new frmBookSalesInvoiceDetail();
            frmBookSalesInvoiceDetail.ShowDialog();
        }
    }
}
