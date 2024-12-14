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
    public partial class uiBooks : UserControl
    {
        private readonly BookBLL _books;
        private readonly PublisherBLL _publisher;
        private readonly AuthorBLL _author;
        private readonly CategoryBLL _cate;
        private string status = "nothing";
        public uiBooks()
        {
            InitializeComponent();
            _books = new BookBLL();
            _author = new AuthorBLL();
            _cate = new CategoryBLL();
            _publisher = new PublisherBLL();
            txtID.Enabled = false;
            SetUnable();
            LoadAllBooks();
            LoadCBXAuthor();
            LoadCBXCate();
            LoadCBXPub();
        }

        private void SetEnable()
        {
            txtNameBook.Enabled = true;
            txtImportPrice.Enabled = true;
            txtRetailPrice.Enabled = true;
            cbxAuthor.Enabled = true;
            cbxCategory.Enabled = true;
            cbxPublisher.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void SetUnable()
        {
            txtNameBook.Enabled = false;
            txtImportPrice.Enabled = false;
            txtRetailPrice.Enabled = false;
            cbxAuthor.Enabled = false;
            cbxCategory.Enabled = false;
            cbxPublisher.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void Clear()
        {
            txtID.Text = "";
            txtNameBook.Text = "";
            txtQuanlityStock.Text = "0";
            txtImportPrice.Text = "0";
            txtRetailPrice.Text = "0";
            cbxAuthor.SelectedValue = 1;
            cbxCategory.SelectedValue = 1;
            cbxPublisher.SelectedValue = 1;
        }

        private async void LoadAllBooks()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await _books.GetAllBookAsync();
            gcBooks.DataSource = binding;
            gvBooks.PopulateColumns();
        }

        private async void LoadCBXAuthor()
        {
            var authors = await _author.GetAllAuthorAsync();

            cbxAuthor.DataSource = authors;
            cbxAuthor.DisplayMember = "fullname";
            cbxAuthor.ValueMember = "id";
        }
        private async void LoadCBXPub()
        {
            var publishers = await _publisher.GetAllPublishersAsync();

            cbxPublisher.DataSource = publishers;
            cbxPublisher.DisplayMember = "namepublisher";
            cbxPublisher.ValueMember = "id";
        }
        private async void LoadCBXCate()
        {
            var cate = await _cate.GetAllCategoriesAsync();

            cbxCategory.DataSource = cate;
            cbxCategory.DisplayMember = "namecategory";
            cbxCategory.ValueMember = "id";
        }

        private async void btnSearch_Click_1(object sender, EventArgs e)
        {
            string namebook = txtSearchNameBook.Text;
            string cate = txtSearchCategory.Text;
            string pub = txtSearchPublisher.Text;
            string author = txtSearchAuthor.Text;
            if (string.IsNullOrEmpty(txtSearchNameBook.Text)) { namebook = "%20"; }
            if (string.IsNullOrEmpty(txtSearchCategory.Text)) { cate = "%20"; }
            if (string.IsNullOrEmpty(txtSearchPublisher.Text)) { pub = "%20"; }
            if (string.IsNullOrEmpty(txtSearchAuthor.Text)) { author = "%20"; }
            BindingSource binding = new BindingSource();
            binding.DataSource = await _books.SearchBooksAsync(namebook, cate, pub, author);
            gcBooks.DataSource = binding;
            gvBooks.PopulateColumns();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = "add";
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtID.Enabled = true;
            Clear();
            SetEnable();
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
            var book = new BookDTO()
            {
                id = txtID.Text.Trim(),
                namebook = txtNameBook.Text.Trim(),
                quanlitystock = int.Parse(txtQuanlityStock.Text.Trim()),
                importprice = float.Parse(txtImportPrice.Text.Trim()),
                retailprice = float.Parse(txtRetailPrice.Text.Trim()),
                idau = int.Parse(cbxAuthor.SelectedValue.ToString()),
                idcate = int.Parse(cbxCategory.SelectedValue.ToString()),
                idpub = int.Parse(cbxPublisher.SelectedValue.ToString())
            };

            if (status.Equals("add"))
            {
                SetUnable();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                try
                {
                    if (await _books.AddBookAsync(book))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllBooks();
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
                    if (await _books.UpdateBookAsync(book))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllBooks();
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
                    if (await _books.DeleteBookAsync(txtID.Text))
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllBooks();
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
            txtID.Enabled = false;
            SetUnable();
            Clear();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void gvBooks_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectRow = gvBooks.GetFocusedRow() as BookDTO;

            txtID.Text = selectRow.id.Trim();
            txtNameBook.Text = selectRow.namebook.Trim();
            txtQuanlityStock.Text = selectRow.quanlitystock.ToString();
            txtImportPrice.Text = selectRow.importprice.ToString();
            txtRetailPrice.Text = selectRow.retailprice.ToString();
            cbxAuthor.SelectedValue = Convert.ToInt32(selectRow.idau);
            cbxCategory.SelectedValue = Convert.ToInt32(selectRow.idcate);
            cbxPublisher.SelectedValue = Convert.ToInt32(selectRow.idpub);
        }
    }
}
