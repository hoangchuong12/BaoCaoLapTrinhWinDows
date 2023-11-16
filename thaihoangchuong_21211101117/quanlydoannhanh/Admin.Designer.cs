namespace quanlydoannhanh
{
    partial class Admin
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
            this.btnBanAn = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnLoaiThucAn = new System.Windows.Forms.Button();
            this.btnThucAn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBanAn
            // 
            this.btnBanAn.Location = new System.Drawing.Point(28, 105);
            this.btnBanAn.Name = "btnBanAn";
            this.btnBanAn.Size = new System.Drawing.Size(101, 38);
            this.btnBanAn.TabIndex = 0;
            this.btnBanAn.Text = "Bàn ăn";
            this.btnBanAn.UseVisualStyleBackColor = true;
            this.btnBanAn.Click += new System.EventHandler(this.btnBanAn_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(28, 163);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(101, 33);
            this.btnHoaDon.TabIndex = 2;
            this.btnHoaDon.Text = "Hóa đon";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnLoaiThucAn
            // 
            this.btnLoaiThucAn.Location = new System.Drawing.Point(28, 220);
            this.btnLoaiThucAn.Name = "btnLoaiThucAn";
            this.btnLoaiThucAn.Size = new System.Drawing.Size(101, 38);
            this.btnLoaiThucAn.TabIndex = 2;
            this.btnLoaiThucAn.Text = "Loại thức ăn";
            this.btnLoaiThucAn.UseVisualStyleBackColor = true;
            this.btnLoaiThucAn.Click += new System.EventHandler(this.btnLoaiThucAn_Click);
            // 
            // btnThucAn
            // 
            this.btnThucAn.Location = new System.Drawing.Point(28, 279);
            this.btnThucAn.Name = "btnThucAn";
            this.btnThucAn.Size = new System.Drawing.Size(101, 38);
            this.btnThucAn.TabIndex = 2;
            this.btnThucAn.Text = "Thức ăn";
            this.btnThucAn.UseVisualStyleBackColor = true;
            this.btnThucAn.Click += new System.EventHandler(this.btnThucAn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlMain);
            this.panel1.Location = new System.Drawing.Point(146, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 487);
            this.panel1.TabIndex = 3;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(807, 487);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged_1);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(28, 342);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(101, 41);
            this.btnDatHang.TabIndex = 4;
            this.btnDatHang.Text = "đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 573);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThucAn);
            this.Controls.Add(this.btnLoaiThucAn);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnBanAn);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBanAn;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnLoaiThucAn;
        private System.Windows.Forms.Button btnThucAn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Button btnDatHang;
    }
}