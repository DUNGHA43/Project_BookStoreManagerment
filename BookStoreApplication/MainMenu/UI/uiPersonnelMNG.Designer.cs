namespace GUI.UI
{
    partial class uiPersonnelMNG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiPersonnelMNG));
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnAdd = new DevExpress.XtraBars.BarButtonItem();
            btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            btnSave = new DevExpress.XtraBars.BarButtonItem();
            btnCancel = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            txtAddress = new System.Windows.Forms.RichTextBox();
            txtBirth = new DevExpress.XtraEditors.DateEdit();
            txtIdentification = new DevExpress.XtraEditors.TextEdit();
            txtWorkSchedule = new DevExpress.XtraEditors.TextEdit();
            txtPhone = new DevExpress.XtraEditors.TextEdit();
            txtFullName = new DevExpress.XtraEditors.TextEdit();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            gcStaff = new DevExpress.XtraGrid.GridControl();
            gvStaff = new DevExpress.XtraGrid.Views.Grid.GridView();
            panel1 = new System.Windows.Forms.Panel();
            txtSearch = new DevExpress.XtraEditors.TextEdit();
            btnSearch = new System.Windows.Forms.Button();
            txtID = new DevExpress.XtraEditors.TextEdit();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBirth.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBirth.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIdentification.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtWorkSchedule.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPhone.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvStaff).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).BeginInit();
            SuspendLayout();
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnAdd, btnUpdate, btnDelete, btnSave, btnCancel, btnClose });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnAdd, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnUpdate, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnDelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnCancel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnClose, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
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
            // btnClose
            // 
            btnClose.Caption = "Đóng";
            btnClose.Id = 5;
            btnClose.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnClose.ImageOptions.LargeImage");
            btnClose.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.ItemAppearance.Normal.Options.UseFont = true;
            btnClose.Name = "btnClose";
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
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.Controls.Add(txtID);
            groupControl1.Controls.Add(label7);
            groupControl1.Controls.Add(txtAddress);
            groupControl1.Controls.Add(txtBirth);
            groupControl1.Controls.Add(txtIdentification);
            groupControl1.Controls.Add(txtWorkSchedule);
            groupControl1.Controls.Add(txtPhone);
            groupControl1.Controls.Add(txtFullName);
            groupControl1.Controls.Add(label6);
            groupControl1.Controls.Add(label5);
            groupControl1.Controls.Add(label4);
            groupControl1.Controls.Add(label3);
            groupControl1.Controls.Add(label2);
            groupControl1.Controls.Add(label1);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            groupControl1.Location = new System.Drawing.Point(0, 26);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(938, 150);
            groupControl1.TabIndex = 4;
            groupControl1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtAddress.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAddress.Location = new System.Drawing.Point(717, 72);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(177, 57);
            txtAddress.TabIndex = 12;
            txtAddress.Text = "";
            // 
            // txtBirth
            // 
            txtBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtBirth.EditValue = null;
            txtBirth.Location = new System.Drawing.Point(138, 76);
            txtBirth.MenuManager = barManager1;
            txtBirth.Name = "txtBirth";
            txtBirth.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtBirth.Properties.Appearance.Options.UseFont = true;
            txtBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtBirth.Size = new System.Drawing.Size(143, 22);
            txtBirth.TabIndex = 11;
            // 
            // txtIdentification
            // 
            txtIdentification.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtIdentification.Location = new System.Drawing.Point(430, 76);
            txtIdentification.MenuManager = barManager1;
            txtIdentification.Name = "txtIdentification";
            txtIdentification.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIdentification.Properties.Appearance.Options.UseFont = true;
            txtIdentification.Size = new System.Drawing.Size(143, 22);
            txtIdentification.TabIndex = 10;
            // 
            // txtWorkSchedule
            // 
            txtWorkSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtWorkSchedule.Location = new System.Drawing.Point(717, 44);
            txtWorkSchedule.MenuManager = barManager1;
            txtWorkSchedule.Name = "txtWorkSchedule";
            txtWorkSchedule.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtWorkSchedule.Properties.Appearance.Options.UseFont = true;
            txtWorkSchedule.Size = new System.Drawing.Size(177, 22);
            txtWorkSchedule.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtPhone.Location = new System.Drawing.Point(430, 44);
            txtPhone.MenuManager = barManager1;
            txtPhone.Name = "txtPhone";
            txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPhone.Properties.Appearance.Options.UseFont = true;
            txtPhone.Size = new System.Drawing.Size(143, 22);
            txtPhone.TabIndex = 7;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtFullName.Location = new System.Drawing.Point(138, 44);
            txtFullName.MenuManager = barManager1;
            txtFullName.Name = "txtFullName";
            txtFullName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFullName.Properties.Appearance.Options.UseFont = true;
            txtFullName.Size = new System.Drawing.Size(143, 22);
            txtFullName.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(621, 47);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(90, 17);
            label6.TabIndex = 5;
            label6.Text = "Lịch làm việc:";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(621, 78);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 17);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(330, 47);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(92, 17);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(330, 79);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 17);
            label3.TabIndex = 2;
            label3.Text = "Số CCCD:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(40, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 17);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(40, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 17);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên:";
            // 
            // groupControl2
            // 
            groupControl2.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            groupControl2.Controls.Add(gcStaff);
            groupControl2.Controls.Add(panel1);
            groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl2.Location = new System.Drawing.Point(0, 176);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new System.Drawing.Size(938, 450);
            groupControl2.TabIndex = 5;
            groupControl2.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // gcStaff
            // 
            gcStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            gcStaff.Location = new System.Drawing.Point(2, 45);
            gcStaff.MainView = gvStaff;
            gcStaff.MenuManager = barManager1;
            gcStaff.Name = "gcStaff";
            gcStaff.Size = new System.Drawing.Size(934, 403);
            gcStaff.TabIndex = 1;
            gcStaff.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvStaff });
            // 
            // gvStaff
            // 
            gvStaff.GridControl = gcStaff;
            gvStaff.Name = "gvStaff";
            gvStaff.OptionsView.ShowGroupPanel = false;
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
            txtSearch.Properties.NullText = "Nhập họ tên nhân viên...";
            txtSearch.Size = new System.Drawing.Size(827, 22);
            txtSearch.TabIndex = 1;
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
            // txtID
            // 
            txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtID.Location = new System.Drawing.Point(138, 108);
            txtID.MenuManager = barManager1;
            txtID.Name = "txtID";
            txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtID.Properties.Appearance.Options.UseFont = true;
            txtID.Size = new System.Drawing.Size(143, 22);
            txtID.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(40, 111);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(94, 17);
            label7.TabIndex = 13;
            label7.Text = "Mã nhân viên:";
            // 
            // uiPersonnelMNG
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "uiPersonnelMNG";
            Size = new System.Drawing.Size(938, 626);
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBirth.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBirth.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIdentification.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtWorkSchedule.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPhone.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFullName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvStaff).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraGrid.GridControl gcStaff;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStaff;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtAddress;
        private DevExpress.XtraEditors.DateEdit txtBirth;
        private DevExpress.XtraEditors.TextEdit txtIdentification;
        private DevExpress.XtraEditors.TextEdit txtWorkSchedule;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtID;
        private System.Windows.Forms.Label label7;
    }
}
