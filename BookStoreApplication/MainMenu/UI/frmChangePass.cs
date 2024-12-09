using DevExpress.XtraEditors;
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
    public partial class frmChangePass : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePass()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = "";
        }

        private void ckShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowPass.Checked)
            {
                txtCurrentPass.Properties.UseSystemPasswordChar = false;
                txtNewPass.Properties.UseSystemPasswordChar = false;
                txtAcceptNewPass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtCurrentPass.Properties.UseSystemPasswordChar = true;
                txtNewPass.Properties.UseSystemPasswordChar = true;
                txtAcceptNewPass.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}