namespace GUI.UI
{
    partial class frmBookReceiptDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookReceiptDetail));
            gvBookReceiptDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            gcBookReceiptDetail = new DevExpress.XtraGrid.GridControl();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnAdd = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            txtSearch = new DevExpress.XtraEditors.TextEdit();
            btnSearch = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            gvBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
            gcBooks = new DevExpress.XtraGrid.GridControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            panel2 = new System.Windows.Forms.Panel();
            txtTotal = new DevExpress.XtraEditors.TextEdit();
            label4 = new System.Windows.Forms.Label();
            txtQuanlity = new DevExpress.XtraEditors.TextEdit();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            txtIDBook = new DevExpress.XtraEditors.TextEdit();
            label2 = new System.Windows.Forms.Label();
            txtIDBookReceipt = new DevExpress.XtraEditors.TextEdit();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)gvBookReceiptDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcBookReceiptDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTotal.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuanlity.Properties).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtIDBook.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIDBookReceipt.Properties).BeginInit();
            SuspendLayout();
            // 
            // gvBookReceiptDetail
            // 
            gvBookReceiptDetail.GridControl = gcBookReceiptDetail;
            gvBookReceiptDetail.Name = "gvBookReceiptDetail";
            gvBookReceiptDetail.OptionsBehavior.Editable = false;
            gvBookReceiptDetail.OptionsBehavior.ReadOnly = true;
            gvBookReceiptDetail.OptionsView.ShowGroupPanel = false;
            gvBookReceiptDetail.RowClick += gvBookReceiptDetail_RowClick;
            // 
            // gcBookReceiptDetail
            // 
            gcBookReceiptDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            gcBookReceiptDetail.Location = new System.Drawing.Point(2, 23);
            gcBookReceiptDetail.MainView = gvBookReceiptDetail;
            gcBookReceiptDetail.MenuManager = barManager1;
            gcBookReceiptDetail.Name = "gcBookReceiptDetail";
            gcBookReceiptDetail.Size = new System.Drawing.Size(828, 282);
            gcBookReceiptDetail.TabIndex = 0;
            gcBookReceiptDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvBookReceiptDetail });
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
            btnAdd.ItemClick += btnAdd_ItemClick;
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
            btnDelete.ItemClick += btnDelete_ItemClick;
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
            barDockControlBottom.Location = new System.Drawing.Point(0, 541);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(832, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 515);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(832, 26);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 515);
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.Controls.Add(gcBookReceiptDetail);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl1.Location = new System.Drawing.Point(0, 234);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(832, 307);
            groupControl1.TabIndex = 7;
            groupControl1.Text = "Thông tin phiếu nhập";
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
            btnSearch.Click += btnSearch_Click;
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
            // gvBooks
            // 
            gvBooks.GridControl = gcBooks;
            gvBooks.Name = "gvBooks";
            gvBooks.OptionsBehavior.Editable = false;
            gvBooks.OptionsBehavior.ReadOnly = true;
            gvBooks.OptionsView.ShowGroupPanel = false;
            gvBooks.RowClick += gvBooks_RowClick;
            // 
            // gcBooks
            // 
            gcBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            gcBooks.Location = new System.Drawing.Point(2, 23);
            gcBooks.MainView = gvBooks;
            gcBooks.MenuManager = barManager1;
            gcBooks.Name = "gcBooks";
            gcBooks.Size = new System.Drawing.Size(486, 161);
            gcBooks.TabIndex = 0;
            gcBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvBooks });
            // 
            // groupControl2
            // 
            groupControl2.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            groupControl2.Controls.Add(gcBooks);
            groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl2.Location = new System.Drawing.Point(0, 22);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new System.Drawing.Size(490, 186);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "Danh sách sách";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupControl2);
            panel2.Controls.Add(panel4);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(490, 208);
            panel2.TabIndex = 0;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtTotal.Enabled = false;
            txtTotal.Location = new System.Drawing.Point(161, 135);
            txtTotal.MenuManager = barManager1;
            txtTotal.Name = "txtTotal";
            txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTotal.Properties.Appearance.Options.UseFont = true;
            txtTotal.Size = new System.Drawing.Size(143, 22);
            txtTotal.TabIndex = 14;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(49, 138);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(78, 17);
            label4.TabIndex = 13;
            label4.Text = "Thành tiền:";
            // 
            // txtQuanlity
            // 
            txtQuanlity.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtQuanlity.Location = new System.Drawing.Point(161, 107);
            txtQuanlity.MenuManager = barManager1;
            txtQuanlity.Name = "txtQuanlity";
            txtQuanlity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtQuanlity.Properties.Appearance.Options.UseFont = true;
            txtQuanlity.Size = new System.Drawing.Size(143, 22);
            txtQuanlity.TabIndex = 12;
            txtQuanlity.TextChanged += txtQuanlity_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(49, 110);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(103, 17);
            label3.TabIndex = 11;
            label3.Text = "Số lượng nhập:";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 26);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(832, 208);
            panel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.Azure;
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtQuanlity);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtIDBook);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtIDBookReceipt);
            panel3.Controls.Add(label1);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(490, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(342, 208);
            panel3.TabIndex = 1;
            // 
            // txtIDBook
            // 
            txtIDBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtIDBook.Enabled = false;
            txtIDBook.Location = new System.Drawing.Point(161, 79);
            txtIDBook.MenuManager = barManager1;
            txtIDBook.Name = "txtIDBook";
            txtIDBook.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIDBook.Properties.Appearance.Options.UseFont = true;
            txtIDBook.Size = new System.Drawing.Size(143, 22);
            txtIDBook.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(49, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 17);
            label2.TabIndex = 9;
            label2.Text = "Mã sách:";
            // 
            // txtIDBookReceipt
            // 
            txtIDBookReceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtIDBookReceipt.Enabled = false;
            txtIDBookReceipt.Location = new System.Drawing.Point(161, 51);
            txtIDBookReceipt.MenuManager = barManager1;
            txtIDBookReceipt.Name = "txtIDBookReceipt";
            txtIDBookReceipt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIDBookReceipt.Properties.Appearance.Options.UseFont = true;
            txtIDBookReceipt.Size = new System.Drawing.Size(143, 22);
            txtIDBookReceipt.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(49, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 17);
            label1.TabIndex = 7;
            label1.Text = "Mã phiếu nhập:";
            // 
            // frmBookReceiptDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(832, 541);
            ControlBox = false;
            Controls.Add(groupControl1);
            Controls.Add(panel1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            IconOptions.LargeImage = (System.Drawing.Image)resources.GetObject("frmBookReceiptDetail.IconOptions.LargeImage");
            Name = "frmBookReceiptDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Chi tiết phiếu nhập";
            ((System.ComponentModel.ISupportInitialize)gvBookReceiptDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcBookReceiptDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtTotal.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuanlity.Properties).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtIDBook.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIDBookReceipt.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvBookReceiptDetail;
        private DevExpress.XtraGrid.GridControl gcBookReceiptDetail;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtQuanlity;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtIDBook;
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
    }
}