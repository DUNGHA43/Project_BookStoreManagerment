﻿namespace GUI.UI
{
    partial class uiBookReceipts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiBookReceipts));
            btnSearch = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            txtSearch = new DevExpress.XtraEditors.TextEdit();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnAdd = new DevExpress.XtraBars.BarButtonItem();
            btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            btnSave = new DevExpress.XtraBars.BarButtonItem();
            btnCancel = new DevExpress.XtraBars.BarButtonItem();
            btnDetail = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            gvBookReceipts = new DevExpress.XtraGrid.Views.Grid.GridView();
            gcBookReceipts = new DevExpress.XtraGrid.GridControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            txtTotal = new System.Windows.Forms.RichTextBox();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            cbxStaff = new System.Windows.Forms.ComboBox();
            cbxPublisher = new System.Windows.Forms.ComboBox();
            txtDate = new DevExpress.XtraEditors.DateEdit();
            txtID = new DevExpress.XtraEditors.TextEdit();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvBookReceipts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcBookReceipts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            btnSearch.Location = new System.Drawing.Point(827, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(107, 22);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(2, 23);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(934, 22);
            panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSearch.Location = new System.Drawing.Point(0, 0);
            txtSearch.MenuManager = barManager1;
            txtSearch.Name = "txtSearch";
            txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Properties.Appearance.Options.UseFont = true;
            txtSearch.Properties.NullText = "Nhập mã phiếu nhập...";
            txtSearch.Size = new System.Drawing.Size(827, 22);
            txtSearch.TabIndex = 1;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnAdd, btnUpdate, btnDelete, btnSave, btnCancel, btnClose, btnDetail });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnAdd, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnUpdate, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnDelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnCancel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnDetail, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnClose, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
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
            // btnUpdate
            // 
            btnUpdate.Caption = "Cập nhật";
            btnUpdate.Id = 1;
            btnUpdate.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnUpdate.ImageOptions.Image");
            btnUpdate.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnUpdate.ImageOptions.LargeImage");
            btnUpdate.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.ItemAppearance.Normal.Options.UseFont = true;
            btnUpdate.Name = "btnUpdate";
            // 
            // btnDelete
            // 
            btnDelete.Caption = "Xóa";
            btnDelete.Id = 2;
            btnDelete.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDelete.ImageOptions.Image");
            btnDelete.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnDelete.ImageOptions.LargeImage");
            btnDelete.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.ItemAppearance.Normal.Options.UseFont = true;
            btnDelete.Name = "btnDelete";
            // 
            // btnSave
            // 
            btnSave.Caption = "Lưu";
            btnSave.Id = 3;
            btnSave.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSave.ImageOptions.Image");
            btnSave.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnSave.ImageOptions.LargeImage");
            btnSave.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSave.ItemAppearance.Normal.Options.UseFont = true;
            btnSave.Name = "btnSave";
            // 
            // btnCancel
            // 
            btnCancel.Caption = "Hủy";
            btnCancel.Id = 4;
            btnCancel.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnCancel.ImageOptions.Image");
            btnCancel.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnCancel.ImageOptions.LargeImage");
            btnCancel.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.ItemAppearance.Normal.Options.UseFont = true;
            btnCancel.Name = "btnCancel";
            // 
            // btnDetail
            // 
            btnDetail.Caption = "Chi tiết phiếu nhập";
            btnDetail.Id = 6;
            btnDetail.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDetail.ImageOptions.Image");
            btnDetail.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnDetail.ImageOptions.LargeImage");
            btnDetail.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDetail.ItemAppearance.Normal.Options.UseFont = true;
            btnDetail.Name = "btnDetail";
            btnDetail.ItemClick += btnDetail_ItemClick;
            // 
            // btnClose
            // 
            btnClose.Caption = "Đóng";
            btnClose.Id = 5;
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
            barDockControlTop.Size = new System.Drawing.Size(938, 26);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 626);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(938, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 600);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(938, 26);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 600);
            // 
            // gvBookReceipts
            // 
            gvBookReceipts.GridControl = gcBookReceipts;
            gvBookReceipts.Name = "gvBookReceipts";
            gvBookReceipts.OptionsView.ShowGroupPanel = false;
            // 
            // gcBookReceipts
            // 
            gcBookReceipts.Dock = System.Windows.Forms.DockStyle.Fill;
            gcBookReceipts.Location = new System.Drawing.Point(2, 45);
            gcBookReceipts.MainView = gvBookReceipts;
            gcBookReceipts.MenuManager = barManager1;
            gcBookReceipts.Name = "gcBookReceipts";
            gcBookReceipts.Size = new System.Drawing.Size(934, 403);
            gcBookReceipts.TabIndex = 1;
            gcBookReceipts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvBookReceipts });
            // 
            // groupControl2
            // 
            groupControl2.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            groupControl2.Controls.Add(gcBookReceipts);
            groupControl2.Controls.Add(panel1);
            groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl2.Location = new System.Drawing.Point(0, 176);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new System.Drawing.Size(938, 450);
            groupControl2.TabIndex = 7;
            groupControl2.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtTotal.Enabled = false;
            txtTotal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTotal.ForeColor = System.Drawing.Color.Red;
            txtTotal.Location = new System.Drawing.Point(695, 50);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(177, 22);
            txtTotal.TabIndex = 12;
            txtTotal.Text = "0";
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.Controls.Add(cbxStaff);
            groupControl1.Controls.Add(cbxPublisher);
            groupControl1.Controls.Add(txtTotal);
            groupControl1.Controls.Add(txtDate);
            groupControl1.Controls.Add(txtID);
            groupControl1.Controls.Add(label5);
            groupControl1.Controls.Add(label4);
            groupControl1.Controls.Add(label3);
            groupControl1.Controls.Add(label2);
            groupControl1.Controls.Add(label1);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            groupControl1.Location = new System.Drawing.Point(0, 26);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(938, 150);
            groupControl1.TabIndex = 6;
            groupControl1.Text = "THÔNG TIN PHIẾU NHẬP";
            // 
            // cbxStaff
            // 
            cbxStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbxStaff.FormattingEnabled = true;
            cbxStaff.Location = new System.Drawing.Point(433, 88);
            cbxStaff.Name = "cbxStaff";
            cbxStaff.Size = new System.Drawing.Size(143, 21);
            cbxStaff.TabIndex = 14;
            // 
            // cbxPublisher
            // 
            cbxPublisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbxPublisher.FormattingEnabled = true;
            cbxPublisher.Location = new System.Drawing.Point(433, 52);
            cbxPublisher.Name = "cbxPublisher";
            cbxPublisher.Size = new System.Drawing.Size(143, 21);
            cbxPublisher.TabIndex = 13;
            // 
            // txtDate
            // 
            txtDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtDate.EditValue = null;
            txtDate.Location = new System.Drawing.Point(149, 86);
            txtDate.MenuManager = barManager1;
            txtDate.Name = "txtDate";
            txtDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDate.Properties.Appearance.Options.UseFont = true;
            txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtDate.Size = new System.Drawing.Size(143, 22);
            txtDate.TabIndex = 11;
            // 
            // txtID
            // 
            txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtID.Location = new System.Drawing.Point(149, 50);
            txtID.MenuManager = barManager1;
            txtID.Name = "txtID";
            txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtID.Properties.Appearance.Options.UseFont = true;
            txtID.Size = new System.Drawing.Size(143, 22);
            txtID.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(620, 53);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(71, 17);
            label5.TabIndex = 4;
            label5.Text = "Tổng tiền:";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(331, 53);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(96, 17);
            label4.TabIndex = 3;
            label4.Text = "Nhà xuất bản:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(331, 89);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 17);
            label3.TabIndex = 2;
            label3.Text = "Nhân viên lập:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(41, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 17);
            label2.TabIndex = 1;
            label2.Text = "Ngày nhập:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(41, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu nhập:";
            // 
            // uiBookReceipts
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "uiBookReceipts";
            Size = new System.Drawing.Size(938, 626);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvBookReceipts).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcBookReceipts).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcBookReceipts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBookReceipts;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox txtTotal;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private DevExpress.XtraEditors.TextEdit txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPublisher;
        private System.Windows.Forms.ComboBox cbxStaff;
        private DevExpress.XtraBars.BarButtonItem btnDetail;
    }
}