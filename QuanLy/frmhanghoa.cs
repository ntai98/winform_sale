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
    public partial class frmhanghoa : Form
    {
        public frmhanghoa()
        {
            InitializeComponent();
        }
        public string tinhtrang = "";
        public void dshanghoa(String link)
        {
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(hanghoa[]));
            object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
            hanghoa[] dshh = responsedata as hanghoa[];
            gvdshanghoa.DataSource = null;
            gvdshanghoa.DataSource = dshh;
        }

        public void dsloaihang()
        {
            string link = tt.link + "loaihang";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(loaihang[]));
            object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
            loaihang[] dslh = responsedata as loaihang[];
            cb_loaihang.DataSource = dslh;
            cb_loaihang.ValueMember = "maloai";
            cb_loaihang.DisplayMember = "tenloai";
            

        }
        public void dsloaihang2()
        {
            string link = tt.link + "loaihang";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(loaihang[]));
            object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
            loaihang[] dslh = responsedata as loaihang[];
            
            cbtaohang.DataSource = dslh;
            cbtaohang.ValueMember = "maloai";
            cbtaohang.DisplayMember = "tenloai";
            txtnhapmaloai.Text = "";

        }
        public void tattexbox()
        {
            txtnhapmaloai.Enabled = false;
            txtnhapmaloai.BackColor = Color.White;
            txtnhapmanhom.Enabled = false;
            txtnhapmanhom.BackColor = Color.White;
            txtnhaptenhang.Enabled = false;
            txtnhaptenhang.BackColor = Color.White;
            txtnhapgia.Enabled = false;
            txtnhapgia.BackColor = Color.White;
            txtnhaphinh.Enabled = false;
            txtnhaphinh.BackColor = Color.White;
            txtnhapmota.Enabled = false;
            txtnhapmota.BackColor = Color.White;
        }
        public void motexbox()
        {
            txtnhapmahang.Enabled = true;
            txtnhapmanhom.Enabled = true;
            txtnhaptenhang.Enabled = true;
            txtnhapgia.Enabled = true;
            txtnhaphinh.Enabled = true;
            txtnhapmota.Enabled = true;
            cbtaohang.Show();
        }
    

        private void frmhanghoa_Load(object sender, EventArgs e)
        {
            
            tattexbox();
            string link = tt.link + "hanghoa";
            dshanghoa(link);
            dsloaihang();
            dsloaihang2();
            cbtaohang.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_allhh_Click(object sender, EventArgs e)
        {
            string link = tt.link + "hanghoa";
            dshanghoa(link);
            
        }

        private void btn_xemmaloai_Click(object sender, EventArgs e)
        {
            string link = tt.link + "hanghoa/?maloai=" + cb_loaihang.SelectedValue;
            
            dshanghoa(link);
        }

        private void txt_maloai_Enter(object sender, EventArgs e)
        {
            if( txt_maloai.Text == "nhập mã nhóm")
            {
                txt_maloai.Text = "";
                txt_maloai.ForeColor = Color.Black;
            }
        }

        private void txt_maloai_Leave(object sender, EventArgs e)
        {
            if (txt_maloai.Text == "")
            {
                txt_maloai.Text = "nhập mã nhóm";
                txt_maloai.ForeColor = Color.Silver;
            }
        }

        private void btn_xemmanhom_Click(object sender, EventArgs e)
        {
            string link = tt.link + "hanghoa/?manhom=" + txt_maloai.Text;
            dshanghoa(link);
        }

        

        private void gvdshanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataGridViewRow row = gvdshanghoa.Rows[e.RowIndex];
                txtnhapmahang.Text = row.Cells[0].Value.ToString();
                txtnhapmaloai.Text = row.Cells[1].Value.ToString();
                txtnhapmanhom.Text = row.Cells[2].Value.ToString();
                txtnhaptenhang.Text = row.Cells[3].Value.ToString();
                txtnhapgia.Text = row.Cells[4].Value.ToString();
                txtnhaphinh.Text = row.Cells[5].Value.ToString();
                txtnhapmota.Text = row.Cells[6].Value.ToString();
                string linkanh = tt.linkanh + row.Cells[5].Value.ToString();
                try
                {
                    picnhaphinh.Image = Image.FromFile(linkanh);
                    picnhaphinh.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch { picnhaphinh.Image = null; };
            }
        }
        public hanghoa chitiethanghoa(string id)
        {
            string link = tt.link + "hanghoa/" + id;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(hanghoa));
            object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
            hanghoa hh = responsedata as hanghoa;
            return hh;
        }
        private void btntimhh_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtnhapmahang.Text;
                hanghoa hh = chitiethanghoa(id);

                if (hh != null)
                {
                    txtnhapmaloai.Text = hh.maloai + "";
                    txtnhapmanhom.Text = hh.manhom + "";
                    txtnhaptenhang.Text = hh.tenhang + "";
                    txtnhapgia.Text = hh.gia + "";
                    txtnhaphinh.Text = hh.hinh + "";
                    txtnhapmota.Text = hh.mota + "";
                    try
                    {
                        string linkanh = tt.linkanh + txtnhaphinh.Text;
                        picnhaphinh.Image = Image.FromFile(linkanh);
                        picnhaphinh.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch { picnhaphinh.Image = null; };
                }
            }
            catch { };
        }
        private void uphinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                txtnhaphinh.Text = dlg.FileName.Substring(dlg.FileName.LastIndexOf("\\") + 1);
                string fileSave = tt.linkanh + txtnhaphinh.Text;
                if (File.Exists(fileSave))
                {
                    MessageBox.Show("Đã tồn tại file có tên" + txtnhaphinh.Text + "trong hệ thống");
                    picnhaphinh.Image = Image.FromFile(fileSave);
                    picnhaphinh.SizeMode = PictureBoxSizeMode.StretchImage;
                    return;
                }

                try
                {
                    picnhaphinh.Image = Image.FromFile(fileName);
                    picnhaphinh.SizeMode = PictureBoxSizeMode.StretchImage;
                    File.Copy(fileName, fileSave);
                }
                catch {
                    txtnhaphinh.Text = "";
                    MessageBox.Show("File bạn chọn không phải là file hình ảnh");
                };
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            motexbox();
            txtnhapmahang.Text = "";
            txtnhapmahang.Enabled = false;
            txtnhapmaloai.Text =  "";
            txtnhapmanhom.Text = "";
            txtnhaptenhang.Text = "";
            txtnhapgia.Text = "";
            txtnhaphinh.Text = "";
            txtnhapmota.Text = "";
            tinhtrang = "them";
            picnhaphinh.Image = null;

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            motexbox();
            tinhtrang = "sua";
        }
        
       
        private void btnluu_Click(object sender, EventArgs e)
        {
            string link = tt.link + "hanghoa/";
            if (tinhtrang == "them")
            {
                string phuongthucthuchien = "POST";
                string linkthem = string.Format("?manhom={0}&maloai={1}&tenhang={2}&gia={3}&hinh={4}&mota={5}"
                    , txtnhapmanhom.Text, txtnhapmaloai.Text, txtnhaptenhang.Text, txtnhapgia.Text, txtnhaphinh.Text, txtnhapmota.Text);
                bool kq;
                kq = controlapi.Instance.POSTPUTDELETE(link, linkthem, phuongthucthuchien);
                if (kq)
                {
                    MessageBox.Show("thêm thành công");
                }
                
                else
                {
                    MessageBox.Show("thêm thất bại");
                }
                
            }
            if (tinhtrang == "sua")
            {
                string phuongthucthuchien = "PUT";
                string linksua = string.Format("?mahang={0}&manhom={1}&maloai={2}&tenhang={3}&gia={4}&hinh={5}&mota={6}",
                    txtnhapmahang.Text, txtnhapmanhom.Text, txtnhapmaloai.Text, txtnhaptenhang.Text,
                    txtnhapgia.Text, txtnhaphinh.Text, txtnhapmota.Text);
                bool kq;
                kq = controlapi.Instance.POSTPUTDELETE(link, linksua, phuongthucthuchien);
                if (kq)
                {
                    MessageBox.Show("sửa thành công");
                }
                else
                {
                    MessageBox.Show("sửa thất bại");
                }

            }
            txtnhapmaloai.Text = "";
            cbtaohang.Hide();
            dshanghoa(link);
            tattexbox();
            tinhtrang = "";
        }



        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(txtnhapmahang.Text != "")
            {
                string link = tt.link + "hanghoa/";
                string phuongthucthuchien = "DELETE";
                string linksua = "?mahang=" + txtnhapmahang.Text;
                bool kq;
                kq = controlapi.Instance.POSTPUTDELETE(link, linksua, phuongthucthuchien);
                if (kq)
                {
                    MessageBox.Show("xóa thành công");
                    dshanghoa(link);
                }
                else
                {
                    MessageBox.Show("xóa thất bại");
                }
            }
        }

        private void txtnhapmahang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtnhapmanhom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtnhapgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbtaohang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnhapmaloai.Text = "" + cbtaohang.SelectedValue;
        }
    }
}
