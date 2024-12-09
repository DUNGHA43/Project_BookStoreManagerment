namespace GUI.UI
{
    partial class frmBookSalesInvoiceDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookSalesInvoiceDetail));
            txtIDBook = new DevExpress.XtraEditors.TextEdit();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnAdd = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            txtIDBookReceipt = new DevExpress.XtraEditors.TextEdit();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            gcBooks = new DevExpress.XtraGrid.GridControl();
            gvBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
            panel4 = new System.Windows.Forms.Panel();
            txtSearch = new DevExpress.XtraEditors.TextEdit();
            btnSearch = new System.Windows.Forms.Button();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            gcBookReceiptDetail = new DevExpress.XtraGrid.GridControl();
            gvBookReceiptDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)txtIDBook.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtIDBookReceipt.Properties).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvBooks).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcBookReceiptDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvBookReceiptDetail).BeginInit();
            SuspendLayout();
            // 
            // txtIDBook
            // 
            txtIDBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtIDBook.Enabled = false;
            txtIDBook.Location = new System.Drawing.Point(50, 113);
            txtIDBook.MenuManager = barManager1;
            txtIDBook.Name = "txtIDBook";
            txtIDBook.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtIDBook.Properties.Appearance.Options.UseFont = true;
            txtIDBook.Size = new System.Drawing.Size(255, 40);
            txtIDBook.TabIndex = 10;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnAdd, btnDelete, btnClose });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            bar2.BarAppearance.Normal.BackColor = System.Drawing.Color.Transparent;
            bar2.BarAppearance.Normal.BorderColor = System.Drawing.Color.DimGray;
            bar2.BarAppearance.Normal.Options.UseBackColor = true;
            bar2.BarAppearance.Normal.Options.UseBorderColor = true;
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnAdd, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnDelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnClose, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            btnAdd.Caption = "Thêm";
            btnAdd.Id = 0;
            btnAdd.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnAdd.ImageOptions.Image");
            btnAdd.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnAdd.ImageOptions.LargeImage");
            btnAdd.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.ItemAppearance.Normal.Options.UseFont = true;
            btnAdd.Name = "btnAdd";
            // 
            // btnDelete
            // 
            btnDelete.Caption = "Xóa";
            btnDelete.Id = 1;
            btnDelete.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDelete.ImageOptions.Image");
            btnDelete.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnDelete.ImageOptions.LargeImage");
            btnDelete.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.ItemAppearance.Normal.Options.UseFont = true;
            btnDelete.Name = "btnDelete";
            // 
            // btnClose
            // 
            btnClose.Caption = "Đóng";
            btnClose.Id = 3;
            btnClose.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnClose.ImageOptions.LargeImage");
            btnClose.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.ItemAppearance.Normal.Options.UseFont = true;
            btnClose.Name = "btnClose";
            btnClose.ItemClick += btnClose_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new System.Drawing.Size(832, 26);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 551);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(832, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 525);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(832, 26);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 525);
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(50, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(127, 17);
            label2.TabIndex = 9;
            label2.Text = "BarCode || Mã sách";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(50, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 17);
            label1.TabIndex = 7;
            label1.Text = "Mã hóa đơn:";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.Azure;
            panel3.Controls.Add(txtIDBook);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtIDBookReceipt);
            panel3.Controls.Add(label1);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(490, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(342, 195);
            panel3.TabIndex = 1;
            // 
            // txtIDBookReceipt
            // 
            txtIDBookReceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtIDBookReceipt.Enabled = false;
            txtIDBookReceipt.Location = new System.Drawing.Point(141, 51);
            txtIDBookReceipt.MenuManager = barManager1;
            txtIDBookReceipt.Name = "txtIDBookReceipt";
            txtIDBookReceipt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIDBookReceipt.Properties.Appearance.Options.UseFont = true;
            txtIDBookReceipt.Size = new System.Drawing.Size(164, 22);
            txtIDBookReceipt.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 26);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(832, 195);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupControl2);
            panel2.Controls.Add(panel4);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(490, 195);
            panel2.TabIndex = 0;
            // 
            // groupControl2
            // 
            groupControl2.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            groupControl2.Controls.Add(gcBooks);
            groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl2.Location = new System.Drawing.Point(0, 22);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new System.Drawing.Size(490, 173);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "Danh sách sách";
            // 
            // gcBooks
            // 
            gcBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            gcBooks.Location = new System.Drawing.Point(2, 23);
            gcBooks.MainView = gvBooks;
            gcBooks.MenuManager = barManager1;
            gcBooks.Name = "gcBooks";
            gcBooks.Size = new System.Drawing.Size(486, 148);
            gcBooks.TabIndex = 0;
            gcBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvBooks });
            // 
            // gvBooks
            // 
            gvBooks.GridControl = gcBooks;
            gvBooks.Name = "gvBooks";
            gvBooks.OptionsView.ShowGroupPanel = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(btnSearch);
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(490, 22);
            panel4.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSearch.Location = new System.Drawing.Point(0, 0);
            txtSearch.MenuManager = barManager1;
            txtSearch.Name = "txtSearch";
            txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Properties.Appearance.Options.UseFont = true;
            txtSearch.Properties.NullText = "Nhập tên loại sách...";
            txtSearch.Size = new System.Drawing.Size(396, 22);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            btnSearch.Location = new System.Drawing.Point(396, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 22);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.Controls.Add(gcBookReceiptDetail);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupControl1.Location = new System.Drawing.Point(0, 221);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(832, 330);
            groupControl1.TabIndex = 9;
            groupControl1.Text = "Thông tin phiếu nhập";
            // 
            // gcBookReceiptDetail
            // 
            gcBookReceiptDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            gcBookReceiptDetail.Location = new System.Drawing.Point(2, 23);
            gcBookReceiptDetail.MainView = gvBookReceiptDetail;
            gcBookReceiptDetail.MenuManager = barManager1;
            gcBookReceiptDetail.Name = "gcBookReceiptDetail";
            gcBookReceiptDetail.Size = new System.Drawing.Size(828, 305);
            gcBookReceiptDetail.TabIndex = 0;
            gcBookReceiptDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvBookReceiptDetail });
            // 
            // gvBookReceiptDetail
            // 
            gvBookReceiptDetail.GridControl = gcBookReceiptDetail;
            gvBookReceiptDetail.Name = "gvBookReceiptDetail";
            gvBookReceiptDetail.OptionsView.ShowGroupPanel = false;
            // 
            // frmBookSalesInvoiceDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(832, 551);
            Controls.Add(panel1);
            Controls.Add(groupControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "frmBookSalesInvoiceDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmBookSalesInvoiceDetail";
            ((System.ComponentModel.ISupportInitialize)txtIDBook.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtIDBookReceipt.Properties).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvBooks).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcBookReceiptDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvBookReceiptDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtIDBook;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtIDBookReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcBooks;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBooks;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcBookReceiptDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBookReceiptDetail;
    }
}