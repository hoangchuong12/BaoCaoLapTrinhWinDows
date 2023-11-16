namespace quanlydoannhanh.frm
{
    partial class frmLoaiThucAn
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
            this.dgvDanhSachLTA = new System.Windows.Forms.DataGridView();
            this.MaLoaiThucAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThucAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLoaiMonAn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLTA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachLTA
            // 
            this.dgvDanhSachLTA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachLTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiThucAn,
            this.TenLoaiThucAn});
            this.dgvDanhSachLTA.Location = new System.Drawing.Point(443, 40);
            this.dgvDanhSachLTA.Name = "dgvDanhSachLTA";
            this.dgvDanhSachLTA.RowHeadersWidth = 51;
            this.dgvDanhSachLTA.RowTemplate.Height = 24;
            this.dgvDanhSachLTA.Size = new System.Drawing.Size(294, 371);
            this.dgvDanhSachLTA.TabIndex = 0;
            this.dgvDanhSachLTA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLTA_CellContentClick);
            // 
            // MaLoaiThucAn
            // 
            this.MaLoaiThucAn.HeaderText = "Mã Loại thứ ăn";
            this.MaLoaiThucAn.MinimumWidth = 6;
            this.MaLoaiThucAn.Name = "MaLoaiThucAn";
            // 
            // TenLoaiThucAn
            // 
            this.TenLoaiThucAn.HeaderText = "Tên loại thức ăn";
            this.TenLoaiThucAn.MinimumWidth = 6;
            this.TenLoaiThucAn.Name = "TenLoaiThucAn";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(29, 80);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 40);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(29, 167);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Location = new System.Drawing.Point(32, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 393);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "công cụ";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(29, 265);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên loại thức ăn";
            // 
            // txtTenLoaiMonAn
            // 
            this.txtTenLoaiMonAn.Location = new System.Drawing.Point(206, 70);
            this.txtTenLoaiMonAn.Multiline = true;
            this.txtTenLoaiMonAn.Name = "txtTenLoaiMonAn";
            this.txtTenLoaiMonAn.Size = new System.Drawing.Size(193, 39);
            this.txtTenLoaiMonAn.TabIndex = 4;
            // 
            // frmLoaiThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTenLoaiMonAn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDanhSachLTA);
            this.Name = "frmLoaiThucAn";
            this.Text = "LoaiThucAn";
            this.Load += new System.EventHandler(this.LoaiThucAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLTA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachLTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiThucAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThucAn;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLoaiMonAn;
    }
}