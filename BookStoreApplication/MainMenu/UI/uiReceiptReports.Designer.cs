namespace GUI.UI
{
    partial class uiReceiptReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiReceiptReports));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            panel1 = new System.Windows.Forms.Panel();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            btnSatistical = new DevExpress.XtraEditors.SimpleButton();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            lbM = new System.Windows.Forms.Label();
            cbxY = new System.Windows.Forms.ComboBox();
            cbxM = new System.Windows.Forms.ComboBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rdoY = new System.Windows.Forms.RadioButton();
            rdoQ = new System.Windows.Forms.RadioButton();
            rdoM = new System.Windows.Forms.RadioButton();
            chartReceipt = new DevExpress.XtraCharts.ChartControl();
            chartControl1 = new DevExpress.XtraCharts.ChartControl();
            panel2 = new System.Windows.Forms.Panel();
            chartControl2 = new DevExpress.XtraCharts.ChartControl();
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
            ((System.ComponentModel.ISupportInitialize)chartControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stackedBarSeriesView1).BeginInit();
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
            panel1.Location = new System.Drawing.Point(0, 463);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(834, 120);
            panel1.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.Location = new System.Drawing.Point(709, 27);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(71, 78);
            btnClose.TabIndex = 4;
            btnClose.Click += btnClose_Click;
            // 
            // btnSatistical
            // 
            btnSatistical.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSatistical.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSatistical.ImageOptions.Image");
            btnSatistical.Location = new System.Drawing.Point(522, 27);
            btnSatistical.Name = "btnSatistical";
            btnSatistical.Size = new System.Drawing.Size(71, 78);
            btnSatistical.TabIndex = 3;
            btnSatistical.Click += btnSatistical_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnPrint.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnPrint.ImageOptions.Image");
            btnPrint.Location = new System.Drawing.Point(617, 27);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(71, 78);
            btnPrint.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lbM);
            groupBox2.Controls.Add(cbxY);
            groupBox2.Controls.Add(cbxM);
            groupBox2.Location = new System.Drawing.Point(208, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(226, 105);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thời gian";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 65);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Năm:";
            // 
            // lbM
            // 
            lbM.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbM.AutoSize = true;
            lbM.Location = new System.Drawing.Point(13, 38);
            lbM.Name = "lbM";
            lbM.Size = new System.Drawing.Size(43, 15);
            lbM.TabIndex = 4;
            lbM.Text = "Tháng:";
            // 
            // cbxY
            // 
            cbxY.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbxY.FormattingEnabled = true;
            cbxY.Items.AddRange(new object[] { "2023", "2024", "2025", "2026" });
            cbxY.Location = new System.Drawing.Point(60, 62);
            cbxY.Name = "cbxY";
            cbxY.Size = new System.Drawing.Size(154, 23);
            cbxY.TabIndex = 2;
            // 
            // cbxM
            // 
            cbxM.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbxM.FormattingEnabled = true;
            cbxM.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbxM.Location = new System.Drawing.Point(60, 35);
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
            groupBox1.Location = new System.Drawing.Point(58, 18);
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
            rdoY.Location = new System.Drawing.Point(17, 66);
            rdoY.Name = "rdoY";
            rdoY.Size = new System.Drawing.Size(51, 19);
            rdoY.TabIndex = 2;
            rdoY.TabStop = true;
            rdoY.Text = "Năm";
            rdoY.UseVisualStyleBackColor = true;
            rdoY.CheckedChanged += rdoY_CheckedChanged;
            // 
            // rdoQ
            // 
            rdoQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            rdoQ.AutoSize = true;
            rdoQ.Location = new System.Drawing.Point(17, 43);
            rdoQ.Name = "rdoQ";
            rdoQ.Size = new System.Drawing.Size(47, 19);
            rdoQ.TabIndex = 1;
            rdoQ.TabStop = true;
            rdoQ.Text = "Quý";
            rdoQ.UseVisualStyleBackColor = true;
            rdoQ.CheckedChanged += rdoQ_CheckedChanged;
            // 
            // rdoM
            // 
            rdoM.Anchor = System.Windows.Forms.AnchorStyles.None;
            rdoM.AutoSize = true;
            rdoM.Location = new System.Drawing.Point(17, 20);
            rdoM.Name = "rdoM";
            rdoM.Size = new System.Drawing.Size(58, 19);
            rdoM.TabIndex = 0;
            rdoM.TabStop = true;
            rdoM.Text = "Tháng";
            rdoM.UseVisualStyleBackColor = true;
            rdoM.Click += rdoM_Click;
            // 
            // chartReceipt
            // 
            chartReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            chartReceipt.Location = new System.Drawing.Point(0, 0);
            chartReceipt.Name = "chartReceipt";
            chartReceipt.Size = new System.Drawing.Size(420, 438);
            chartReceipt.TabIndex = 1;
            // 
            // chartControl1
            // 
            chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            chartControl1.Location = new System.Drawing.Point(0, 0);
            chartControl1.Name = "chartControl1";
            chartControl1.Size = new System.Drawing.Size(420, 438);
            chartControl1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(chartControl2);
            panel2.Controls.Add(chartReceipt);
            panel2.Controls.Add(chartControl1);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(2, 23);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(420, 438);
            panel2.TabIndex = 0;
            // 
            // chartControl2
            // 
            xyDiagram1.AxisX.MinorCount = 2;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "12";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "1";
            xyDiagram1.AxisX.WholeRange.Auto = false;
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "12";
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "0";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            chartControl2.Diagram = xyDiagram1;
            chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            chartControl2.Location = new System.Drawing.Point(0, 0);
            chartControl2.Name = "chartControl2";
            series1.Name = "Nhập";
            series1.View = stackedBarSeriesView1;
            chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[]
    {
    series1
    };
            chartControl2.Size = new System.Drawing.Size(420, 438);
            chartControl2.TabIndex = 2;
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
            gcTable.Size = new System.Drawing.Size(410, 438);
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
            panel3.Size = new System.Drawing.Size(410, 438);
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
            groupControl1.Size = new System.Drawing.Size(834, 463);
            groupControl1.TabIndex = 4;
            groupControl1.Text = "Thông tin thống kê nhập";
            // 
            // uiReceiptReports
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(groupControl1);
            Name = "uiReceiptReports";
            Size = new System.Drawing.Size(834, 583);
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartReceipt).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).EndInit();
            ((System.ComponentModel.ISupportInitialize)stackedBarSeriesView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)series1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControl2).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbM;
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
        private DevExpress.XtraCharts.ChartControl chartControl2;
    }
}
