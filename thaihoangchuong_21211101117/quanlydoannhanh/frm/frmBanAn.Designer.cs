namespace quanlydoannhanh.frm
{
    partial class frmBanAn
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
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.MabanAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBanAn = new System.Windows.Forms.TextBox();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.btnXoaBan = new System.Windows.Forms.Button();
            this.btnSuaBan = new System.Windows.Forms.Button();
            this.btnLuuBan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bàn ăn";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MabanAn,
            this.TenBan});
            this.dgvDanhSach.Location = new System.Drawing.Point(28, 162);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(748, 248);
            this.dgvDanhSach.TabIndex = 1;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // MabanAn
            // 
            this.MabanAn.HeaderText = "Mã Bàn ăn";
            this.MabanAn.MinimumWidth = 6;
            this.MabanAn.Name = "MabanAn";
            // 
            // TenBan
            // 
            this.TenBan.HeaderText = "Tên Bàn";
            this.TenBan.MinimumWidth = 6;
            this.TenBan.Name = "TenBan";
            // 
            // txtBanAn
            // 
            this.txtBanAn.Location = new System.Drawing.Point(542, 32);
            this.txtBanAn.Multiline = true;
            this.txtBanAn.Name = "txtBanAn";
            this.txtBanAn.Size = new System.Drawing.Size(195, 32);
            this.txtBanAn.TabIndex = 2;
            // 
            // btnThemBan
            // 
            this.btnThemBan.Location = new System.Drawing.Point(50, 25);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(100, 37);
            this.btnThemBan.TabIndex = 3;
            this.btnThemBan.Text = "Thêm Bàn";
            this.btnThemBan.UseVisualStyleBackColor = true;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.Location = new System.Drawing.Point(188, 25);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(101, 37);
            this.btnXoaBan.TabIndex = 4;
            this.btnXoaBan.Text = "Xóa Bàn";
            this.btnXoaBan.UseVisualStyleBackColor = true;
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // btnSuaBan
            // 
            this.btnSuaBan.Location = new System.Drawing.Point(49, 83);
            this.btnSuaBan.Name = "btnSuaBan";
            this.btnSuaBan.Size = new System.Drawing.Size(101, 37);
            this.btnSuaBan.TabIndex = 4;
            this.btnSuaBan.Text = "Sửa Bàn";
            this.btnSuaBan.UseVisualStyleBackColor = true;
            this.btnSuaBan.Click += new System.EventHandler(this.btnSuaBan_Click);
            // 
            // btnLuuBan
            // 
            this.btnLuuBan.Location = new System.Drawing.Point(188, 83);
            this.btnLuuBan.Name = "btnLuuBan";
            this.btnLuuBan.Size = new System.Drawing.Size(101, 37);
            this.btnLuuBan.TabIndex = 4;
            this.btnLuuBan.Text = "Lưu Bản";
            this.btnLuuBan.UseVisualStyleBackColor = true;
            this.btnLuuBan.Click += new System.EventHandler(this.btnLuuBan_Click);
            // 
            // frmBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuaBan);
            this.Controls.Add(this.btnLuuBan);
            this.Controls.Add(this.btnXoaBan);
            this.Controls.Add(this.btnThemBan);
            this.Controls.Add(this.txtBanAn);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.label1);
            this.Name = "frmBanAn";
            this.Text = "BanAn";
            this.Load += new System.EventHandler(this.BanAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MabanAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.TextBox txtBanAn;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.Button btnXoaBan;
        private System.Windows.Forms.Button btnSuaBan;
        private System.Windows.Forms.Button btnLuuBan;
    }
}