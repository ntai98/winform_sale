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
    public partial class frmdanhmuc : Form
    {
        public frmdanhmuc()
        {
            InitializeComponent();
        }

        public void dsloaihang()
        {
            string link = tt.link + "loaihang";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(loaihang[]));
            object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
            loaihang[] dslh = responsedata as loaihang[];
            cb_maloainhomhang.DataSource = dslh;
            cb_maloainhomhang.ValueMember = "maloai";
            cb_maloainhomhang.DisplayMember = "tenloai";
        }
        public void dsloaihang2()
        {
            string link = tt.link + "loaihang";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(loaihang[]));
            object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
            loaihang[] dslh = responsedata as loaihang[];
            cbnhapmaloai.DataSource = dslh;
            cbnhapmaloai.ValueMember = "maloai";
            cbnhapmaloai.DisplayMember = "tenloai";
        }

        public void dsnhomhang(string link2)
        {
            string link = tt.link + "" + link2;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(nhomhang[]));
            object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
            nhomhang[] dsnhomhang = responsedata as nhomhang[];
            gvnhomhang.DataSource = null;
            gvnhomhang.DataSource = dsnhomhang;


        }

        public void tattexbox()
        {
            txtmaloai.Enabled = false;
            txtmaloai.BackColor = Color.White;
            txtmanhom.Enabled = false;
            txtmanhom.BackColor = Color.White;
            txttennhom.Enabled = false;
            txttennhom.BackColor = Color.White;
            
        }
        public void motexbox()
        {
            txtmanhom.Enabled = true;
            txttennhom.Enabled = true;
            cbnhapmaloai.Show();
        }

        private void frmdanhmuc_Load(object sender, EventArgs e)
        {
            string link = "nhomhang/";
            dsnhomhang(link);
            dsloaihang();
            dsloaihang2();
            txtmaloai.Text = "";
            tattexbox();
            cbnhapmaloai.Hide();
        }

        private void btn_ALLnhomhang_Click(object sender, EventArgs e)
        {
            string link = "nhomhang/";
            dsnhomhang(link);
        }

        private void btn_maloainhomhang_Click(object sender, EventArgs e)
        {
            string link = "nhomhang/?maloai=" + cb_maloainhomhang.SelectedValue;
            dsnhomhang(link);
        }

        private void gvnhomhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = gvnhomhang.Rows[e.RowIndex];
                txtmaloai.Text = row.Cells[0].Value.ToString();
                txtmanhom.Text = row.Cells[1].Value.ToString();
                txttennhom.Text = row.Cells[2].Value.ToString();
                
            }
        }

        public string tinhtrang = "";

        private void btnthem_Click(object sender, EventArgs e)
        {
            motexbox();
            txtmaloai.Text = "";
            txtmanhom.Text = "";
            txtmanhom.Enabled = false;
            txttennhom.Text = "";
            tinhtrang = "them";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            motexbox();
            tinhtrang = "sua";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string link = tt.link + "nhomhang/";
            if (tinhtrang == "them" )
            {
                if (txtmaloai.Text == "") { MessageBox.Show("thêm thất bại"); }
                else
                {
                    string phuongthucthuchien = "POST";
                    string linkthem = string.Format("?maloai={0}&tennhom={1}"
                        , txtmaloai.Text, txttennhom.Text);
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

            }
            if (tinhtrang == "sua")
            {
                string phuongthucthuchien = "PUT";
                string linksua = string.Format("?maloai={0}&manhom={1}&tennhom={2}",
                    txtmaloai.Text, txtmanhom.Text, txttennhom.Text);
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
            txtmaloai.Text = "";
            txttennhom.Text = "";
            txtmaloai.Text = "";
            cbnhapmaloai.Hide();
            string linknhomhang = "nhomhang/";
            dsnhomhang(linknhomhang);
            tattexbox();
            tinhtrang = "";
        }

        private void txtmanhom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbnhapmaloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmaloai.Text = "" + cbnhapmaloai.SelectedValue;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmanhom.Text != "")
            {
                string link = tt.link + "nhomhang/";
                string phuongthucthuchien = "DELETE";
                string linksua = "?manhom=" + txtmanhom.Text;
                bool kq;
                kq = controlapi.Instance.POSTPUTDELETE(link, linksua, phuongthucthuchien);
                if (kq)
                {
                    MessageBox.Show("xóa thành công");
                    string linknhomhang = "nhomhang/";
                    dsnhomhang(linknhomhang);
                    txtmaloai.Text = "";
                    txttennhom.Text = "";
                    txtmaloai.Text = "";
                }
                else
                {
                    MessageBox.Show("xóa thất bại");
                }
            }
        }
    }
}
