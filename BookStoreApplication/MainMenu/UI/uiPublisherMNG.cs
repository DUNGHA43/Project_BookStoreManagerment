using BLL;
using DevExpress.XtraReports.Templates;
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
    public partial class uiPublisherMNG : UserControl
    {
        private readonly PublisherBLL _pub;
        private string status = "nothing";
        private int? _id;
        public uiPublisherMNG()
        {
            InitializeComponent();
            _pub = new PublisherBLL();
            SetUnable();
            LoadAllPubAsync();
        }

        private async void LoadAllPubAsync()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await _pub.GetAllPublishersAsync();

            gcPublisher.DataSource = binding;
            gvPublisher.PopulateColumns();
        }

        private void SetUnable()
        {
            txtNamePublisher.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void SetEnable()
        {
            txtNamePublisher.Enabled = true;
            txtPhone.Enabled = true;
            txtAddress.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void Clear()
        {
            _id = null;
            txtNamePublisher.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "add";
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            SetEnable();
            Clear();

        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "update";
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            SetEnable();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "delete";
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            SetEnable();
        }

        private async void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var publisher = new PublisherDTO()
            {
                id = _id,
                namepublisher = txtNamePublisher.Text,
                phonenumber = txtPhone.Text,
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
                    if (await _pub.AddAsync(publisher))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllPubAsync();
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
                    if (await _pub.UpdateAsync(publisher))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllPubAsync();
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
                    if (await _pub.DeleteAsync(_id))
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllPubAsync();
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
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            Clear();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadAllPubAsync();
            }
            else
            {
                BindingSource binding = new BindingSource();
                binding.DataSource = await _pub.SearchPublisherByNameAsync(txtSearch.Text.Trim());
                gcPublisher.DataSource = binding;
                gvPublisher.PopulateColumns();
            }
        }

        private void gvPublisher_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectedRow = gvPublisher.GetFocusedRow() as PublisherDTO;

            if (selectedRow != null)
            {
                _id = selectedRow.id;
                txtNamePublisher.Text = selectedRow.namepublisher.Trim();
                txtPhone.Text = selectedRow.phonenumber.Trim();
                txtAddress.Text = selectedRow.addre.Trim();
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }
    }
}
