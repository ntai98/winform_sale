using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy.api;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;
namespace QuanLy
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            frmnhanvien nv = new frmnhanvien();
            string mk = nv.ToMD5(txtmk.Text);
            try
            {
                string link = tt.link + "nhavien/";
                string phuongthucthuchien = "POST";
                string linkthem = string.Format("?tknv={0}&mknv={1}", txttk.Text,mk );
                bool kq;
                kq = controlapi.Instance.POSTPUTDELETE(link, linkthem, phuongthucthuchien);
                if (kq)
                {
                    tt.id = txttk.Text;
                    frmmain frm = new frmmain();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();

                }

                else
                {
                    MessageBox.Show("thất bại");
                }
            }
            catch { MessageBox.Show("loi"); }
        }
    }
}
