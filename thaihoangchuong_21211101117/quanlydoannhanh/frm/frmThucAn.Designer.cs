namespace quanlydoannhanh.frm
{
    partial class frmThucAn
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
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.MaThucAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiThucAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThucAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.txtGiaThucAn = new System.Windows.Forms.TextBox();
            this.cbMaLTA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenThucAn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThucAn,
            this.MaLoaiThucAn,
            this.TenThucAn,
            this.GiaThucAn});
            this.dgvDanhSach.Location = new System.Drawing.Point(41, 238);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(726, 188);
            this.dgvDanhSach.TabIndex = 1;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // MaThucAn
            // 
            this.MaThucAn.HeaderText = "Mã thức ăn ";
            this.MaThucAn.MinimumWidth = 6;
            this.MaThucAn.Name = "MaThucAn";
            // 
            // MaLoaiThucAn
            // 
            this.MaLoaiThucAn.HeaderText = "Mã loại thức ăn";
            this.MaLoaiThucAn.MinimumWidth = 6;
            this.MaLoaiThucAn.Name = "MaLoaiThucAn";
            // 
            // TenThucAn
            // 
            this.TenThucAn.HeaderText = "Tên thức ăn";
            this.TenThucAn.MinimumWidth = 6;
            this.TenThucAn.Name = "TenThucAn";
            // 
            // GiaThucAn
            // 
            this.GiaThucAn.HeaderText = "Giá thức ăn";
            this.GiaThucAn.MinimumWidth = 6;
            this.GiaThucAn.Name = "GiaThucAn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(41, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbMaLTA);
            this.groupBox2.Controls.Add(this.txtTenThucAn);
            this.groupBox2.Controls.Add(this.txtGiaThucAn);
            this.groupBox2.Location = new System.Drawing.Point(41, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 91);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(29, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(151, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 32);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(284, 34);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(90, 32);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // txtGiaThucAn
            // 
            this.txtGiaThucAn.Location = new System.Drawing.Point(586, 35);
            this.txtGiaThucAn.Multiline = true;
            this.txtGiaThucAn.Name = "txtGiaThucAn";
            this.txtGiaThucAn.Size = new System.Drawing.Size(133, 29);
            this.txtGiaThucAn.TabIndex = 0;
            // 
            // cbMaLTA
            // 
            this.cbMaLTA.FormattingEnabled = true;
            this.cbMaLTA.Location = new System.Drawing.Point(75, 40);
            this.cbMaLTA.Name = "cbMaLTA";
            this.cbMaLTA.Size = new System.Drawing.Size(136, 24);
            this.cbMaLTA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã LTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Thức ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá Thức ăn";
            // 
            // txtTenThucAn
            // 
            this.txtTenThucAn.Location = new System.Drawing.Point(333, 35);
            this.txtTenThucAn.Multiline = true;
            this.txtTenThucAn.Name = "txtTenThucAn";
            this.txtTenThucAn.Size = new System.Drawing.Size(133, 29);
            this.txtTenThucAn.TabIndex = 0;
            // 
            // frmThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDanhSach);
            this.Name = "frmThucAn";
            this.Text = "ThucAn";
            this.Load += new System.EventHandler(this.ThucAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThucAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiThucAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThucAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaLTA;
        private System.Windows.Forms.TextBox txtGiaThucAn;
        private System.Windows.Forms.TextBox txtTenThucAn;
    }
}