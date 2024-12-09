using BLL;
using MainMenu;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private readonly AccountBLL _accountBLL;
        public frmLogin()
        {
            InitializeComponent();
            _accountBLL = new AccountBLL();
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassWord.Text.Trim();

            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var userAccount = await _accountBLL.LoginApp(username, password);
                if(username.Trim().Equals(userAccount.username.Trim()) && password.Trim().Equals(userAccount.passw.Trim())) 
                {
                    MessageBox.Show($"Xin chào, {userAccount.username}");
                    frmMainMenu mainMenu = new frmMainMenu(userAccount.username, userAccount.roleacc);
                    this.Hide();
                    mainMenu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}