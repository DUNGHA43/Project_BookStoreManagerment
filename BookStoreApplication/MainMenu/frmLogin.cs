using MainMenu;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void ckShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowPass.Checked)
            {
                txtPassWord.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.Properties.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ("admin".Equals(txtUserName.Text.Trim()) && "12345".Equals(txtPassWord.Text.Trim()))
            {
                frmMainMenu mainMenu = new frmMainMenu();
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}