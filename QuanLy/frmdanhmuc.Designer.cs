namespace QuanLy
{
    partial class frmdanhmuc
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
            this.gvnhomhang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ALLnhomhang = new System.Windows.Forms.Button();
            this.cb_maloainhomhang = new System.Windows.Forms.ComboBox();
            this.btn_maloainhomhang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.txtmanhom = new System.Windows.Forms.TextBox();
            this.txttennhom = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.cbnhapmaloai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvnhomhang)).BeginInit();
            this.SuspendLayout();
            // 
            // gvnhomhang
            // 
            this.gvnhomhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvnhomhang.Location = new System.Drawing.Point(92, 156);
            this.gvnhomhang.Name = "gvnhomhang";
            this.gvnhomhang.ReadOnly = true;
            this.gvnhomhang.Size = new System.Drawing.Size(357, 235);
            this.gvnhomhang.TabIndex = 0;
            this.gvnhomhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvnhomhang_CellClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhóm hàng";
            // 
            // btn_ALLnhomhang
            // 
            this.btn_ALLnhomhang.Location = new System.Drawing.Point(106, 115);
            this.btn_ALLnhomhang.Name = "btn_ALLnhomhang";
            this.btn_ALLnhomhang.Size = new System.Drawing.Size(75, 35);
            this.btn_ALLnhomhang.TabIndex = 3;
            this.btn_ALLnhomhang.Text = "ALL";
            this.btn_ALLnhomhang.UseVisualStyleBackColor = true;
            this.btn_ALLnhomhang.Click += new System.EventHandler(this.btn_ALLnhomhang_Click);
            // 
            // cb_maloainhomhang
            // 
            this.cb_maloainhomhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_maloainhomhang.FormattingEnabled = true;
            this.cb_maloainhomhang.Location = new System.Drawing.Point(274, 115);
            this.cb_maloainhomhang.Name = "cb_maloainhomhang";
            this.cb_maloainhomhang.Size = new System.Drawing.Size(89, 28);
            this.cb_maloainhomhang.TabIndex = 4;
            // 
            // btn_maloainhomhang
            // 
            this.btn_maloainhomhang.Location = new System.Drawing.Point(374, 114);
            this.btn_maloainhomhang.Name = "btn_maloainhomhang";
            this.btn_maloainhomhang.Size = new System.Drawing.Size(75, 29);
            this.btn_maloainhomhang.TabIndex = 5;
            this.btn_maloainhomhang.Text = "Xem";
            this.btn_maloainhomhang.UseVisualStyleBackColor = true;
            this.btn_maloainhomhang.Click += new System.EventHandler(this.btn_maloainhomhang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã nhóm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên nhóm";
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(560, 183);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(100, 20);
            this.txtmaloai.TabIndex = 12;
            // 
            // txtmanhom
            // 
            this.txtmanhom.Location = new System.Drawing.Point(560, 234);
            this.txtmanhom.Name = "txtmanhom";
            this.txtmanhom.Size = new System.Drawing.Size(100, 20);
            this.txtmanhom.TabIndex = 12;
            this.txtmanhom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmanhom_KeyPress);
            // 
            // txttennhom
            // 
            this.txttennhom.Location = new System.Drawing.Point(560, 289);
            this.txttennhom.Name = "txttennhom";
            this.txttennhom.Size = new System.Drawing.Size(100, 20);
            this.txttennhom.TabIndex = 12;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(479, 112);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 32);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(572, 112);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 32);
            this.btnsua.TabIndex = 16;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(666, 111);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 32);
            this.btnxoa.TabIndex = 17;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(572, 335);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 33);
            this.btnluu.TabIndex = 18;
            this.btnluu.Text = "Save";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // cbnhapmaloai
            // 
            this.cbnhapmaloai.FormattingEnabled = true;
            this.cbnhapmaloai.Location = new System.Drawing.Point(666, 182);
            this.cbnhapmaloai.Name = "cbnhapmaloai";
            this.cbnhapmaloai.Size = new System.Drawing.Size(75, 21);
            this.cbnhapmaloai.TabIndex = 19;
            this.cbnhapmaloai.SelectedIndexChanged += new System.EventHandler(this.cbnhapmaloai_SelectedIndexChanged);
            // 
            // frmdanhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 453);
            this.Controls.Add(this.cbnhapmaloai);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttennhom);
            this.Controls.Add(this.txtmanhom);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_maloainhomhang);
            this.Controls.Add(this.cb_maloainhomhang);
            this.Controls.Add(this.btn_ALLnhomhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvnhomhang);
            this.Name = "frmdanhmuc";
            this.Text = "frmdanhmuc";
            this.Load += new System.EventHandler(this.frmdanhmuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvnhomhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvnhomhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ALLnhomhang;
        private System.Windows.Forms.ComboBox cb_maloainhomhang;
        private System.Windows.Forms.Button btn_maloainhomhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.TextBox txtmanhom;
        private System.Windows.Forms.TextBox txttennhom;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.ComboBox cbnhapmaloai;
    }
}