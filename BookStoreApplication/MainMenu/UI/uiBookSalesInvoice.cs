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
    public partial class uiBookSalesInvoice : UserControl
    {
        private readonly string _idstaff;
        private string status = "nothing";
        private readonly BookInvoiceBLL _bookinvoice;
        private readonly StaffBLL _staff;

        public uiBookSalesInvoice(string idstaff)
        {
            InitializeComponent();
            _idstaff = idstaff;
            _bookinvoice = new BookInvoiceBLL();
            _staff = new StaffBLL();
            btnInvoiceDetail.Enabled = false;
            btnPrint.Enabled = false;
            txtID.Enabled = false;
            LoadAllBookInvoice();
            LoadCBXStaffs();
            SetUnable();
        }

        private async void LoadAllBookInvoice()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await _bookinvoice.GetAllBookInvoiceAsync();
            gcBookInvoice.DataSource = binding;
            gvBookInvoice.PopulateColumns();
        }

        private async void LoadCBXStaffs()
        {
            var staffs = await _staff.ShowAllStaffAsync();

            txtStaff.DataSource = staffs;
            txtStaff.DisplayMember = "fullname";
            txtStaff.ValueMember = "id";

        }

        private async void btnInvoiceDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBookSalesInvoiceDetail frmBookSalesInvoiceDetail = new frmBookSalesInvoiceDetail(txtID.Text.Trim());
            frmBookSalesInvoiceDetail.ShowDialog();
            var total = new BookInvoiceDTO()
            {
                id = txtID.Text.Trim(),
                totalprice = await _bookinvoice.GetTotalInvoiceAsync(txtID.Text.Trim())
            };

            await _bookinvoice.UpdateBookInvoiceAsync(total);
            LoadAllBookInvoice();
            btnInvoiceDetail.Enabled = false;
        }

        private void SetUnable()
        {
            txtDateCreate.Enabled = false;
            btnSaveInvoice.Enabled = false;
            btnCancell.Enabled = false;
        }

        private void SetEnable()
        {
            txtDateCreate.Enabled = true;
            btnSaveInvoice.Enabled = true;
            btnCancell.Enabled = true;

        }

        private void Clear()
        {
            txtID.Text = "";
            txtDateCreate.Text = "";
            txtTotal.Text = "0";
        }

        private void gvBookInvoice_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectRow = gvBookInvoice.GetFocusedRow() as BookInvoiceDTO;

            if (selectRow != null)
            {
                txtID.Text = selectRow.id;
                txtDateCreate.Text = selectRow.saledate.ToString();
                txtStaff.SelectedValue = selectRow.idstaff.ToString();
                txtTotal.Text = selectRow.totalprice.ToString();
            }
            btnInvoiceDetail.Enabled = true;
            btnPrint.Enabled = true;
        }

        private void btnAddInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "add";
            btnAddInvoice.Enabled = false;
            btnUpdateInvoice.Enabled = false;
            btnDeleteInvoice.Enabled = false;
            btnSaveInvoice.Enabled = false;
            btnPrint.Enabled = false;
            txtID.Enabled = false;
            Clear();
            txtStaff.SelectedValue = _idstaff.ToString();
            txtID.Enabled = true;
            SetEnable();
        }

        private void btnUpdateInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "update";
            btnAddInvoice.Enabled = false;
            btnUpdateInvoice.Enabled = false;
            btnDeleteInvoice.Enabled = false;
            btnSaveInvoice.Enabled = false;
            btnPrint.Enabled = false;
            txtID.Enabled = false;
            SetEnable();
        }

        private void btnDeleteInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "delete";
            btnAddInvoice.Enabled = false;
            btnUpdateInvoice.Enabled = false;
            btnDeleteInvoice.Enabled = false;
            btnSaveInvoice.Enabled = false;
            btnPrint.Enabled = false;
            txtID.Enabled = false;
            SetEnable();
        }

        private async void btnSaveInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var bookinvoice = new BookInvoiceDTO()
            {
                id = txtID.Text.Trim(),
                saledate = txtDateCreate.DateTime,
                idstaff = txtStaff.SelectedValue.ToString(),
                totalprice = decimal.Parse(txtTotal.Text.Trim())
            };
            if (status.Equals("add"))
            {
                SetUnable();
                btnAddInvoice.Enabled = true;
                btnUpdateInvoice.Enabled = true;
                btnDeleteInvoice.Enabled = true;
                try
                {
                    if (await _bookinvoice.AddBookInvoiceAsync(bookinvoice))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllBookInvoice();
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
                btnAddInvoice.Enabled = true;
                btnUpdateInvoice.Enabled = true;
                btnDeleteInvoice.Enabled = true;
                try
                {
                    if (await _bookinvoice.UpdateBookInvoiceAsync(bookinvoice))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllBookInvoice();
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
                btnAddInvoice.Enabled = true;
                btnUpdateInvoice.Enabled = true;
                btnDeleteInvoice.Enabled = true;
                try
                {
                    if (await _bookinvoice.DeleteBookInvoiceAsync(bookinvoice.id))
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllBookInvoice();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtID.Enabled = false;
        }

        private void btnCancell_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clear();
            status = "nothing";
            SetUnable();
            btnAddInvoice.Enabled = true;
            btnUpdateInvoice.Enabled = true;
            btnDeleteInvoice.Enabled = true;
            txtID.Enabled = false;
        }

        private void btnCloseUI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                LoadAllBookInvoice();
            }
            else
            {
                BindingSource binding = new BindingSource();
                binding.DataSource = await _bookinvoice.SearchBookInvoiceByIdAsync(txtSearch.Text.Trim());
                gcBookInvoice.DataSource = binding;
                gvBookInvoice.PopulateColumns();
            }
        }
    }
}
