using BLL;
using DevExpress.XtraEditors;
using DTO;
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
        private readonly string _user;
        private readonly AccountBLL _account;
        public frmChangePass(string user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            _user = user;
            _account = new AccountBLL();
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPass.Text.Trim()) || string.IsNullOrEmpty(txtNewPass.Text.Trim())
               || string.IsNullOrEmpty(txtAcceptNewPass.Text.Trim()))
            {

                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var account = await _account.LoginApp(_user, txtCurrentPass.Text.Trim());
                if (txtCurrentPass.Text.Trim().Equals(account.passw.Trim()) && txtNewPass.Text.Trim().Equals(txtAcceptNewPass.Text.Trim()))
                {
                    var newPass = new AccountDTO()
                    {
                        username = _user,
                        passw = txtAcceptNewPass.Text.Trim()
                    };
                    if (await _account.UpdateAccountAsync(newPass)) {
                        MessageBox.Show($"Đổi mật khẩu tài khoản {_user.Trim()} thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}