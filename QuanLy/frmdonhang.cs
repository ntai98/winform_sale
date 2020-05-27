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
    public partial class frmdonhang : Form
    {
        public frmdonhang()
        {
            InitializeComponent();
        }
        public donhang[] laydsdonhang(string link) {
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(donhang[]));
            object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
            donhang[] dsdh = responsedata as donhang[];
            return dsdh;
        }
        public void dsdonhang(string link)
        {
            donhang[] dsdh = laydsdonhang(link);
            gvdsdonhang.DataSource = null;
            gvdsdonhang.DataSource = dsdh;
        }

        public donhang donhangtheoid(string id)
        {
            string link = tt.link + "donhang/" + id;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(donhang));
            object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
            donhang dh = responsedata as donhang;
            return dh;
        }
        public void xoatextboxandreload()
        {
            
            txtmsdh.Text = "";
            txttkkh.Text = "";
            txtngaydathang.Text = "";
            txttinhtrang.Text = "";
            txttknv1.Text = "";
            txttknv2.Text = "";
            txtdcnhanhang.Text = "";
            txtghichu.Text = "";
            string link = tt.link + "donhang";
            dsdonhang(link);

        }
        private void donhang_Load(object sender, EventArgs e)
        {
            string link = tt.link + "donhang";
            dsdonhang(link);

        }

        private void btndsdonhang_Click(object sender, EventArgs e)
        {
            string link = tt.link + "donhang";
            dsdonhang(link);
        }

        private void btndscxndonhang_Click(object sender, EventArgs e)
        {
            string link = tt.link + "donhang?tinhtrang=chuaxacnhan";
            dsdonhang(link);
        }

        private void btndsxndonhang_Click(object sender, EventArgs e)
        {
            string link = tt.link + "donhang?tinhtrang=daxacnhan";
            dsdonhang(link);
        }

        private void btndshtdonhang_Click(object sender, EventArgs e)
        {
            string link = tt.link + "donhang?tinhtrang=hoantat";
            dsdonhang(link);
        }

        private void btndshuydonhang_Click(object sender, EventArgs e)
        {
            string link = tt.link + "donhang?tinhtrang=huy";
            dsdonhang(link);
        }

        private void gvdonhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow row = gvdsdonhang.Rows[e.RowIndex];
                    txtmsdh.Text = row.Cells[0].Value.ToString();
                    txttkkh.Text = row.Cells[1].Value.ToString();
                    txtngaydathang.Text = row.Cells[2].Value.ToString();
                    txttinhtrang.Text = row.Cells[3].Value.ToString();
                    txttknv1.Text = row.Cells[4].Value.ToString();
                    txttknv2.Text = row.Cells[5].Value.ToString();
                    txtdcnhanhang.Text = row.Cells[6].Value.ToString();
                    txtghichu.Text = row.Cells[7].Value.ToString();

                }
            }
            catch { };
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (txtmsdh.Text != "" && txttinhtrang.Text == "chuaxacnhan")
            {
                string link = tt.link + "donhang";
                string phuongthucthuchien = "PUT";
                string linksua = string.Format("?masodh={0}&tknv1={1}", txtmsdh.Text, tt.id
                    );
                bool kq;
                kq = controlapi.Instance.POSTPUTDELETE(link, linksua, phuongthucthuchien);
                if (kq)
                {
                    MessageBox.Show("thành công");
                }
                else
                {
                    MessageBox.Show("thất bại");
                }
            }
            xoatextboxandreload();
        }

        private void btnhoanthanh_Click(object sender, EventArgs e)
        {
            if (txtmsdh.Text != "" && txttinhtrang.Text == "daxacnhan")
            {
                string link = tt.link + "donhang";
                string phuongthucthuchien = "PUT";
                string linksua = string.Format("?masodh={0}&tknv2={1}", txtmsdh.Text, tt.id
                    );
                bool kq;
                kq = controlapi.Instance.POSTPUTDELETE(link, linksua, phuongthucthuchien);
                if (kq)
                {
                    MessageBox.Show("thành công");
                }
                else
                {
                    MessageBox.Show("thất bại");
                }
            }
            xoatextboxandreload();

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (txtmsdh.Text != "" && txttinhtrang.Text == "chuaxacnhan")
            {
                string link = tt.link + "donhang";
                string phuongthucthuchien = "PUT";
                string linksua = "?masodh=" + txtmsdh.Text;
                bool kq;
                kq = controlapi.Instance.POSTPUTDELETE(link, linksua, phuongthucthuchien);
                if (kq)
                {
                    MessageBox.Show("thành công");
                }
                else
                {
                    MessageBox.Show("thất bại");
                }
            }
            xoatextboxandreload();
        }

        private void btnxemchitietdh_Click(object sender, EventArgs e)
        {
            timdonhang(txtmsdh.Text);
            chitietdonhangtheoid(txtmsdh.Text);
            tpdonhang.SelectTab(tpchitietdh);
        }
        public void timdonhang(string id)
        {
            donhang dh = new donhang();
            try
            {
                dh = donhangtheoid(id);
                txtmsdh.Text = dh.masodh + "";
                txttkkh.Text = dh.tkkh + "";
                txtngaydathang.Text = dh.ngaydathang + "";
                txttinhtrang.Text = dh.tinhtrang + "";
                txttknv1.Text = dh.tknv1 + "";
                txttknv2.Text = dh.tknv2 + "";
                txtdcnhanhang.Text = dh.diachinhanhang + "";
                txtghichu.Text = dh.ghichu + "";
            }
            catch
            {
                if (dh == null) { MessageBox.Show("không tìm thấy"); }
                txtmsdh.Text = "";
                txttkkh.Text = "";
                txtngaydathang.Text = "";
                txttinhtrang.Text = "";
                txttknv1.Text = "";
                txttknv2.Text = "";
                txtdcnhanhang.Text = "";
                txtghichu.Text = "";
            };
        }
        private void btntimdonhang_Click(object sender, EventArgs e)
        {

            timdonhang(txtmsdh.Text);

        }

        public void chitietdonhangtheoid(string iddonhang)
        {
            try
            {
                string link = tt.link + "chitietdonhang/" + iddonhang;
                HttpWebRequest request = WebRequest.CreateHttp(link);
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(chitietdonhang[]));
                object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
                chitietdonhang[] chitietdh = responsedata as chitietdonhang[];
                if (chitietdh.Count() == 0)
                {
                    txttimchitietdonhang.Text = "";
                    return;
                }
                gvchitietdonhang.DataSource = null;
                gvchitietdonhang.DataSource = chitietdh;
                txttimchitietdonhang.Text = iddonhang;
                
            }
            catch { txttimchitietdonhang.Text = ""; };

        }

        private void btntimchitietdonhang_Click(object sender, EventArgs e)
        {
            string madonhang = txttimchitietdonhang.Text;
            try
            {
                chitietdonhangtheoid(madonhang);
                timdonhang(madonhang);

            }
            catch { };
        }

        private void gvchitietdonhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow row = gvchitietdonhang.Rows[e.RowIndex];
                    frmhanghoa frmhh = new frmhanghoa();
                    hanghoa hh = frmhh.chitiethanghoa(row.Cells[1].Value.ToString());
                    txtnhapmahang.Text = hh.mahang.ToString();
                    txtnhapmaloai.Text = hh.maloai.ToString();
                    txtnhapmanhom.Text = hh.manhom.ToString();
                    txtnhaptenhang.Text = hh.tenhang.ToString();
                    txtnhapgia.Text = hh.gia.ToString();
                    txtnhaphinh.Text = hh.hinh.ToString();
                    txtnhapmota.Text = hh.mota.ToString();
                    string linkanh = tt.linkanh + hh.hinh.ToString();
                    try
                    {
                        picnhaphinh.Image = Image.FromFile(linkanh);
                        picnhaphinh.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch { picnhaphinh.Image = null; };
                }
            }
            catch { };
            
        }

        private void btnxacnhan2_Click(object sender, EventArgs e)
        {

            if (txttimchitietdonhang.Text != "" && txttinhtrang.Text == "chuaxacnhan")
            {
                string link = tt.link + "donhang";
                string phuongthucthuchien = "PUT";
                string linksua = string.Format("?masodh={0}&tknv1={1}", txttimchitietdonhang.Text, tt.id
                    );
                bool kq;
                kq = controlapi.Instance.POSTPUTDELETE(link, linksua, phuongthucthuchien);
                if (kq)
                {
                    MessageBox.Show("thành công");
                }
                else
                {
                    MessageBox.Show("thất bại");
                }
            }
            xoatextboxandreload();
            tpdonhang.SelectTab(tpthongtindh);
        }

        private void btnhoanthanh2_Click(object sender, EventArgs e)
        {
            if (txttimchitietdonhang.Text != "" && txttinhtrang.Text == "daxacnhan")
            {
                string link = tt.link + "donhang";
                string phuongthucthuchien = "PUT";
                string linksua = string.Format("?masodh={0}&tknv2={1}", txttimchitietdonhang.Text, tt.id
                    );
                bool kq;
                kq = controlapi.Instance.POSTPUTDELETE(link, linksua, phuongthucthuchien);
                if (kq)
                {
                    MessageBox.Show("thành công");
                }
                else
                {
                    MessageBox.Show("thất bại");
                }
            }
            xoatextboxandreload();
            tpdonhang.SelectTab(tpthongtindh);
        }

        private void btnhuy2_Click(object sender, EventArgs e)
        {
            //if (txttimchitietdonhang.Text != "" && txttinhtrang.Text == "chuaxacnhan")
            {
                string link = tt.link + "donhang";
                string phuongthucthuchien = "PUT";
                string linksua = "?masodh="+ txttimchitietdonhang.Text;
                bool kq;
                kq = controlapi.Instance.POSTPUTDELETE(link, linksua, phuongthucthuchien);
                if (kq)
                {
                    MessageBox.Show("thành công");
                }
                else
                {
                    MessageBox.Show("thất bại " );
                }
            }
            xoatextboxandreload();
            tpdonhang.SelectTab(tpthongtindh);
        }

        private void btnthemvaodsmua_Click(object sender, EventArgs e)
        {
            

            frmhanghoa frmhh = new frmhanghoa();
            try
            {
                hanghoa hh = frmhh.chitiethanghoa(txtmahangtch.Text);

                if (hh != null)
                {
                    bool dkthem = true;
                    for (int i = 0; i < lvmuataicuahang.Items.Count; i++)
                    {
                        ListViewItem lv = lvmuataicuahang.Items[i];
                        if(txtmahangtch.Text == lv.SubItems[0].Text)
                        {
                            dkthem = false;
                        }
                    }
                    if(dkthem == true)
                    {
                        ListViewItem lvi = new ListViewItem(txtmahangtch.Text);
                        lvi.SubItems.Add(hh.tenhang);
                        lvi.SubItems.Add(txtsoluongtch.Text);
                        if (txtkhuyenmai.Text == "")
                        {
                            txtkhuyenmai.Text = "0";
                        }
                        float khuyenmai = ((float)Convert.ToDouble(txtkhuyenmai.Text) / 100) * hh.gia;
                        int gia1sp = hh.gia - (int)khuyenmai;
                        int tong = Convert.ToInt32(txtsoluongtch.Text) * gia1sp;
                        lvi.SubItems.Add(gia1sp.ToString());
                        lvi.SubItems.Add(tong.ToString());
                        lvmuataicuahang.Items.Add(lvi);
                    }
                    else MessageBox.Show("sản phẩm đã tồn tại trong danh sách mua ");


                }
                else MessageBox.Show("không tìm thấy hàng hóa");
            }
            catch { MessageBox.Show("loi!"); };
            txtmahangtch.Text = "";
            txtsoluongtch.Text = "";
            txtkhuyenmai.Text = "";

        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvmuataicuahang.SelectedItems.Count > 0)
            {
                lvmuataicuahang.Items.Remove(lvmuataicuahang.SelectedItems[0]);
            }
        }
        string dk = "";
        
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            
            string time = "";
            if ( dk == "")
            {
                time = DateTime.Now.ToString();
            dk = "dung";
            }
            string link = tt.link + "donhang/";
            string madonhangtch = ""; 
            if (lvmuataicuahang.Items.Count > 0)
            {
                string phuongthucthuchien = "POST";
                string linkthem = string.Format("?tknv={0}&ngaydathang={1}"
                    , tt.id, time);
                int kq;
                HttpWebRequest request = WebRequest.CreateHttp(link + linkthem);
                request.Method = phuongthucthuchien;
                request.ContentType = "Application/json;charset=UTF-8";
                byte[] bytearr = Encoding.UTF8.GetBytes(linkthem);
                request.ContentLength = bytearr.Length;
                Stream datatstream = request.GetRequestStream();
                datatstream.Write(bytearr, 0, bytearr.Length);
                datatstream.Close();
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(int));
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                object responsedata = jsonSerializer.ReadObject(response.GetResponseStream());
                kq = (int)responsedata;
                if (kq != 0)
                {

                    
                    for (int i = 0; i < lvmuataicuahang.Items.Count; i++)
                    {
                        ListViewItem lvi = lvmuataicuahang.Items[i];
                        string mahang = lvi.SubItems[0].Text;
                        string soluong = lvi.SubItems[2].Text;
                        string gia1sp = lvi.SubItems[3].Text;
                        string linkchitiet = tt.link + "chitietdonhang/";
                        string phuongthucthuchien1 = "POST";
                        string linkthem1 = string.Format("?masodh={0}&mahang={1}&soluong={2}&gia1sp={3}"
                            , kq, mahang, soluong, gia1sp);
                        bool kq1;
                        kq1 = controlapi.Instance.POSTPUTDELETE(linkchitiet, linkthem1, phuongthucthuchien1);
                        if (kq1)
                        {
                        }
                        else { MessageBox.Show("that bai"); }
                    }

                }
                else
                {
                    MessageBox.Show("loi tao don \n" + link + linkthem);
                }
            }
            dk = "";
            lvmuataicuahang.Items.Clear();
            dsdonhang(link);


        }

        private void btnmuatch_Click(object sender, EventArgs e)
        {
            string link = tt.link + "donhang?tinhtrang=muataicuahang";
            dsdonhang(link);
        }

        
    }
}
