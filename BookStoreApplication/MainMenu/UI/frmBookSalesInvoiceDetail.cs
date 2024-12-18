using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;
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
    public partial class frmBookSalesInvoiceDetail : DevExpress.XtraEditors.XtraForm
    {
        private string _idinvoice;
        private readonly BookBLL _book;
        private readonly BookInvoiceDetailBLL _detail;
        private int? quanlity;
        private int? quanlity_des;
        public frmBookSalesInvoiceDetail(string idinvoice)
        {
            InitializeComponent();
            _idinvoice = idinvoice;
            _book = new BookBLL();
            _detail = new BookInvoiceDetailBLL();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = "";
            txtIDBookInvoice.Text = _idinvoice;
            LoadAllBook();
            LoadAllDetailByInvoice();
        }

        private async void LoadAllBook()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await _book.GetAllBookAsync();
            gcBooks.DataSource = binding;
            gvBooks.PopulateColumns();
        }

        private async void LoadAllDetailByInvoice()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await _detail.GetAllBIAsync(_idinvoice);
            gcBookInvoiceDetail.DataSource = binding;
            gvBookInvoiceDetail.PopulateColumns();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private async void gvBooks_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectRow = gvBooks.GetFocusedRow() as BookDTO;
            if (selectRow != null)
            {
                if(selectRow.quanlitystock == 0)
                {
                    MessageBox.Show("Sách trong kho đã hết!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIDBook.Text = "";
                }
                else
                {
                    txtIDBook.Text = selectRow.id.Trim();
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadAllBook();
            }
            else
            {
                BindingSource binding = new BindingSource();
                binding.DataSource = await _book.SearchBookByNameAsync(txtSearch.Text.Trim());
                gcBooks.DataSource = binding;
                gvBooks.PopulateColumns();
            }
        }

        private async void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDBook.Text))
            {
                MessageBox.Show("Vui lòng chọn sách", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var detail = new BookInvoiceDetailDTO()
                {
                    idinvoice = txtIDBookInvoice.Text,
                    idbook = txtIDBook.Text,
                    quanlity = 1,
                    totalprice = 0
                };
                if (await _detail.AddBookInDetailAsync(detail))
                {
                    txtIDBook.Text = "";
                    LoadAllDetailByInvoice();
                }
                else
                {
                    txtIDBook.Text = "";
                    MessageBox.Show("Lỗi!! Vui lòng gọi hỗ trợ viên!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadAllBook();
            }
        }

        private async void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (await _detail.DeleteBookInDetailAsync(txtIDBookInvoice.Text, txtIDBook.Text))
            {
                LoadAllDetailByInvoice();
                txtIDBook.Text = "";
            }
            else
            {
                txtIDBook.Text = "";
                MessageBox.Show("Lỗi!! Vui lòng gọi hỗ trợ viên!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadAllBook();
        }

        private async void gvBookInvoiceDetail_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectRow = gvBookInvoiceDetail.GetFocusedRow() as BookInvoiceDetailDTO;
            if (selectRow != null)
            {
                txtIDBook.Text = selectRow.idbook.Trim();
            }
        }
    }
}