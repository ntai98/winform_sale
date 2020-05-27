namespace QuanLy
{
    partial class frmhanghoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvdshanghoa = new System.Windows.Forms.DataGridView();
            this.btn_allhh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xemmaloai = new System.Windows.Forms.Button();
            this.cb_loaihang = new System.Windows.Forms.ComboBox();
            this.btn_xemmanhom = new System.Windows.Forms.Button();
            this.txt_maloai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnhapmahang = new System.Windows.Forms.TextBox();
            this.txtnhapmaloai = new System.Windows.Forms.TextBox();
            this.txtnhapmanhom = new System.Windows.Forms.TextBox();
            this.txtnhaptenhang = new System.Windows.Forms.TextBox();
            this.txtnhapgia = new System.Windows.Forms.TextBox();
            this.txtnhaphinh = new System.Windows.Forms.TextBox();
            this.txtnhapmota = new System.Windows.Forms.TextBox();
            this.btntimhh = new System.Windows.Forms.Button();
            this.picnhaphinh = new System.Windows.Forms.PictureBox();
            this.uphinh = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.cbtaohang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvdshanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picnhaphinh)).BeginInit();
            this.SuspendLayout();
            // 
            // gvdshanghoa
            // 
            this.gvdshanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvdshanghoa.Location = new System.Drawing.Point(21, 130);
            this.gvdshanghoa.Name = "gvdshanghoa";
            this.gvdshanghoa.ReadOnly = true;
            this.gvdshanghoa.Size = new System.Drawing.Size(716, 382);
            this.gvdshanghoa.TabIndex = 6;
            this.gvdshanghoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvdshanghoa_CellClick);
            // 
            // btn_allhh
            // 
            this.btn_allhh.Location = new System.Drawing.Point(21, 66);
            this.btn_allhh.Name = "btn_allhh";
            this.btn_allhh.Size = new System.Drawing.Size(67, 33);
            this.btn_allhh.TabIndex = 1;
            this.btn_allhh.Text = "ALL";
            this.btn_allhh.UseVisualStyleBackColor = true;
            this.btn_allhh.Click += new System.EventHandler(this.btn_allhh_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HÀNG HÓA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_xemmaloai
            // 
            this.btn_xemmaloai.Location = new System.Drawing.Point(268, 66);
            this.btn_xemmaloai.Name = "btn_xemmaloai";
            this.btn_xemmaloai.Size = new System.Drawing.Size(75, 33);
            this.btn_xemmaloai.TabIndex = 3;
            this.btn_xemmaloai.Text = "XEM";
            this.btn_xemmaloai.UseVisualStyleBackColor = true;
            this.btn_xemmaloai.Click += new System.EventHandler(this.btn_xemmaloai_Click);
            // 
            // cb_loaihang
            // 
            this.cb_loaihang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_loaihang.FormattingEnabled = true;
            this.cb_loaihang.Location = new System.Drawing.Point(141, 68);
            this.cb_loaihang.Name = "cb_loaihang";
            this.cb_loaihang.Size = new System.Drawing.Size(121, 28);
            this.cb_loaihang.TabIndex = 2;
            // 
            // btn_xemmanhom
            // 
            this.btn_xemmanhom.Location = new System.Drawing.Point(477, 66);
            this.btn_xemmanhom.Name = "btn_xemmanhom";
            this.btn_xemmanhom.Size = new System.Drawing.Size(75, 33);
            this.btn_xemmanhom.TabIndex = 5;
            this.btn_xemmanhom.Text = "OK";
            this.btn_xemmanhom.UseVisualStyleBackColor = true;
            this.btn_xemmanhom.Click += new System.EventHandler(this.btn_xemmanhom_Click);
            // 
            // txt_maloai
            // 
            this.txt_maloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maloai.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_maloai.Location = new System.Drawing.Point(376, 66);
            this.txt_maloai.Multiline = true;
            this.txt_maloai.Name = "txt_maloai";
            this.txt_maloai.Size = new System.Drawing.Size(95, 33);
            this.txt_maloai.TabIndex = 4;
            this.txt_maloai.Text = "nhập mã nhóm";
            this.txt_maloai.Enter += new System.EventHandler(this.txt_maloai_Enter);
            this.txt_maloai.Leave += new System.EventHandler(this.txt_maloai_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(743, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(743, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(743, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(743, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mã nhóm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(743, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(743, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Hình";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(743, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mô tả";
            // 
            // txtnhapmahang
            // 
            this.txtnhapmahang.Location = new System.Drawing.Point(832, 129);
            this.txtnhapmahang.Name = "txtnhapmahang";
            this.txtnhapmahang.Size = new System.Drawing.Size(100, 20);
            this.txtnhapmahang.TabIndex = 11;
            this.txtnhapmahang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnhapmahang_KeyPress);
            // 
            // txtnhapmaloai
            // 
            this.txtnhapmaloai.Location = new System.Drawing.Point(832, 155);
            this.txtnhapmaloai.Name = "txtnhapmaloai";
            this.txtnhapmaloai.Size = new System.Drawing.Size(100, 20);
            this.txtnhapmaloai.TabIndex = 14;
            // 
            // txtnhapmanhom
            // 
            this.txtnhapmanhom.Location = new System.Drawing.Point(832, 190);
            this.txtnhapmanhom.Name = "txtnhapmanhom";
            this.txtnhapmanhom.Size = new System.Drawing.Size(100, 20);
            this.txtnhapmanhom.TabIndex = 17;
            this.txtnhapmanhom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnhapmanhom_KeyPress);
            // 
            // txtnhaptenhang
            // 
            this.txtnhaptenhang.Location = new System.Drawing.Point(832, 223);
            this.txtnhaptenhang.Name = "txtnhaptenhang";
            this.txtnhaptenhang.Size = new System.Drawing.Size(100, 20);
            this.txtnhaptenhang.TabIndex = 19;
            // 
            // txtnhapgia
            // 
            this.txtnhapgia.Location = new System.Drawing.Point(832, 253);
            this.txtnhapgia.Name = "txtnhapgia";
            this.txtnhapgia.Size = new System.Drawing.Size(100, 20);
            this.txtnhapgia.TabIndex = 21;
            this.txtnhapgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnhapgia_KeyPress);
            // 
            // txtnhaphinh
            // 
            this.txtnhaphinh.Location = new System.Drawing.Point(832, 282);
            this.txtnhaphinh.Name = "txtnhaphinh";
            this.txtnhaphinh.Size = new System.Drawing.Size(100, 20);
            this.txtnhaphinh.TabIndex = 23;
            // 
            // txtnhapmota
            // 
            this.txtnhapmota.Location = new System.Drawing.Point(832, 442);
            this.txtnhapmota.Multiline = true;
            this.txtnhapmota.Name = "txtnhapmota";
            this.txtnhapmota.Size = new System.Drawing.Size(100, 70);
            this.txtnhapmota.TabIndex = 26;
            // 
            // btntimhh
            // 
            this.btntimhh.Location = new System.Drawing.Point(948, 129);
            this.btntimhh.Name = "btntimhh";
            this.btntimhh.Size = new System.Drawing.Size(45, 23);
            this.btntimhh.TabIndex = 12;
            this.btntimhh.Text = "Tìm";
            this.btntimhh.UseVisualStyleBackColor = true;
            this.btntimhh.Click += new System.EventHandler(this.btntimhh_Click);
            // 
            // picnhaphinh
            // 
            this.picnhaphinh.Location = new System.Drawing.Point(832, 308);
            this.picnhaphinh.Name = "picnhaphinh";
            this.picnhaphinh.Size = new System.Drawing.Size(100, 104);
            this.picnhaphinh.TabIndex = 11;
            this.picnhaphinh.TabStop = false;
            // 
            // uphinh
            // 
            this.uphinh.Location = new System.Drawing.Point(743, 348);
            this.uphinh.Name = "uphinh";
            this.uphinh.Size = new System.Drawing.Size(67, 23);
            this.uphinh.TabIndex = 24;
            this.uphinh.Text = "UPLOAD";
            this.uphinh.UseVisualStyleBackColor = true;
            this.uphinh.Click += new System.EventHandler(this.uphinh_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(843, 525);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 27;
            this.btnluu.Text = "Save";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(744, 76);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 32);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(832, 76);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 32);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(918, 76);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 32);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // cbtaohang
            // 
            this.cbtaohang.FormattingEnabled = true;
            this.cbtaohang.Location = new System.Drawing.Point(938, 154);
            this.cbtaohang.Name = "cbtaohang";
            this.cbtaohang.Size = new System.Drawing.Size(55, 21);
            this.cbtaohang.TabIndex = 15;
            this.cbtaohang.SelectedIndexChanged += new System.EventHandler(this.cbtaohang_SelectedIndexChanged);
            // 
            // frmhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 560);
            this.Controls.Add(this.cbtaohang);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.uphinh);
            this.Controls.Add(this.picnhaphinh);
            this.Controls.Add(this.btntimhh);
            this.Controls.Add(this.txtnhapmota);
            this.Controls.Add(this.txtnhaphinh);
            this.Controls.Add(this.txtnhapgia);
            this.Controls.Add(this.txtnhaptenhang);
            this.Controls.Add(this.txtnhapmanhom);
            this.Controls.Add(this.txtnhapmaloai);
            this.Controls.Add(this.txtnhapmahang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maloai);
            this.Controls.Add(this.btn_xemmanhom);
            this.Controls.Add(this.cb_loaihang);
            this.Controls.Add(this.btn_xemmaloai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_allhh);
            this.Controls.Add(this.gvdshanghoa);
            this.Name = "frmhanghoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmhanghoa";
            this.Load += new System.EventHandler(this.frmhanghoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvdshanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picnhaphinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvdshanghoa;
        private System.Windows.Forms.Button btn_allhh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xemmaloai;
        private System.Windows.Forms.ComboBox cb_loaihang;
        private System.Windows.Forms.Button btn_xemmanhom;
        private System.Windows.Forms.TextBox txt_maloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnhapmahang;
        private System.Windows.Forms.TextBox txtnhapmaloai;
        private System.Windows.Forms.TextBox txtnhapmanhom;
        private System.Windows.Forms.TextBox txtnhaptenhang;
        private System.Windows.Forms.TextBox txtnhapgia;
        private System.Windows.Forms.TextBox txtnhaphinh;
        private System.Windows.Forms.TextBox txtnhapmota;
        private System.Windows.Forms.Button btntimhh;
        private System.Windows.Forms.PictureBox picnhaphinh;
        private System.Windows.Forms.Button uphinh;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ComboBox cbtaohang;
    }
}