namespace quanlydoannhanh
{
    partial class QuenTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lbKHoanMoi = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnTaoMa = new System.Windows.Forms.Button();
            this.tbnXacNhanma = new System.Windows.Forms.Button();
            this.btnXacNhanMK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(42, 44);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 34);
            this.txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mã";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(42, 120);
            this.txtMa.Multiline = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(195, 34);
            this.txtMa.TabIndex = 1;
            // 
            // lbKHoanMoi
            // 
            this.lbKHoanMoi.AutoSize = true;
            this.lbKHoanMoi.Location = new System.Drawing.Point(39, 162);
            this.lbKHoanMoi.Name = "lbKHoanMoi";
            this.lbKHoanMoi.Size = new System.Drawing.Size(123, 16);
            this.lbKHoanMoi.TabIndex = 0;
            this.lbKHoanMoi.Text = "Nhập Mật Khẩu Mới";
            this.lbKHoanMoi.Visible = false;
            this.lbKHoanMoi.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(42, 192);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(195, 34);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.Visible = false;
            // 
            // btnTaoMa
            // 
            this.btnTaoMa.Location = new System.Drawing.Point(477, 114);
            this.btnTaoMa.Name = "btnTaoMa";
            this.btnTaoMa.Size = new System.Drawing.Size(198, 42);
            this.btnTaoMa.TabIndex = 2;
            this.btnTaoMa.Text = "lấy mã";
            this.btnTaoMa.UseVisualStyleBackColor = true;
            this.btnTaoMa.Click += new System.EventHandler(this.btnTaoMa_ClickAsync);
            // 
            // tbnXacNhanma
            // 
            this.tbnXacNhanma.Location = new System.Drawing.Point(477, 188);
            this.tbnXacNhanma.Name = "tbnXacNhanma";
            this.tbnXacNhanma.Size = new System.Drawing.Size(198, 42);
            this.tbnXacNhanma.TabIndex = 2;
            this.tbnXacNhanma.Text = "xác nhận mã";
            this.tbnXacNhanma.UseVisualStyleBackColor = true;
            this.tbnXacNhanma.Click += new System.EventHandler(this.tbnXacNhanma_Click);
            // 
            // btnXacNhanMK
            // 
            this.btnXacNhanMK.Location = new System.Drawing.Point(477, 260);
            this.btnXacNhanMK.Name = "btnXacNhanMK";
            this.btnXacNhanMK.Size = new System.Drawing.Size(198, 42);
            this.btnXacNhanMK.TabIndex = 2;
            this.btnXacNhanMK.Text = "Xác Nhận mật Khẩu";
            this.btnXacNhanMK.UseVisualStyleBackColor = true;
            this.btnXacNhanMK.Visible = false;
            this.btnXacNhanMK.Click += new System.EventHandler(this.btnXacNhanMK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quên tài khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.lbKHoanMoi);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(74, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 288);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // QuenTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXacNhanMK);
            this.Controls.Add(this.tbnXacNhanma);
            this.Controls.Add(this.btnTaoMa);
            this.Name = "QuenTaiKhoan";
            this.Text = "QuenTaiKhoan";
            this.Load += new System.EventHandler(this.QuenTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lbKHoanMoi;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnTaoMa;
        private System.Windows.Forms.Button tbnXacNhanma;
        private System.Windows.Forms.Button btnXacNhanMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}