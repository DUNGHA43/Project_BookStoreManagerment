using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI.UI
{
    public partial class uiAccountsMNG : UserControl
    {
        private readonly AccountBLL _accountBLL;
        private readonly StaffBLL _staffBLL;
        private string status = "nothing!";
        public uiAccountsMNG()
        {
            InitializeComponent();
            _accountBLL = new AccountBLL();
            _staffBLL = new StaffBLL();
            LoadAllAccounts();
            LoadCombobox();
            SetUnable();
            txtNameAcc.Enabled = false;
        }

        private async void LoadAllAccounts()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = await _accountBLL.ShowAllAccounts();
            gcAccount.DataSource = bindingSource;
            gvAccount.PopulateColumns();
        }

        private async void LoadCombobox()
        {
            var staffs = await _staffBLL.ShowAllStaffAsync();

            cbxStaff.DataSource = staffs;
            cbxStaff.DisplayMember = "fullname";
            cbxStaff.ValueMember = "id";

        }

        private void gvAccount_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectRow = gvAccount.GetFocusedRow() as AccountDTO;

            if (selectRow != null)
            {
                txtNameAcc.Text = selectRow.username;
                txtPassAcc.Text = selectRow.passw;
                cbxPosition.Text = selectRow.roleacc; 
                cbxStaff.SelectedValue = selectRow.idstaff;
            }
        }

        private void SetEnable()
        {
            txtPassAcc.Enabled = true;
            cbxPosition.Enabled = true;
            cbxStaff.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void SetUnable()
        {
            txtPassAcc.Enabled = false;
            cbxPosition.Enabled = false;
            cbxStaff.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "add";
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtNameAcc.Enabled = true;
            SetEnable();
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "update";
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtNameAcc.Enabled = false;
            SetEnable();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "delete";
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtNameAcc.Enabled = false;
            SetEnable();
        }

        private async void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var account = new AccountDTO
            {
                username = txtNameAcc.Text.Trim(),
                passw = txtPassAcc.Text.Trim(),
                roleacc = cbxPosition.Text.Trim(),
                idstaff = cbxStaff.SelectedValue.ToString()
            };

            if (status.Equals("add"))
            {
                SetUnable();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                try
                {
                    if (await _accountBLL.AddAccountAsync(account))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllAccounts();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (status.Equals("update"))
            {
                SetUnable();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                try
                {
                    if (await _accountBLL.UpdateAccountAsync(account))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllAccounts();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Cập nhật không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (status.Equals("delete"))
            {
                SetUnable();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                try
                {
                    if (await _accountBLL.DeleteAccountAsync(txtNameAcc.Text))
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllAccounts();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtNameAcc.Enabled = false;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "nothing";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            txtNameAcc.Enabled = false;
            SetUnable();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = await _accountBLL.SearchStaffByUsername(txtSearch.Text.Trim());
            gcAccount.DataSource = bindingSource;
            gvAccount.PopulateColumns();
        }
    }
}
