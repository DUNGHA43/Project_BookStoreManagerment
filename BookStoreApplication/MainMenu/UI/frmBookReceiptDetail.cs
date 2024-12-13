using DevExpress.XtraEditors;
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
    public partial class frmBookReceiptDetail : DevExpress.XtraEditors.XtraForm
    {
        private readonly string _idreceipt;
        private readonly int _idpub;
        private readonly BookBLL _book;
        private readonly BookReceiptDetailBLL _detail;
        private float? importprice;
        public frmBookReceiptDetail(string idreceipt, string idpub)
        {
            InitializeComponent();
            _idreceipt = idreceipt;
            _idpub = Convert.ToInt32(idpub);
            _book = new BookBLL();
            _detail = new BookReceiptDetailBLL();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = "";
            txtIDBookReceipt.Text = _idreceipt;
            txtQuanlity.Enabled = false;
            LoadAllBookByPub();
            LoadAllDetailByBookReceipt();
        }

        private async void LoadAllBookByPub()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await _book.GetALlBookByPubAsync(_idpub);
            gcBooks.DataSource = binding;
            gvBooks.PopulateColumns();
        }

        private async void LoadAllDetailByBookReceipt()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await _detail.GetAllBRAsync(_idreceipt);
            gcBookReceiptDetail.DataSource = binding;
            gvBookReceiptDetail.PopulateColumns();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvBookReceiptDetail_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectRow = gvBookReceiptDetail.GetFocusedRow() as BookReceiptDetailDTO;

            if (selectRow != null)
            {
                txtIDBook.Text = selectRow.idbook.Trim();
                txtQuanlity.Text = selectRow.quanlity.ToString().Trim();
                txtTotal.Text = selectRow.totalprice.ToString().Trim();
            }
        }

        private void gvBooks_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectRow = gvBooks.GetFocusedRow() as BookDTO;

            if (selectRow != null)
            {
                txtIDBook.Text = selectRow.id.Trim();
                importprice = selectRow.importprice;
                txtQuanlity.Enabled = true;
                txtQuanlity.Text = "0";
                txtTotal.Text = "0";
            }
        }

        private void txtQuanlity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuanlity.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                float? total = float.Parse(txtQuanlity.Text.Trim()) * importprice;
                txtTotal.Text = total.ToString() ?? "-1";
            }

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadAllBookByPub();
            }
            else
            {
                BindingSource binding = new BindingSource();
                binding.DataSource = await _book.SearchBookByPubAsync(_idpub, txtSearch.Text.Trim());
                gcBooks.DataSource = binding;
                gvBooks.PopulateColumns();
            }
        }

        private async void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(string.IsNullOrEmpty(txtQuanlity.Text) && string.IsNullOrEmpty(txtTotal.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var detail = new BookReceiptDetailDTO()
                {
                    idreceipt = txtIDBookReceipt.Text,
                    idbook = txtIDBook.Text,
                    quanlity = int.Parse(txtQuanlity.Text.Trim()),
                    totalprice = decimal.Parse(txtTotal.Text.Trim())
                };
                if(await _detail.AddBookInDetailAsync(detail))
                {
                    LoadAllDetailByBookReceipt();
                    txtIDBook.Text = "";
                    txtQuanlity.Text = "0";
                    txtTotal.Text = "0";
                }
                else
                {
                    txtIDBook.Text = "";
                    txtQuanlity.Text = "0";
                    txtTotal.Text = "0";
                    MessageBox.Show("Lỗi!! Vui lòng gọi hỗ trợ viên!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private async void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuanlity.Text) && string.IsNullOrEmpty(txtTotal.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xoá!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (await _detail.DeleteBookInDetailAsync(txtIDBookReceipt.Text, txtIDBook.Text))
                {
                    LoadAllDetailByBookReceipt();
                    txtIDBook.Text = "";
                    txtQuanlity.Text = "0";
                    txtTotal.Text = "0";
                }
                else
                {
                    txtIDBook.Text = "";
                    txtQuanlity.Text = "0";
                    txtTotal.Text = "0";
                    MessageBox.Show("Lỗi!! Vui lòng gọi hỗ trợ viên!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}