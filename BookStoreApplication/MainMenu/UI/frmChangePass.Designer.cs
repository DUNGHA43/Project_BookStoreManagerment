namespace GUI.UI
{
    partial class frmChangePass
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
            ckShowPass = new System.Windows.Forms.CheckBox();
            btnLogin = new System.Windows.Forms.Button();
            txtAcceptNewPass = new DevExpress.XtraEditors.TextEdit();
            txtCurrentPass = new DevExpress.XtraEditors.TextEdit();
            button1 = new System.Windows.Forms.Button();
            txtNewPass = new DevExpress.XtraEditors.TextEdit();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)txtAcceptNewPass.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCurrentPass.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNewPass.Properties).BeginInit();
            SuspendLayout();
            // 
            // ckShowPass
            // 
            ckShowPass.AutoSize = true;
            ckShowPass.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            ckShowPass.Location = new System.Drawing.Point(82, 193);
            ckShowPass.Name = "ckShowPass";
            ckShowPass.Size = new System.Drawing.Size(109, 17);
            ckShowPass.TabIndex = 8;
            ckShowPass.Text = "Hiển thị mật khẩu";
            ckShowPass.UseVisualStyleBackColor = true;
            ckShowPass.CheckedChanged += ckShowPass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.Azure;
            btnLogin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogin.ForeColor = System.Drawing.Color.DimGray;
            btnLogin.Location = new System.Drawing.Point(82, 218);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(128, 47);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "ĐỔI MẬT KHẨU";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtAcceptNewPass
            // 
            txtAcceptNewPass.EditValue = "";
            txtAcceptNewPass.Location = new System.Drawing.Point(82, 156);
            txtAcceptNewPass.Name = "txtAcceptNewPass";
            txtAcceptNewPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAcceptNewPass.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            txtAcceptNewPass.Properties.Appearance.Options.UseFont = true;
            txtAcceptNewPass.Properties.Appearance.Options.UseForeColor = true;
            txtAcceptNewPass.Properties.UseSystemPasswordChar = true;
            txtAcceptNewPass.Size = new System.Drawing.Size(258, 30);
            txtAcceptNewPass.TabIndex = 6;
            // 
            // txtCurrentPass
            // 
            txtCurrentPass.Location = new System.Drawing.Point(82, 33);
            txtCurrentPass.Name = "txtCurrentPass";
            txtCurrentPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCurrentPass.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            txtCurrentPass.Properties.Appearance.Options.UseFont = true;
            txtCurrentPass.Properties.Appearance.Options.UseForeColor = true;
            txtCurrentPass.Properties.UseSystemPasswordChar = true;
            txtCurrentPass.Size = new System.Drawing.Size(258, 30);
            txtCurrentPass.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Azure;
            button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.DimGray;
            button1.Location = new System.Drawing.Point(225, 218);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(128, 47);
            button1.TabIndex = 9;
            button1.Text = "ĐÓNG";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new System.Drawing.Point(82, 94);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNewPass.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            txtNewPass.Properties.Appearance.Options.UseFont = true;
            txtNewPass.Properties.Appearance.Options.UseForeColor = true;
            txtNewPass.Properties.UseSystemPasswordChar = true;
            txtNewPass.Size = new System.Drawing.Size(258, 30);
            txtNewPass.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label1.Location = new System.Drawing.Point(82, 138);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 17);
            label1.TabIndex = 11;
            label1.Text = "Xác nhận mật khẩu mới:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label2.Location = new System.Drawing.Point(82, 74);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 17);
            label2.TabIndex = 12;
            label2.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label3.Location = new System.Drawing.Point(82, 13);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 17);
            label3.TabIndex = 13;
            label3.Text = "Mật khẩu cũ:";
            // 
            // frmChangePass
            // 
            Appearance.BackColor = System.Drawing.Color.SteelBlue;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(435, 287);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewPass);
            Controls.Add(button1);
            Controls.Add(ckShowPass);
            Controls.Add(btnLogin);
            Controls.Add(txtAcceptNewPass);
            Controls.Add(txtCurrentPass);
            Name = "frmChangePass";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)txtAcceptNewPass.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCurrentPass.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNewPass.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox ckShowPass;
        private System.Windows.Forms.Button btnLogin;
        private DevExpress.XtraEditors.TextEdit txtAcceptNewPass;
        private DevExpress.XtraEditors.TextEdit txtCurrentPass;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}