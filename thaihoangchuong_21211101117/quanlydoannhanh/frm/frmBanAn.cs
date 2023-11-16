using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using quanlydoannhanh.dao;
using quanlydoannhanh.TK;
namespace quanlydoannhanh.frm
{
    public partial class frmBanAn : Form

    { 
        int rowindex = -1;

        private BanAnDAO banAnDAO = new BanAnDAO();

        private BanAn BanAn = new BanAn();

        private QLDOAN QLDOAN = new QLDOAN();
        public frmBanAn()
        {
            InitializeComponent();
        }

        private void BanAn_Load(object sender, EventArgs e)
        {
            dgvDanhSach.AutoGenerateColumns = false;
            dgvDanhSach.Columns["MaBanAn"].DataPropertyName = "MaBanAn";
            dgvDanhSach.Columns["TenBan"].DataPropertyName = "TenBanAn";
            dgvDanhSach.DataSource = banAnDAO.GetAllBanAn();
            dgvDanhSach.Refresh();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowindex = e.RowIndex;
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDanhSach.Rows[e.RowIndex];
                    txtBanAn.Text = selectedRow.Cells["TenBAn"].Value.ToString();
          
                    btnXoaBan.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            string Tenbanan = txtBanAn.Text.Trim();
            BanAn BA = new BanAn();  // Use the correct namespace
            BA.TenBanAn = Tenbanan;
            banAnDAO.AddBanAn(BA);
            dgvDanhSach.DataSource = banAnDAO.GetAllBanAn();
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvDanhSach.SelectedRows[0].Cells[0].Value);
                    var banAn = QLDOAN.BanAns.Find(id);
                    if (banAn != null)
                    {
                        QLDOAN.BanAns.Remove(banAn);
                        QLDOAN.SaveChanges();
                        RefreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Bản ghi không tồn tại trong cơ sở dữ liệu.");
                    }
                }
            }
        }
        private void RefreshDataGrid()
        {
            dgvDanhSach.DataSource = banAnDAO.GetAllBanAn();
            dgvDanhSach.Refresh();
        }
        private void btnSuaBan_Click(object sender, EventArgs e)
        {

            try
            {
                if (rowindex >= 0 && rowindex < dgvDanhSach.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDanhSach.Rows[rowindex];
                    int id = Convert.ToInt32(selectedRow.Cells["MaBanAn"].Value);
                    string tenBanAnMoi = txtBanAn.Text.Trim();

                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var banAn = QLDOAN.BanAns.Find(id);
                        if (banAn != null)
                        {
                            banAn.TenBanAn = tenBanAnMoi;
                            QLDOAN.SaveChanges();
                            RefreshDataGrid();
                            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Bản ghi không tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnLuuBan_Click(object sender, EventArgs e)
        {

        }
    }
}
