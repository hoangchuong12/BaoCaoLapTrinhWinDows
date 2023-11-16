using quanlydoannhanh.dao;
using quanlydoannhanh.TK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydoannhanh.frm
{
    public partial class frmHoaDon : Form
    {
        private HoaDonDAO hoadonDAO = new HoaDonDAO();
        private QLDOAN QLDOAN = new QLDOAN();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            dgvDanhSach.AutoGenerateColumns = false;
            dgvDanhSach.Columns["MaHoaDon"].DataPropertyName = "MaHoaDon";
            dgvDanhSach.Columns["NgayTao"].DataPropertyName = "NgayTao";
            dgvDanhSach.Columns["NgayKetThuc"].DataPropertyName = "NgayKetThuc";
            dgvDanhSach.Columns["MaBanAn"].DataPropertyName = "MaBanAn";
            dgvDanhSach.Columns["TongTien"].DataPropertyName = "TongTien";
            dgvDanhSach.DataSource = hoadonDAO.GetAllHoaDon();
            dgvDanhSach.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này và tất cả chi tiết liên quan?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int maHoaDon = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["MaHoaDon"].Value);

                    // Bước 1: Xóa các ChiTietHoaDon liên quan
                    var chiTietHoaDons = QLDOAN.ChiTietHoaDons.Where(ct => ct.MaHoaDon == maHoaDon).ToList();
                    QLDOAN.ChiTietHoaDons.RemoveRange(chiTietHoaDons);

                    // Bước 2: Xóa HoaDon
                    var hoaDon = QLDOAN.HoaDons.FirstOrDefault(h => h.MaHoaDon == maHoaDon);
                    if (hoaDon != null)
                    {
                        QLDOAN.HoaDons.Remove(hoaDon);
                    }

                    QLDOAN.SaveChanges();
                    RefreshDataGrid();
                }
            }

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
                txtMaHoaDon.Text = row.Cells["MaHoaDon"].Value.ToString();
                txtMaBanAn.Text = row.Cells["MaBanAn"].Value.ToString();
                txtTongTien1.Text = row.Cells["TongTien"].Value.ToString();
                txtNgayTao.Text = row.Cells["NgayTao"].Value.ToString();
                txtNgayKetThuc.Text = row.Cells["NgayKetThuc"].Value?.ToString() ?? string.Empty;
            }
        }
        private void RefreshDataGrid()
        {
            dgvDanhSach.DataSource = hoadonDAO.GetAllHoaDon();
            dgvDanhSach.Refresh();
        }



        private void btnXemChitiet_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null)
            {
                int maHoaDon = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["MaHoaDon"].Value);
                var formChiTiet = new frmChiTietHoaDon(maHoaDon); // Giả sử bạn đã tạo một constructor nhận vào mã hóa đơn cho frmChiTietHoaDon
                formChiTiet.ShowDialog();
            }
        }
    }
}
