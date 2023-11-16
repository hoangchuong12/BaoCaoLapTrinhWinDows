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
    public partial class frmLoaiThucAn : Form
    {
        private LoaiThucAnDAO loaiThucAnDAO = new LoaiThucAnDAO();
        private int rowindex = -1;
        private LoaiThucAn LoaiThucAn = new LoaiThucAn();
        private QLDOAN TA = new QLDOAN();
        public frmLoaiThucAn()
        {
            InitializeComponent();
        }

        private void LoaiThucAn_Load(object sender, EventArgs e)
        {
            dgvDanhSachLTA.AutoGenerateColumns = false;
            dgvDanhSachLTA.Columns["MaLoaiThucAn"].DataPropertyName = "MaLoaiThucAn";
            dgvDanhSachLTA.Columns["TenLoaiThucAn"].DataPropertyName = "TenLoaiThucAn";
            dgvDanhSachLTA.DataSource = loaiThucAnDAO.GetAllLoaiThucAn();
            dgvDanhSachLTA.Refresh();
        }

        private void dgvDanhSachLTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowindex = e.RowIndex;
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachLTA.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDanhSachLTA.Rows[e.RowIndex];
                    txtTenLoaiMonAn.Text = selectedRow.Cells["TenLoaiThucAn"].Value.ToString();
                    // Additional code if needed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string tenLoaiThucAn = txtTenLoaiMonAn.Text.Trim();
            LoaiThucAn loaiThucAn = new LoaiThucAn
            {
                TenLoaiThucAn = tenLoaiThucAn
            };
            loaiThucAnDAO.AddLoaiThucAn(loaiThucAn);
            RefreshDataGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachLTA.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvDanhSachLTA.SelectedRows[0].Cells["MaLoaiThucAn"].Value);
                    loaiThucAnDAO.DeleteLoaiThucAn(id);
                    RefreshDataGrid();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex >= 0 && rowindex < dgvDanhSachLTA.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDanhSachLTA.Rows[rowindex];
                    int id = Convert.ToInt32(selectedRow.Cells["MaLoaiThucAn"].Value);
                    string tenLoaiThucAnMoi = txtTenLoaiMonAn.Text.Trim();

                    LoaiThucAn existingLoaiThucAn =TA.LoaiThucAns.Find(id);

                    if (existingLoaiThucAn != null)
                    {
                        existingLoaiThucAn.TenLoaiThucAn = tenLoaiThucAnMoi;
                        TA.SaveChanges();
                        RefreshDataGrid();
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy loại thực phẩm để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void RefreshDataGrid()
        {
            dgvDanhSachLTA.DataSource = loaiThucAnDAO.GetAllLoaiThucAn();
            dgvDanhSachLTA.Refresh();
        }
    }
}
