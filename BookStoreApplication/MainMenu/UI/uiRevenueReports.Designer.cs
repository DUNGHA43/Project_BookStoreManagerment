namespace GUI
{
    partial class uiRevenueReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiRevenueReports));
            panel1 = new System.Windows.Forms.Panel();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            btnSatistical = new DevExpress.XtraEditors.SimpleButton();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            cbxD = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cbxY = new System.Windows.Forms.ComboBox();
            cbxM = new System.Windows.Forms.ComboBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rdoY = new System.Windows.Forms.RadioButton();
            rdoQ = new System.Windows.Forms.RadioButton();
            rdoM = new System.Windows.Forms.RadioButton();
            chartReceipt = new DevExpress.XtraCharts.ChartControl();
            chartControl1 = new DevExpress.XtraCharts.ChartControl();
            panel2 = new System.Windows.Forms.Panel();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gcTable = new DevExpress.XtraGrid.GridControl();
            gvTable = new DevExpress.XtraGrid.Views.Grid.GridView();
            panel3 = new System.Windows.Forms.Panel();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartReceipt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartControl1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvTable).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnSatistical);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 464);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(834, 119);
            panel1.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.Location = new System.Drawing.Point(706, 28);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(71, 78);
            btnClose.TabIndex = 4;
            // 
            // btnSatistical
            // 
            btnSatistical.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSatistical.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSatistical.ImageOptions.Image");
            btnSatistical.Location = new System.Drawing.Point(519, 28);
            btnSatistical.Name = "btnSatistical";
            btnSatistical.Size = new System.Drawing.Size(71, 78);
            btnSatistical.TabIndex = 3;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnPrint.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnPrint.ImageOptions.Image");
            btnPrint.Location = new System.Drawing.Point(614, 28);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(71, 78);
            btnPrint.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBox2.Controls.Add(cbxD);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cbxY);
            groupBox2.Controls.Add(cbxM);
            groupBox2.Location = new System.Drawing.Point(205, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(226, 105);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thời gian";
            // 
            // cbxD
            // 
            cbxD.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbxD.FormattingEnabled = true;
            cbxD.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbxD.Location = new System.Drawing.Point(60, 20);
            cbxD.Name = "cbxD";
            cbxD.Size = new System.Drawing.Size(154, 23);
            cbxD.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 77);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Năm:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Tháng:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Ngày:";
            // 
            // cbxY
            // 
            cbxY.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbxY.FormattingEnabled = true;
            cbxY.Items.AddRange(new object[] { "2023", "2024", "2025", "2026" });
            cbxY.Location = new System.Drawing.Point(60, 74);
            cbxY.Name = "cbxY";
            cbxY.Size = new System.Drawing.Size(154, 23);
            cbxY.TabIndex = 2;
            // 
            // cbxM
            // 
            cbxM.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbxM.FormattingEnabled = true;
            cbxM.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbxM.Location = new System.Drawing.Point(60, 47);
            cbxM.Name = "cbxM";
            cbxM.Size = new System.Drawing.Size(154, 23);
            cbxM.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBox1.Controls.Add(rdoY);
            groupBox1.Controls.Add(rdoQ);
            groupBox1.Controls.Add(rdoM);
            groupBox1.Location = new System.Drawing.Point(55, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(97, 92);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống kê theo";
            // 
            // rdoY
            // 
            rdoY.Anchor = System.Windows.Forms.AnchorStyles.None;
            rdoY.AutoSize = true;
            rdoY.Location = new System.Drawing.Point(20, 63);
            rdoY.Name = "rdoY";
            rdoY.Size = new System.Drawing.Size(51, 19);
            rdoY.TabIndex = 2;
            rdoY.TabStop = true;
            rdoY.Text = "Năm";
            rdoY.UseVisualStyleBackColor = true;
            // 
            // rdoQ
            // 
            rdoQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            rdoQ.AutoSize = true;
            rdoQ.Location = new System.Drawing.Point(20, 40);
            rdoQ.Name = "rdoQ";
            rdoQ.Size = new System.Drawing.Size(47, 19);
            rdoQ.TabIndex = 1;
            rdoQ.TabStop = true;
            rdoQ.Text = "Quý";
            rdoQ.UseVisualStyleBackColor = true;
            // 
            // rdoM
            // 
            rdoM.Anchor = System.Windows.Forms.AnchorStyles.None;
            rdoM.AutoSize = true;
            rdoM.Location = new System.Drawing.Point(20, 17);
            rdoM.Name = "rdoM";
            rdoM.Size = new System.Drawing.Size(58, 19);
            rdoM.TabIndex = 0;
            rdoM.TabStop = true;
            rdoM.Text = "Tháng";
            rdoM.UseVisualStyleBackColor = true;
            // 
            // chartReceipt
            // 
            chartReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            chartReceipt.Location = new System.Drawing.Point(0, 0);
            chartReceipt.Name = "chartReceipt";
            chartReceipt.Size = new System.Drawing.Size(420, 439);
            chartReceipt.TabIndex = 1;
            // 
            // chartControl1
            // 
            chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            chartControl1.Location = new System.Drawing.Point(0, 0);
            chartControl1.Name = "chartControl1";
            chartControl1.Size = new System.Drawing.Size(420, 439);
            chartControl1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(chartReceipt);
            panel2.Controls.Add(chartControl1);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(2, 23);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(420, 439);
            panel2.TabIndex = 0;
            // 
            // gridView1
            // 
            gridView1.GridControl = gcTable;
            gridView1.Name = "gridView1";
            // 
            // gcTable
            // 
            gcTable.Dock = System.Windows.Forms.DockStyle.Fill;
            gcTable.Location = new System.Drawing.Point(0, 0);
            gcTable.MainView = gvTable;
            gcTable.Name = "gcTable";
            gcTable.Size = new System.Drawing.Size(410, 439);
            gcTable.TabIndex = 0;
            gcTable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvTable, gridView1 });
            // 
            // gvTable
            // 
            gvTable.GridControl = gcTable;
            gvTable.Name = "gvTable";
            gvTable.OptionsView.ShowGroupPanel = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(gcTable);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(422, 23);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(410, 439);
            panel3.TabIndex = 1;
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.Controls.Add(panel3);
            groupControl1.Controls.Add(panel2);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(834, 464);
            groupControl1.TabIndex = 4;
            groupControl1.Text = "Thông tin thống kê doanh thu";
            // 
            // uiRevenueReports
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(groupControl1);
            Name = "uiRevenueReports";
            Size = new System.Drawing.Size(834, 583);
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartReceipt).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvTable).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSatistical;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxY;
        private System.Windows.Forms.ComboBox cbxM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoY;
        private System.Windows.Forms.RadioButton rdoQ;
        private System.Windows.Forms.RadioButton rdoM;
        private DevExpress.XtraCharts.ChartControl chartReceipt;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcTable;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTable;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
