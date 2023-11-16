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
     
    public partial class frmThucAn : Form
    {
        private LoaiThucAnDAO LoaiThucAnDAO = new LoaiThucAnDAO();
        private ThucAnDAO thucAnDAO = new ThucAnDAO();
     
        public frmThucAn()
        {
            InitializeComponent();
        }

        private void ThucAn_Load(object sender, EventArgs e)
        {
            List<LoaiThucAn> list = LoaiThucAnDAO.GetAllLoaiThucAn();
            cbMaLTA.DataSource  = list;
            cbMaLTA.DisplayMember = "TenLoaiThucAn";
            dgvDanhSach.AutoGenerateColumns = false;
            dgvDanhSach.Columns["MaThucAn"].DataPropertyName = "MaThucAn";
            dgvDanhSach.Columns["MaLoaiThucAn"].DataPropertyName = "MaLoaiThucAn";
            dgvDanhSach.Columns["TenThucAn"].DataPropertyName = "TenThucAn";
            dgvDanhSach.Columns["GiaThucAn"].DataPropertyName = "GiaThucAn";
            dgvDanhSach.DataSource = thucAnDAO.GetAllThucAn();
            dgvDanhSach.Refresh();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
                {
               
                    DataGridViewRow selectedRow = dgvDanhSach.Rows[e.RowIndex];
                    txtGiaThucAn.Text = selectedRow.Cells["GiaThucAn"].Value.ToString();
                    txtTenThucAn.Text = selectedRow.Cells["TenThucAn"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int maLoaiThucAn = ((LoaiThucAn)cbMaLTA.SelectedItem).MaLoaiThucAn;
            string tenThucAn = txtTenThucAn.Text.Trim();
            decimal giaThucAn;

            if (decimal.TryParse(txtGiaThucAn.Text, out giaThucAn))
            {
         
                ThucAn thucAn = new ThucAn
                {
                    MaLoaiThucAn = maLoaiThucAn,
                    TenThucAn = tenThucAn,
                    GiaThucAn = giaThucAn
                };

           
                thucAnDAO.AddThucAn(thucAn);


                dgvDanhSach.DataSource = thucAnDAO.GetAllThucAn();
                dgvDanhSach.Refresh();
            }
            else
            {
                MessageBox.Show("Giá thực phẩm không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int maThucAn = Convert.ToInt32(dgvDanhSach.SelectedRows[0].Cells["MaThucAn"].Value);
                    thucAnDAO.DeleteThucAn(maThucAn);
                    dgvDanhSach.DataSource = thucAnDAO.GetAllThucAn();
                    dgvDanhSach.Refresh();
                }
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSach.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvDanhSach.SelectedRows[0];
                    int maThucAn = Convert.ToInt32(selectedRow.Cells["MaThucAn"].Value);
                    int maLoaiThucAn = ((LoaiThucAn)cbMaLTA.SelectedItem).MaLoaiThucAn;
                    string tenThucAn = txtTenThucAn.Text.Trim();
                    decimal giaThucAn;

                    if (decimal.TryParse(txtGiaThucAn.Text, out giaThucAn))
                    {
           
                        ThucAn updatedThucAn = new ThucAn
                        {
                            MaThucAn = maThucAn,
                            MaLoaiThucAn = maLoaiThucAn,
                            TenThucAn = tenThucAn,
                            GiaThucAn = giaThucAn
                        };

              
                        thucAnDAO.EditThucAn(updatedThucAn);

   
                        dgvDanhSach.DataSource = thucAnDAO.GetAllThucAn();
                        dgvDanhSach.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Giá thực phẩm không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
