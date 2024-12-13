namespace GUI.UI
{
    partial class uiBookSalesInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiBookSalesInvoice));
            cbxStaff = new System.Windows.Forms.ComboBox();
            cbxPublisher = new System.Windows.Forms.ComboBox();
            txtDate = new DevExpress.XtraEditors.DateEdit();
            btnAdd = new DevExpress.XtraBars.BarButtonItem();
            btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            btnSave = new DevExpress.XtraBars.BarButtonItem();
            btnCancel = new DevExpress.XtraBars.BarButtonItem();
            btnDetail = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            txtStaff = new System.Windows.Forms.ComboBox();
            txtTotal = new System.Windows.Forms.RichTextBox();
            txtDateCreate = new DevExpress.XtraEditors.DateEdit();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnAddInvoice = new DevExpress.XtraBars.BarButtonItem();
            btnUpdateInvoice = new DevExpress.XtraBars.BarButtonItem();
            btnDeleteInvoice = new DevExpress.XtraBars.BarButtonItem();
            btnSaveInvoice = new DevExpress.XtraBars.BarButtonItem();
            btnCancell = new DevExpress.XtraBars.BarButtonItem();
            btnInvoiceDetail = new DevExpress.XtraBars.BarButtonItem();
            btnPrint = new DevExpress.XtraBars.BarButtonItem();
            btnCloseUI = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            txtID = new DevExpress.XtraEditors.TextEdit();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            gcBookInvoice = new DevExpress.XtraGrid.GridControl();
            gvBookInvoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            panel1 = new System.Windows.Forms.Panel();
            txtSearch = new DevExpress.XtraEditors.TextEdit();
            btnSearch = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDateCreate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDateCreate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcBookInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvBookInvoice).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            SuspendLayout();
            // 
            // cbxStaff
            // 
            cbxStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbxStaff.FormattingEnabled = true;
            cbxStaff.Location = new System.Drawing.Point(802, 113);
            cbxStaff.Name = "cbxStaff";
            cbxStaff.Size = new System.Drawing.Size(143, 23);
            cbxStaff.TabIndex = 14;
            // 
            // cbxPublisher
            // 
            cbxPublisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbxPublisher.FormattingEnabled = true;
            cbxPublisher.Location = new System.Drawing.Point(802, 77);
            cbxPublisher.Name = "cbxPublisher";
            cbxPublisher.Size = new System.Drawing.Size(143, 23);
            cbxPublisher.TabIndex = 13;
            // 
            // txtDate
            // 
            txtDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtDate.EditValue = null;
            txtDate.Location = new System.Drawing.Point(149, 86);
            txtDate.Name = "txtDate";
            txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtDate.Size = new System.Drawing.Size(100, 20);
            txtDate.TabIndex = 0;
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
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(938, 26);
            barDockControlRight.Manager = null;
            barDockControlRight.Size = new System.Drawing.Size(0, 600);
            // 
            // txtStaff
            // 
            txtStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtStaff.Enabled = false;
            txtStaff.FormattingEnabled = true;
            txtStaff.Location = new System.Drawing.Point(599, 57);
            txtStaff.Name = "txtStaff";
            txtStaff.Size = new System.Drawing.Size(165, 21);
            txtStaff.TabIndex = 14;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtTotal.Enabled = false;
            txtTotal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTotal.ForeColor = System.Drawing.Color.Red;
            txtTotal.Location = new System.Drawing.Point(599, 89);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(165, 22);
            txtTotal.TabIndex = 12;
            txtTotal.Text = "0";
            // 
            // txtDateCreate
            // 
            txtDateCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtDateCreate.EditValue = null;
            txtDateCreate.Location = new System.Drawing.Point(283, 89);
            txtDateCreate.MenuManager = barManager1;
            txtDateCreate.Name = "txtDateCreate";
            txtDateCreate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDateCreate.Properties.Appearance.Options.UseFont = true;
            txtDateCreate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtDateCreate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtDateCreate.Size = new System.Drawing.Size(159, 22);
            txtDateCreate.TabIndex = 11;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControl1);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnAddInvoice, btnUpdateInvoice, btnDeleteInvoice, btnSaveInvoice, btnCancell, btnCloseUI, btnInvoiceDetail, btnPrint });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnAddInvoice, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnUpdateInvoice, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnDeleteInvoice, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnSaveInvoice, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnCancell, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnInvoiceDetail, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnPrint, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnCloseUI, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // btnAddInvoice
            // 
            btnAddInvoice.Caption = "Thêm";
            btnAddInvoice.Id = 0;
            btnAddInvoice.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnAddInvoice.ImageOptions.Image");
            btnAddInvoice.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnAddInvoice.ImageOptions.LargeImage");
            btnAddInvoice.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddInvoice.ItemAppearance.Normal.Options.UseFont = true;
            btnAddInvoice.Name = "btnAddInvoice";
            btnAddInvoice.ItemClick += btnAddInvoice_ItemClick;
            // 
            // btnUpdateInvoice
            // 
            btnUpdateInvoice.Caption = "Cập nhật";
            btnUpdateInvoice.Id = 1;
            btnUpdateInvoice.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnUpdateInvoice.ImageOptions.Image");
            btnUpdateInvoice.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnUpdateInvoice.ImageOptions.LargeImage");
            btnUpdateInvoice.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdateInvoice.ItemAppearance.Normal.Options.UseFont = true;
            btnUpdateInvoice.Name = "btnUpdateInvoice";
            btnUpdateInvoice.ItemClick += btnUpdateInvoice_ItemClick;
            // 
            // btnDeleteInvoice
            // 
            btnDeleteInvoice.Caption = "Xóa";
            btnDeleteInvoice.Id = 2;
            btnDeleteInvoice.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDeleteInvoice.ImageOptions.Image");
            btnDeleteInvoice.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnDeleteInvoice.ImageOptions.LargeImage");
            btnDeleteInvoice.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDeleteInvoice.ItemAppearance.Normal.Options.UseFont = true;
            btnDeleteInvoice.Name = "btnDeleteInvoice";
            btnDeleteInvoice.ItemClick += btnDeleteInvoice_ItemClick;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.Caption = "Lưu";
            btnSaveInvoice.Id = 3;
            btnSaveInvoice.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSaveInvoice.ImageOptions.Image");
            btnSaveInvoice.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnSaveInvoice.ImageOptions.LargeImage");
            btnSaveInvoice.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSaveInvoice.ItemAppearance.Normal.Options.UseFont = true;
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.ItemClick += btnSaveInvoice_ItemClick;
            // 
            // btnCancell
            // 
            btnCancell.Caption = "Hủy";
            btnCancell.Id = 4;
            btnCancell.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnCancell.ImageOptions.Image");
            btnCancell.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnCancell.ImageOptions.LargeImage");
            btnCancell.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancell.ItemAppearance.Normal.Options.UseFont = true;
            btnCancell.Name = "btnCancell";
            btnCancell.ItemClick += btnCancell_ItemClick;
            // 
            // btnInvoiceDetail
            // 
            btnInvoiceDetail.Caption = "Chi tiết hóa đơn";
            btnInvoiceDetail.Id = 6;
            btnInvoiceDetail.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnInvoiceDetail.ImageOptions.Image");
            btnInvoiceDetail.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnInvoiceDetail.ImageOptions.LargeImage");
            btnInvoiceDetail.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnInvoiceDetail.ItemAppearance.Normal.Options.UseFont = true;
            btnInvoiceDetail.Name = "btnInvoiceDetail";
            btnInvoiceDetail.ItemClick += btnInvoiceDetail_ItemClick;
            // 
            // btnPrint
            // 
            btnPrint.Caption = "In hóa đơn";
            btnPrint.Id = 7;
            btnPrint.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnPrint.ImageOptions.Image");
            btnPrint.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnPrint.ImageOptions.LargeImage");
            btnPrint.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPrint.ItemAppearance.Normal.Options.UseFont = true;
            btnPrint.Name = "btnPrint";
            // 
            // btnCloseUI
            // 
            btnCloseUI.Caption = "Đóng";
            btnCloseUI.Id = 5;
            btnCloseUI.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnCloseUI.ImageOptions.Image");
            btnCloseUI.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnCloseUI.ImageOptions.LargeImage");
            btnCloseUI.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCloseUI.ItemAppearance.Normal.Options.UseFont = true;
            btnCloseUI.Name = "btnCloseUI";
            btnCloseUI.ItemClick += btnCloseUI_ItemClick;
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
            // barDockControl1
            // 
            barDockControl1.CausesValidation = false;
            barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControl1.Location = new System.Drawing.Point(938, 26);
            barDockControl1.Manager = barManager1;
            barDockControl1.Size = new System.Drawing.Size(0, 600);
            // 
            // txtID
            // 
            txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtID.Location = new System.Drawing.Point(283, 56);
            txtID.MenuManager = barManager1;
            txtID.Name = "txtID";
            txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtID.Properties.Appearance.Options.UseFont = true;
            txtID.Size = new System.Drawing.Size(159, 22);
            txtID.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(483, 90);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(71, 17);
            label5.TabIndex = 4;
            label5.Text = "Tổng tiền:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(483, 59);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 17);
            label3.TabIndex = 2;
            label3.Text = "Nhân viên lập:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(175, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // groupControl2
            // 
            groupControl2.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            groupControl2.Controls.Add(gcBookInvoice);
            groupControl2.Controls.Add(panel1);
            groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl2.Location = new System.Drawing.Point(0, 176);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new System.Drawing.Size(938, 450);
            groupControl2.TabIndex = 9;
            groupControl2.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // gcBookInvoice
            // 
            gcBookInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            gcBookInvoice.Location = new System.Drawing.Point(2, 45);
            gcBookInvoice.MainView = gvBookInvoice;
            gcBookInvoice.MenuManager = barManager1;
            gcBookInvoice.Name = "gcBookInvoice";
            gcBookInvoice.Size = new System.Drawing.Size(934, 403);
            gcBookInvoice.TabIndex = 1;
            gcBookInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvBookInvoice });
            // 
            // gvBookInvoice
            // 
            gvBookInvoice.GridControl = gcBookInvoice;
            gvBookInvoice.Name = "gvBookInvoice";
            gvBookInvoice.OptionsBehavior.Editable = false;
            gvBookInvoice.OptionsBehavior.ReadOnly = true;
            gvBookInvoice.OptionsView.ShowGroupPanel = false;
            gvBookInvoice.RowClick += gvBookInvoice_RowClick;
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
            txtSearch.Properties.NullText = "Nhập mã hóa đơn...";
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
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(175, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 17);
            label2.TabIndex = 1;
            label2.Text = "Ngày lập:";
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.Controls.Add(txtStaff);
            groupControl1.Controls.Add(txtTotal);
            groupControl1.Controls.Add(txtDateCreate);
            groupControl1.Controls.Add(txtID);
            groupControl1.Controls.Add(label5);
            groupControl1.Controls.Add(label3);
            groupControl1.Controls.Add(label2);
            groupControl1.Controls.Add(label1);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            groupControl1.Location = new System.Drawing.Point(0, 26);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(938, 150);
            groupControl1.TabIndex = 8;
            groupControl1.Text = "THÔNG TIN HÓA ĐƠN BÁN HÀNG";
            // 
            // uiBookSalesInvoice
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControl1);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "uiBookSalesInvoice";
            Size = new System.Drawing.Size(938, 626);
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDateCreate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDateCreate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcBookInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvBookInvoice).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtSearch.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbxStaff;
        private System.Windows.Forms.ComboBox cbxPublisher;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnDetail;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ComboBox txtStaff;
        private System.Windows.Forms.RichTextBox txtTotal;
        private DevExpress.XtraEditors.DateEdit txtDateCreate;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAddInvoice;
        private DevExpress.XtraBars.BarButtonItem btnUpdateInvoice;
        private DevExpress.XtraBars.BarButtonItem btnDeleteInvoice;
        private DevExpress.XtraBars.BarButtonItem btnSaveInvoice;
        private DevExpress.XtraBars.BarButtonItem btnCancell;
        private DevExpress.XtraBars.BarButtonItem btnInvoiceDetail;
        private DevExpress.XtraBars.BarButtonItem btnCloseUI;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcBookInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBookInvoice;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
    }
}
