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
        private uiPersonnelMNG uiPersonnelMNG;
        private uiAccountsMNG uiAccountsMNG;
        private uiBookReceipts uiBookReceipts;
        private uiBookSalesInvoice uiBookSalesInvoice;
        private uiBooks uiBooks;
        private uiPublisherMNG uiPublisherMNG;
        private uiAuthorMNG uiAuthorMNG;
        private uiCategory uiCategory;
        private uiReceiptReports uiReceiptReports;
        private uiInvoiceReports uiInvoiceReports;
        private uiRevenueReports uiRevenueReports;
        private readonly string _idstaff;
        private readonly string _user;

        public frmMainMenu(string user, string roleacc, string idstaff)
        {
            InitializeComponent();
            _idstaff = idstaff;
            _user = user;
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
                uiBookReceipts = new uiBookReceipts(_idstaff);
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
                uiBookSalesInvoice = new uiBookSalesInvoice(_idstaff);
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
            frmChangePass frmChangePass = new frmChangePass(_user);
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

        private void btnShowStatisticsRececipt_Click(object sender, EventArgs e)
        {
            if (uiReceiptReports == null)
            {
                uiReceiptReports = new uiReceiptReports();
                uiReceiptReports.Dock = DockStyle.Fill;
                containerShow.Controls.Add(uiReceiptReports);
                uiReceiptReports.BringToFront();
            }
            else
            {
                uiReceiptReports.BringToFront();
            }
            title.Caption = btnShowStatisticsRececipt.Text;
        }

        private void btnShowStatisticsInvoice_Click(object sender, EventArgs e)
        {
            if (uiInvoiceReports == null)
            {
                uiInvoiceReports = new uiInvoiceReports();
                uiInvoiceReports.Dock = DockStyle.Fill;
                containerShow.Controls.Add(uiInvoiceReports);
                uiInvoiceReports.BringToFront();
            }
            else
            {
                uiInvoiceReports.BringToFront();
            }
            title.Caption = btnShowStatisticsInvoice.Text;
        }

        private void btnShowStatisticsRevenue_Click(object sender, EventArgs e)
        {
            if (uiRevenueReports == null)
            {
                uiRevenueReports = new uiRevenueReports();
                uiRevenueReports.Dock = DockStyle.Fill;
                containerShow.Controls.Add(uiRevenueReports);
                uiRevenueReports.BringToFront();
            }
            else
            {
                uiRevenueReports.BringToFront();
            }
            title.Caption = btnShowStatisticsRevenue.Text;
        }
    }
}
