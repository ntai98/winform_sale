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
using System.Security.Cryptography;

namespace QuanLy
{
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }
        string tinhtrang = "";

        public nhanvien chitietnhanvien(string id)
        {
            string link = tt.link + "nhavien/" + id;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(nhanvien));
            object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
            nhanvien nv = responsedata as nhanvien;
            return nv;
        }

        public void dsnhanvien()
        {
            string link = tt.link + "nhavien/" ;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(nhanvien[]));
            object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
            nhanvien[] dsnv = responsedata as nhanvien[];
            gvdsnhanvien.DataSource = null;
            gvdsnhanvien.DataSource = dsnv;
        }

        public void tattexbox()
        {
            lbtaomk.Hide();
            txttaomk.Hide();            
            txttaohoten.Enabled = false;
            txttaohoten.BackColor = Color.White;
            txttaogioitinh.Enabled = false;
            txttaogioitinh.BackColor = Color.White;
            txttaodiachi.Enabled = false;
            txttaodiachi.BackColor = Color.White;
            txttaosdt.Enabled = false;
            txttaosdt.BackColor = Color.White;
            txttaocmnd.Enabled = false;
            txttaocmnd.BackColor = Color.White;
        }

        public void motexbox()
        {
            lbtaomk.Show();
            txttaomk.Show();
            txttaohoten.Enabled = true;
            txttaogioitinh.Enabled = true;
            txttaodiachi.Enabled = true;
            txttaosdt.Enabled = true;
            txttaocmnd.Enabled = true;
        }

        public string ToMD5(string str)
        {
            string result = "";
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            for (int i = 0; i < buffer.Length; i++)
            {
                result += buffer[i].ToString("x2");
            }
            return result;
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            if (tt.id != "admin")
            {
                tpnhanvien.TabPages.Remove(tpqlnv);
            }
            tattexbox();
            txtk.Text = tt.id;
            nhanvien nv = chitietnhanvien(tt.id);
            if (nv != null)
            {
                txthoten.Text = nv.hotennv + "";
                txtgioitinh.Text = nv.gioitinhnv + "";
                txtdiachi.Text = nv.diachinv + "";
                txtsdt.Text = nv.sdtnv + "";
                txtcmnd.Text = nv.cmndnv + "";
            }
            dsnhanvien();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string link = tt.link + "nhavien/";
            string phuongthucthuchien = "PUT";
            string linksua = string.Format("?tknv={0}&htnv={1}&gtnv={2}&dcnv={3}&sdtnv={4}&cmndnv={5}",
                tt.id,txthoten.Text,txtgioitinh.Text,txtdiachi.Text,txtsdt.Text,txtcmnd.Text);
            bool kq;
            kq = controlapi.Instance.POSTPUTDELETE(link, linksua, phuongthucthuchien);
            if (kq)
            {
                MessageBox.Show("sửa thành công");
            }
            else
            {
                MessageBox.Show("sửa thất bại" );
                
            }

        }


        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            string mkcu = ToMD5(txtmkcu.Text);
            string mkmoi = ToMD5(txtmkmoi.Text);
            string link = tt.link + "nhavien/";
            string phuongthucthuchien = "PUT";
            string linksua = string.Format("?tknv={0}&mknv={1}&mkmoi={2}",
                tt.id, mkcu,mkmoi);
            bool kq;
            kq = controlapi.Instance.POSTPUTDELETE(link, linksua, phuongthucthuchien);
            if (kq)
            {
                MessageBox.Show("đổi mật khẩuthành công");
            }
            else
            {
                MessageBox.Show("đổi mật khẩu thất bại");
                
            }
        }

        private void gvdsnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = gvdsnhanvien.Rows[e.RowIndex];
                txttaotktk.Text = row.Cells[0].Value.ToString();
                txttaohoten.Text = row.Cells[1].Value.ToString();
                txttaogioitinh.Text = row.Cells[2].Value.ToString();
                txttaodiachi.Text = row.Cells[3].Value.ToString();
                txttaosdt.Text = row.Cells[4].Value.ToString();
                txttaocmnd.Text = row.Cells[5].Value.ToString();

                
            }
        }

        private void btntimnv_Click(object sender, EventArgs e)
        {
            nhanvien ttnv = new nhanvien();
            try
            {
                ttnv = chitietnhanvien(txttaotktk.Text);
                txttaohoten.Text = ttnv.hotennv + "";
                txttaogioitinh.Text = ttnv.gioitinhnv + "";
                txttaodiachi.Text = ttnv.diachinv + "";
                txttaosdt.Text = ttnv.sdtnv + "";
                txttaocmnd.Text = ttnv.cmndnv + "";
            }
            catch {
                if (ttnv == null) { MessageBox.Show("không tìm thấy"); }
                txttaohoten.Text = "";
                txttaogioitinh.Text = "";
                txttaodiachi.Text = "";
                txttaosdt.Text = "";
                txttaocmnd.Text = "";
            };
        }

        private void btnxoatk_Click(object sender, EventArgs e)
        {
            if(txttaotktk.Text != "")
            {
                string link = tt.link + "nhavien/";
                string phuongthucthuchien = "DELETE";
                string linksua = "?tknv=" + txttaotktk.Text;
                bool kq;
                kq = controlapi.Instance.POSTPUTDELETE(link, linksua, phuongthucthuchien);
                if (kq)
                {
                    MessageBox.Show("xóa thành công");
                    dsnhanvien();
                }
                else
                {
                    MessageBox.Show("xóa thất bại");
                }
            }
        }

        private void btnthemnv_Click(object sender, EventArgs e)
        {
            tinhtrang = "them";
            motexbox();
            txttaotktk.Text = "";
            txttaohoten.Text = "";
            txttaogioitinh.Text = "";
            txttaodiachi.Text = "";
            txttaosdt.Text = "";
            txttaocmnd.Text = "";
        }

        private void btnluuthemnv_Click(object sender, EventArgs e)
        {
            if (tinhtrang == "them"){
                string link = tt.link + "nhavien/";
                string phuongthucthuchien = "POST";
                string taomk = ToMD5(txttaomk.Text);
                string linkthem = string.Format("?tknv={0}&mknv={1}&htnv={2}&gtnv={3}&dcnv={4}&sdtnv={5}&cmndnv={6}"
                    , txttaotktk.Text, taomk, txttaohoten.Text, txttaogioitinh.Text, txttaodiachi.Text,
                    txttaosdt.Text, txttaocmnd.Text);
                bool kq;
                kq = controlapi.Instance.POSTPUTDELETE(link, linkthem, phuongthucthuchien);
                if (kq)
                {
                    MessageBox.Show("thêm thành công");
                    dsnhanvien();
                }

                else
                {
                    MessageBox.Show("thêm thất bại");
                }
            }
            tinhtrang = "";
            tattexbox();
        }

       
    }
}
