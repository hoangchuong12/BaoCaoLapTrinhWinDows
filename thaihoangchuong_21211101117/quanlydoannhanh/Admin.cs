using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlydoannhanh.frm;




namespace quanlydoannhanh
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
   
        }


        private void btnBanAn_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpBanAn"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý bàn ăn";
                tabPage.Name = "tpBanAn";
                tabPage.ImageIndex = 0;
                Form frm = new frmBanAn();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpBanAn"];
            }
        }
        private bool ExistTabPage(TabControl tabControl, string tabPageName)
        {
            return tabControl.TabPages.ContainsKey(tabPageName);
        }

        private void tabControlMain_Click(object sender, EventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpHoaDon"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý hóa đơn";
                tabPage.Name = "tpHoaDon";
                tabPage.ImageIndex = 0;
                Form frm = new frmHoaDon();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpHoaDon"];
            }
        }

        private void btnLoaiThucAn_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpLoaiThucAn"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý loại thức ăn";
                tabPage.Name = "tpLoaiThucAn";
                tabPage.ImageIndex = 0;
                Form frm = new frmLoaiThucAn();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);

            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpLoaiThucAn"];
            }
        }

        private void btnThucAn_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpThucAn"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý thức ăn";
                tabPage.Name = "tpThucAn";
                tabPage.ImageIndex = 0;
                Form frm = new frmThucAn();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpThucAn"];
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControlMain_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            Form frmDatHang = new frmDatHang();
            frmDatHang.ShowDialog();
        }
    }
}
