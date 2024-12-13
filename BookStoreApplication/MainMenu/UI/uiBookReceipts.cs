using BLL;
using DevExpress.Utils.Html.Internal;
using DevExpress.XtraRichEdit.Model;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI
{
    public partial class uiBookReceipts : UserControl
    {
        private string status = "nothing";
        private readonly BookReceiptBLL _bookreceipt;
        private readonly PublisherBLL _publisher;
        private readonly StaffBLL _staff;
        private readonly string _idstaff;

        public uiBookReceipts(string idstaff)
        {
            InitializeComponent();
            _bookreceipt = new BookReceiptBLL();
            _publisher = new PublisherBLL();
            _staff = new StaffBLL();
            _idstaff = idstaff;
            SetUnable();
            txtID.Enabled = false;
            LoadAllBookReceipts();
            LoadCBXPublishers();
            LoadCBXStaffs();
            btnDetail.Enabled = false;
            cbxStaff.Enabled = false;
        }

        private void SetUnable()
        {
            txtDate.Enabled = false;
            cbxPublisher.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void SetEnable()
        {
            txtDate.Enabled = true;
            cbxPublisher.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void Clear()
        {
            txtID.Text = "";
            txtDate.Text = "";
            cbxPublisher.SelectedValue = 1;
            txtTotal.Text = "0";
        }

        private async void LoadAllBookReceipts()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await _bookreceipt.GetAllBookReciptsAsync();
            gcBookReceipts.DataSource = binding;
            gvBookReceipts.PopulateColumns();
        }

        private async void LoadCBXPublishers()
        {
            var publishers = await _publisher.GetAllPublishersAsync();

            cbxPublisher.DataSource = publishers;
            cbxPublisher.DisplayMember = "namepublisher";
            cbxPublisher.ValueMember = "id";
        }
        private async void LoadCBXStaffs()
        {
            var staffs = await _staff.ShowAllStaffAsync();

            cbxStaff.DataSource = staffs;
            cbxStaff.DisplayMember = "fullname";
            cbxStaff.ValueMember = "id";

        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private async void btnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBookReceiptDetail frmBookReceiptDetail = new frmBookReceiptDetail(txtID.Text.Trim(), cbxPublisher.SelectedValue.ToString());
            frmBookReceiptDetail.ShowDialog();
            var total = new BookReceiptDTO() { id = txtID.Text.Trim(),
                totalprice = await _bookreceipt.GetTotalReceiptAsync(txtID.Text.Trim())};

            await _bookreceipt.UpdateBookReceiptAsync(total);
            LoadAllBookReceipts();
            btnDetail.Enabled = false;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "add";
            SetEnable();
            txtID.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            Clear();
            cbxStaff.SelectedValue = _idstaff;
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
            string totalstr = txtTotal.Text.Trim();
            decimal total = 0;
            if (decimal.TryParse(totalstr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal result))
            {
                total = result;
            }
            var bookreceipt = new BookReceiptDTO()
            {
                id = txtID.Text.Trim(),
                dateentry = txtDate.DateTime,
                idpublisher = Convert.ToInt32(cbxPublisher.SelectedValue.ToString()),
                idstaff = cbxStaff.SelectedValue.ToString(),
                totalprice = total
            };

            if (status.Equals("add"))
            {
                SetUnable();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                try
                {
                    if (await _bookreceipt.AddBookReceiptAsync(bookreceipt))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllBookReceipts();
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
                    if (await _bookreceipt.UpdateBookReceiptAsync(bookreceipt))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllBookReceipts();
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
                    if (await _bookreceipt.DeleteBookReceiptAsync(bookreceipt.id))
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllBookReceipts();
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
            SetUnable();
            Clear();
        }

        private void gvBookReceipts_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectRow = gvBookReceipts.GetFocusedRow() as BookReceiptDTO;

            if (selectRow != null)
            {
                txtID.Text = selectRow.id.Trim();
                txtDate.Text = selectRow.dateentry.ToString().Trim();
                txtTotal.Text = selectRow.totalprice.ToString().Trim();
                cbxPublisher.SelectedValue = Convert.ToInt32(selectRow.idpublisher.ToString());
                cbxStaff.SelectedValue = selectRow.idstaff.ToString();
            }

            btnDetail.Enabled = true;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = await _bookreceipt.SearchBookReceiptAsync(txtSearch.Text.Trim());
            gcBookReceipts.DataSource = bindingSource;
            gvBookReceipts.PopulateColumns();
        }
    }
}
