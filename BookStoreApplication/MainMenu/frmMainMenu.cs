using DevExpress.XtraBars;
using GUI;
using GUI.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class frmMainMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        uiPersonnelMNG uiPersonnelMNG;
        uiAccountsMNG uiAccountsMNG;
        uiBookReceipts uiBookReceipts;
        uiBookSalesInvoice uiBookSalesInvoice;
        uiBooks uiBooks;
        uiPublisherMNG uiPublisherMNG;
        uiAuthorMNG uiAuthorMNG;
        uiCategory uiCategory;

        public frmMainMenu(string user, string roleacc)
        {
            InitializeComponent();
            title.Caption = $"Chúc một ngày làm việc vui vẻ: {user}";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            if (uiPersonnelMNG == null)
            {
                uiPersonnelMNG = new uiPersonnelMNG();
                uiPersonnelMNG.Dock = DockStyle.Fill;
                containerShow.Controls.Add(uiPersonnelMNG);
                uiPersonnelMNG.BringToFront();
            }
            else
            {
                uiPersonnelMNG.BringToFront();
            }
            title.Caption = btnShowStaff.Text;
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            if (uiAccountsMNG == null)
            {
                uiAccountsMNG = new uiAccountsMNG();
                uiAccountsMNG.Dock = DockStyle.Fill;
                containerShow.Controls.Add(uiAccountsMNG);
                uiAccountsMNG.BringToFront();
            }
            else
            {
                uiAccountsMNG.BringToFront();
            }
            title.Caption = btnShowAccount.Text;
        }

        private void btnShowReceipt_Click(object sender, EventArgs e)
        {
            if (uiBookReceipts == null)
            {
                uiBookReceipts = new uiBookReceipts();
                uiBookReceipts.Dock = DockStyle.Fill;
                containerShow.Controls.Add(uiBookReceipts);
                uiBookReceipts.BringToFront();
            }
            else
            {
                uiBookReceipts.BringToFront();
            }
            title.Caption = btnShowReceipt.Text;
        }

        private void btnShowInvoice_Click(object sender, EventArgs e)
        {
            if (uiBookSalesInvoice == null)
            {
                uiBookSalesInvoice = new uiBookSalesInvoice();
                uiBookSalesInvoice.Dock = DockStyle.Fill;
                containerShow.Controls.Add(uiBookSalesInvoice);
                uiBookSalesInvoice.BringToFront();
            }
            else
            {
                uiBookSalesInvoice.BringToFront();
            }
            title.Caption = btnShowInvoice.Text;
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            if (uiBooks == null)
            {
                uiBooks = new uiBooks();
                uiBooks.Dock = DockStyle.Fill;
                containerShow.Controls.Add(uiBooks);
                uiBooks.BringToFront();
            }
            else
            {
                uiBooks.BringToFront();
            }
            title.Caption = btnShowBooks.Text;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass frmChangePass = new frmChangePass();
            frmChangePass.ShowDialog();
        }

        private void btnShowPublisher_Click(object sender, EventArgs e)
        {
            if (uiPublisherMNG == null)
            {
                uiPublisherMNG = new uiPublisherMNG();
                uiPublisherMNG.Dock = DockStyle.Fill;
                containerShow.Controls.Add(uiPublisherMNG);
                uiPublisherMNG.BringToFront();
            }
            else
            {
                uiPublisherMNG.BringToFront();
            }
            title.Caption = btnShowPublisher.Text;
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            if (uiCategory == null)
            {
                uiCategory = new uiCategory();
                uiCategory.Dock = DockStyle.Fill;
                containerShow.Controls.Add(uiCategory);
                uiCategory.BringToFront();
            }
            else
            {
                uiCategory.BringToFront();
            }
            title.Caption = btnShowCategory.Text;
        }

        private void btnShowAuthor_Click(object sender, EventArgs e)
        {
            if (uiAuthorMNG == null)
            {
                uiAuthorMNG = new uiAuthorMNG();
                uiAuthorMNG.Dock = DockStyle.Fill;
                containerShow.Controls.Add(uiAuthorMNG);
                uiAuthorMNG.BringToFront();
            }
            else
            {
                uiAuthorMNG.BringToFront();
            }
            title.Caption = btnShowAuthor.Text;
        }
    }
}
