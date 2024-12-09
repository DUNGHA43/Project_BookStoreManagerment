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
    public partial class uiBookReceipts : UserControl
    {
        public uiBookReceipts()
        {
            InitializeComponent();

        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBookReceiptDetail frmBookReceiptDetail = new frmBookReceiptDetail();
            frmBookReceiptDetail.ShowDialog();
        }
    }
}
