namespace MainMenu
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            containerShow = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            ControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnShowStaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnShowAccount = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnShowReceipt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnShowInvoice = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnShowBooks = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnShowPublisher = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnShowCategory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnShowAuthor = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnShowStatisticsRececipt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnShowStatisticsInvoice = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnShowStatisticsRevenue = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnChangePass = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            btnLogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            title = new DevExpress.XtraBars.BarStaticItem();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            SuspendLayout();
            // 
            // containerShow
            // 
            containerShow.Dock = System.Windows.Forms.DockStyle.Fill;
            containerShow.Location = new System.Drawing.Point(260, 31);
            containerShow.Name = "containerShow";
            containerShow.Size = new System.Drawing.Size(981, 690);
            containerShow.TabIndex = 0;
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { ControlElement1, ControlElement2, ControlElement3, ControlElement4, ControlElement5 });
            accordionControl1.Location = new System.Drawing.Point(0, 31);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            accordionControl1.Size = new System.Drawing.Size(260, 690);
            accordionControl1.TabIndex = 1;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // ControlElement1
            // 
            ControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { btnShowStaff, btnShowAccount });
            ControlElement1.Expanded = true;
            ControlElement1.Name = "ControlElement1";
            ControlElement1.Text = "QUẢN LÝ THÀNH VIÊN";
            // 
            // btnShowStaff
            // 
            btnShowStaff.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnShowStaff.ImageOptions.Image");
            btnShowStaff.Name = "btnShowStaff";
            btnShowStaff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnShowStaff.Text = "DANH MỤC NHÂN VIÊN";
            btnShowStaff.Click += btnShowStaff_Click;
            // 
            // btnShowAccount
            // 
            btnShowAccount.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnShowAccount.ImageOptions.Image");
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnShowAccount.Text = "DANH MỤC NGƯỜI DÙNG";
            btnShowAccount.Click += btnShowAccount_Click;
            // 
            // ControlElement2
            // 
            ControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { btnShowReceipt, btnShowInvoice, btnShowBooks });
            ControlElement2.Expanded = true;
            ControlElement2.Name = "ControlElement2";
            ControlElement2.Text = "QUẢN LÝ KINH DOANH";
            // 
            // btnShowReceipt
            // 
            btnShowReceipt.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnShowReceipt.ImageOptions.Image");
            btnShowReceipt.Name = "btnShowReceipt";
            btnShowReceipt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnShowReceipt.Text = "DANH MỤC NHẬP SÁCH";
            btnShowReceipt.Click += btnShowReceipt_Click;
            // 
            // btnShowInvoice
            // 
            btnShowInvoice.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnShowInvoice.ImageOptions.Image");
            btnShowInvoice.Name = "btnShowInvoice";
            btnShowInvoice.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnShowInvoice.Text = "DANH MỤC BÁN SÁCH";
            btnShowInvoice.Click += btnShowInvoice_Click;
            // 
            // btnShowBooks
            // 
            btnShowBooks.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnShowBooks.ImageOptions.Image");
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnShowBooks.Text = "DANH MỤC KHO SÁCH";
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // ControlElement3
            // 
            ControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { btnShowPublisher, btnShowCategory, btnShowAuthor });
            ControlElement3.Expanded = true;
            ControlElement3.Name = "ControlElement3";
            ControlElement3.Text = "QUẢN LÝ KHÁC";
            // 
            // btnShowPublisher
            // 
            btnShowPublisher.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnShowPublisher.ImageOptions.Image");
            btnShowPublisher.Name = "btnShowPublisher";
            btnShowPublisher.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnShowPublisher.Text = "DANH MỤC NHÀ XUẤT BẢN";
            btnShowPublisher.Click += btnShowPublisher_Click;
            // 
            // btnShowCategory
            // 
            btnShowCategory.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnShowCategory.ImageOptions.Image");
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnShowCategory.Text = "DANH MỤC THỂ LOẠI";
            btnShowCategory.Click += btnShowCategory_Click;
            // 
            // btnShowAuthor
            // 
            btnShowAuthor.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnShowAuthor.ImageOptions.Image");
            btnShowAuthor.Name = "btnShowAuthor";
            btnShowAuthor.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnShowAuthor.Text = "DANH MỤC TÁC GIẢ";
            btnShowAuthor.Click += btnShowAuthor_Click;
            // 
            // ControlElement4
            // 
            ControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { btnShowStatisticsRececipt, btnShowStatisticsInvoice, btnShowStatisticsRevenue });
            ControlElement4.Expanded = true;
            ControlElement4.Name = "ControlElement4";
            ControlElement4.Text = "BÁO CÁO VÀ THỐNG KÊ";
            // 
            // btnShowStatisticsRececipt
            // 
            btnShowStatisticsRececipt.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnShowStatisticsRececipt.ImageOptions.Image");
            btnShowStatisticsRececipt.Name = "btnShowStatisticsRececipt";
            btnShowStatisticsRececipt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnShowStatisticsRececipt.Text = "THỐNG KÊ NHẬP";
            btnShowStatisticsRececipt.Click += btnShowStatisticsRececipt_Click;
            // 
            // btnShowStatisticsInvoice
            // 
            btnShowStatisticsInvoice.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnShowStatisticsInvoice.ImageOptions.Image");
            btnShowStatisticsInvoice.Name = "btnShowStatisticsInvoice";
            btnShowStatisticsInvoice.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnShowStatisticsInvoice.Text = "THỐNG KÊ XUẤT";
            btnShowStatisticsInvoice.Click += btnShowStatisticsInvoice_Click;
            // 
            // btnShowStatisticsRevenue
            // 
            btnShowStatisticsRevenue.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnShowStatisticsRevenue.ImageOptions.Image");
            btnShowStatisticsRevenue.Name = "btnShowStatisticsRevenue";
            btnShowStatisticsRevenue.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnShowStatisticsRevenue.Text = "THỐNG KÊ DOANH THU";
            btnShowStatisticsRevenue.Click += btnShowStatisticsRevenue_Click;
            // 
            // ControlElement5
            // 
            ControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { btnChangePass, btnLogOut });
            ControlElement5.Expanded = true;
            ControlElement5.Name = "ControlElement5";
            ControlElement5.Text = "HỆ THỐNG";
            // 
            // btnChangePass
            // 
            btnChangePass.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnChangePass.ImageOptions.Image");
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnChangePass.Text = "ĐỔI MẬT KHẨU";
            btnChangePass.Click += btnChangePass_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnLogOut.ImageOptions.Image");
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            btnLogOut.Text = "ĐĂNG XUẤT";
            btnLogOut.Click += btnLogOut_Click;
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { title });
            fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new System.Drawing.Size(1241, 31);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            fluentDesignFormControl1.TitleItemLinks.Add(title);
            // 
            // title
            // 
            title.Caption = "CHÚC MỘT NGÀY LÀM VIỆC VUI VẺ!";
            title.Id = 0;
            title.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            title.ItemAppearance.Normal.Options.UseFont = true;
            title.Name = "title";
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { title });
            fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1241, 721);
            ControlContainer = containerShow;
            Controls.Add(containerShow);
            Controls.Add(accordionControl1);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            IconOptions.Image = (System.Drawing.Image)resources.GetObject("frmMainMenu.IconOptions.Image");
            Name = "frmMainMenu";
            NavigationControl = accordionControl1;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PHẦN MỀM QUẢN LÝ BÁN LẺ SÁCH";
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer containerShow;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnShowStaff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnShowAccount;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnShowReceipt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnShowInvoice;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnShowBooks;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnShowPublisher;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnShowCategory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnShowAuthor;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnShowStatisticsRececipt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnShowStatisticsInvoice;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnShowStatisticsRevenue;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnChangePass;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnLogOut;
        private DevExpress.XtraBars.BarStaticItem title;
    }
}

