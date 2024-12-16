using BLL;
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
    public partial class uiAuthorMNG : UserControl
    {

        private readonly AuthorBLL _author;
        private int? _id;
        private string status = "nothing";
        public uiAuthorMNG()
        {
            InitializeComponent();
            _author = new AuthorBLL();
            LoadAllAuthor();
        }

        private async void LoadAllAuthor()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await _author.GetAllAuthorAsync();

            gcAuthor.DataSource = binding;
            gvAuthor.PopulateColumns();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                LoadAllAuthor();
            }
            else
            {
                BindingSource binding = new BindingSource();
                binding.DataSource = await _author.SearchAuthorByName(txtSearch.Text.Trim());

                gcAuthor.DataSource = binding;
                gvAuthor.PopulateColumns();
            }
        }

        private void SetEnable()
        {
            txtNameAuthor.Enabled = true;
            txtAddress.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void SetUnable()
        {
            txtNameAuthor.Enabled = false;
            txtAddress.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void Clear()
        {
            _id = null;
            txtNameAuthor.Text = "";
            txtAddress.Text = "";
        }

        private void gvAuthor_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectedRow = gvAuthor.GetFocusedRow() as AuthorDTO;

            if (selectedRow != null)
            {
                _id = selectedRow.id;
                txtNameAuthor.Text = selectedRow.fullname;
                txtAddress.Text = selectedRow.addre;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "add";
            SetEnable();
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            Clear();
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "update";
            SetEnable();
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "delete";
            SetEnable();
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private async void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var author = new AuthorDTO()
            {
                id = _id,
                fullname = txtNameAuthor.Text.Trim(),
                addre = txtAddress.Text.Trim()
            };

            if (status.Equals("add"))
            {
                SetUnable();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                try
                {
                    if (await _author.AddAuthorAsync(author))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllAuthor();
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
                    if (await _author.UpdateAuthorAsync(author))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllAuthor();
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
                    if (await _author.DeleteAuthorAsync(_id))
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllAuthor();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "nothing";
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            Clear();
        }
    }
}
