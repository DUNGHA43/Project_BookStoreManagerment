using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DevExpress.CodeParser;
using DevExpress.Utils.Html.Internal;
using DevExpress.XtraRichEdit.Model;
using DTO;
namespace GUI.UI
{
    public partial class uiPersonnelMNG : UserControl
    {
        private readonly StaffBLL _staffBLL;
        private string status = "Nothing";
        public uiPersonnelMNG()
        {
            InitializeComponent();
            _staffBLL = new StaffBLL();
            LoadAllStaff();
            setUnable();
            txtID.Enabled = false;
        }

        private async void LoadAllStaff()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await _staffBLL.ShowAllStaffAsync();
            gcStaff.DataSource = binding;
            gvStaff.PopulateColumns();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await _staffBLL.SearchStaffByName(txtSearch.Text.Trim());
            gcStaff.DataSource = binding;
            gvStaff.PopulateColumns();
        }

        private void setUnable()
        {
            txtFullName.Enabled = false;
            txtBirth.Enabled = false;
            txtIdentification.Enabled = false;
            txtAddress.Enabled = false;
            txtWorkSchedule.Enabled = false;
            txtPhone.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void setEnable()
        {
            txtFullName.Enabled = true;
            txtBirth.Enabled = true;
            txtIdentification.Enabled = true;
            txtAddress.Enabled = true;
            txtWorkSchedule.Enabled = true;
            txtPhone.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Parent.Dispose();
            }
        }

        private void gvStaff_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectRow = gvStaff.GetFocusedRow() as StaffDTO;

            if (selectRow != null)
            {
                txtID.Text = selectRow.id.Trim();
                txtFullName.Text = selectRow.fullname.Trim();
                txtBirth.Text = selectRow.birthday.ToString().Trim();
                txtPhone.Text = selectRow.phonenumber.Trim();
                txtIdentification.Text = selectRow.identification.Trim();
                txtAddress.Text = selectRow.addre.Trim();
                txtWorkSchedule.Text = selectRow.workschedule.Trim();

            }
        }

        private void Clear()
        {
            txtID.Text = "";
            txtFullName.Text = "";
            txtBirth.Text = "";
            txtPhone.Text = "";
            txtIdentification.Text = "";
            txtAddress.Text = "";
            txtWorkSchedule.Text = "";
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "add";
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtID.Enabled = true;
            Clear();
            setEnable();
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "update";
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtID.Enabled = false;
            setEnable();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "delete";
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtID.Enabled = false;
            setEnable();
        }

        private async void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var staff = new StaffDTO()
            {
                id = txtID.Text.Trim(),
                fullname = txtFullName.Text.Trim(),
                birthday = txtBirth.DateTime,
                identification = txtIdentification.Text.Trim(),
                phonenumber = txtPhone.Text.Trim(),
                addre = txtAddress.Text.Trim(),
                workschedule = txtWorkSchedule.Text.Trim()
            };

            if (status.Equals("add"))
            {
                setUnable();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                try
                {
                    if (await _staffBLL.AddStaffAsync(staff))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllStaff();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (status.Equals("update"))
            {
                setUnable();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                try
                {
                    if (await _staffBLL.UpdateStaffAsync(staff))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllStaff();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Cập nhật không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (status.Equals("delete"))
            {
                setUnable();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                try
                {
                    if (await _staffBLL.DeleteStaffAsync(txtID.Text))
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllStaff();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtID.Enabled = false;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "nothing";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            txtID.Enabled = false;
            Clear();
            setUnable();
        }
    }
}
