namespace QuanLy
{
    partial class frmmain
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
            this.pntieude = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btndonhang = new System.Windows.Forms.Button();
            this.btnhanghoa = new System.Windows.Forms.Button();
            this.btndanhmuc = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnloadform = new System.Windows.Forms.Panel();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.pntieude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pntieude
            // 
            this.pntieude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pntieude.Controls.Add(this.label1);
            this.pntieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.pntieude.Location = new System.Drawing.Point(0, 0);
            this.pntieude.Name = "pntieude";
            this.pntieude.Size = new System.Drawing.Size(1230, 216);
            this.pntieude.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1230, 216);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HÀNG HÓA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 216);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btndangxuat);
            this.splitContainer1.Panel1.Controls.Add(this.btndonhang);
            this.splitContainer1.Panel1.Controls.Add(this.btnhanghoa);
            this.splitContainer1.Panel1.Controls.Add(this.btndanhmuc);
            this.splitContainer1.Panel1.Controls.Add(this.btnnhanvien);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnloadform);
            this.splitContainer1.Size = new System.Drawing.Size(1230, 583);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 3;
            // 
            // btndonhang
            // 
            this.btndonhang.Location = new System.Drawing.Point(67, 263);
            this.btndonhang.Name = "btndonhang";
            this.btndonhang.Size = new System.Drawing.Size(79, 40);
            this.btndonhang.TabIndex = 3;
            this.btndonhang.Text = "Đơn hàng";
            this.btndonhang.UseVisualStyleBackColor = true;
            this.btndonhang.Click += new System.EventHandler(this.btndonhang_Click);
            // 
            // btnhanghoa
            // 
            this.btnhanghoa.Location = new System.Drawing.Point(67, 193);
            this.btnhanghoa.Name = "btnhanghoa";
            this.btnhanghoa.Size = new System.Drawing.Size(79, 40);
            this.btnhanghoa.TabIndex = 2;
            this.btnhanghoa.Text = "Hàng hóa";
            this.btnhanghoa.UseVisualStyleBackColor = true;
            this.btnhanghoa.Click += new System.EventHandler(this.btnhanghoa_Click);
            // 
            // btndanhmuc
            // 
            this.btndanhmuc.Location = new System.Drawing.Point(67, 126);
            this.btndanhmuc.Name = "btndanhmuc";
            this.btndanhmuc.Size = new System.Drawing.Size(79, 40);
            this.btndanhmuc.TabIndex = 1;
            this.btndanhmuc.Text = "Danh mục";
            this.btndanhmuc.UseVisualStyleBackColor = true;
            this.btndanhmuc.Click += new System.EventHandler(this.btndanhmuc_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Location = new System.Drawing.Point(67, 66);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(79, 39);
            this.btnnhanvien.TabIndex = 0;
            this.btnnhanvien.Text = "Nhân viên";
            this.btnnhanvien.UseVisualStyleBackColor = true;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "MENU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnloadform
            // 
            this.pnloadform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnloadform.Location = new System.Drawing.Point(0, 0);
            this.pnloadform.Name = "pnloadform";
            this.pnloadform.Size = new System.Drawing.Size(996, 583);
            this.pnloadform.TabIndex = 0;
            // 
            // btndangxuat
            // 
            this.btndangxuat.Location = new System.Drawing.Point(67, 331);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(79, 40);
            this.btndangxuat.TabIndex = 4;
            this.btndangxuat.Text = "Đăng xuất";
            this.btndangxuat.UseVisualStyleBackColor = true;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 799);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pntieude);
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmain";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.pntieude.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pntieude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnloadform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndonhang;
        private System.Windows.Forms.Button btnhanghoa;
        private System.Windows.Forms.Button btndanhmuc;
        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Button btndangxuat;
    }
}