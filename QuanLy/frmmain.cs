using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
        public void themmanhinhnhanvien()
        {
            pnloadform.Controls.Clear();
            frmnhanvien frm = new frmnhanvien();
            frm.TopLevel = false;
            pnloadform.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        public void themmanhinhdanhmuc()
        {
            pnloadform.Controls.Clear();
            frmdanhmuc frm = new frmdanhmuc();
            frm.TopLevel = false;
            pnloadform.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        public void themmanhinhdonhang()
        {
            pnloadform.Controls.Clear();
            frmdonhang frm = new frmdonhang();
            frm.TopLevel = false;
            pnloadform.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.Width += 60;
            frm.Show();
        }
        public void themmanhinhhanghoa()
        {
            pnloadform.Controls.Clear();
            frmhanghoa frmhh = new frmhanghoa();
            frmhh.TopLevel = false;
            pnloadform.Controls.Add(frmhh);
            frmhh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmhh.Dock = DockStyle.Fill;
            frmhh.Show();
        }
        private void frmmain_Load(object sender, EventArgs e)
        {
            themmanhinhnhanvien();

        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            themmanhinhnhanvien();
        }

        private void btndanhmuc_Click(object sender, EventArgs e)
        {
            themmanhinhdanhmuc();
        }

        private void btnhanghoa_Click(object sender, EventArgs e)
        {
            themmanhinhhanghoa();
        }

        private void btndonhang_Click(object sender, EventArgs e)
        {
            themmanhinhdonhang();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            frmlogin frm = new frmlogin();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
