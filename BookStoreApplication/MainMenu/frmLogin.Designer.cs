namespace GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            ckShowPass = new System.Windows.Forms.CheckBox();
            btnExit = new System.Windows.Forms.Button();
            btnLogin = new System.Windows.Forms.Button();
            txtPassWord = new DevExpress.XtraEditors.TextEdit();
            txtUserName = new DevExpress.XtraEditors.TextEdit();
            panel2 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPassWord.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightBlue;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ckShowPass);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassWord);
            panel1.Controls.Add(txtUserName);
            panel1.Location = new System.Drawing.Point(75, 117);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(298, 270);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.SteelBlue;
            label1.Location = new System.Drawing.Point(23, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(249, 24);
            label1.TabIndex = 5;
            label1.Text = "ĐĂNG NHẬP PHẦN MỀM";
            // 
            // ckShowPass
            // 
            ckShowPass.AutoSize = true;
            ckShowPass.Location = new System.Drawing.Point(20, 149);
            ckShowPass.Name = "ckShowPass";
            ckShowPass.Size = new System.Drawing.Size(109, 17);
            ckShowPass.TabIndex = 4;
            ckShowPass.Text = "Hiển thị mật khẩu";
            ckShowPass.UseVisualStyleBackColor = true;
            ckShowPass.CheckedChanged += ckShowPass_CheckedChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.SteelBlue;
            btnExit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.Location = new System.Drawing.Point(149, 197);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(119, 47);
            btnExit.TabIndex = 3;
            btnExit.Text = "THOÁT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            btnLogin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(24, 197);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(119, 47);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new System.Drawing.Point(20, 109);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassWord.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            txtPassWord.Properties.Appearance.Options.UseFont = true;
            txtPassWord.Properties.Appearance.Options.UseForeColor = true;
            txtPassWord.Properties.NullText = "Nhập tên mật khẩu...";
            txtPassWord.Properties.UseSystemPasswordChar = true;
            txtPassWord.Size = new System.Drawing.Size(258, 30);
            txtPassWord.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(20, 63);
            txtUserName.Name = "txtUserName";
            txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUserName.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            txtUserName.Properties.Appearance.Options.UseFont = true;
            txtUserName.Properties.Appearance.Options.UseForeColor = true;
            txtUserName.Properties.NullText = "Nhập tên tài khoản...";
            txtUserName.Size = new System.Drawing.Size(258, 30);
            txtUserName.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Transparent;
            panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new System.Drawing.Point(511, 136);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(256, 256);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("JetBrains Mono NL", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.LightCyan;
            label2.Location = new System.Drawing.Point(533, 100);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(207, 36);
            label2.TabIndex = 3;
            label2.Text = "DUNGHA BOOKS";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            BackgroundImageStore = (System.Drawing.Image)resources.GetObject("$this.BackgroundImageStore");
            ClientSize = new System.Drawing.Size(868, 525);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            IconOptions.Image = (System.Drawing.Image)resources.GetObject("frmLogin.IconOptions.Image");
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PHẦN MỀM QUẢN LÝ CỬA HÀNG BÁN LẺ SÁCH BY DUNGHA";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPassWord.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassWord;
        private System.Windows.Forms.CheckBox ckShowPass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}