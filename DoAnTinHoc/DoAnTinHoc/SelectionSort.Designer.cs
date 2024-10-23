namespace DoAnTinHoc
{
    partial class SelectionSort
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_SelectionSort = new System.Windows.Forms.Label();
            this.lbl_nhap = new System.Windows.Forms.Label();
            this.lbl_KetQua = new System.Windows.Forms.Label();
            this.txt_nhap = new System.Windows.Forms.TextBox();
            this.txt_bang = new System.Windows.Forms.TextBox();
            this.lbl_buoc = new System.Windows.Forms.Label();
            this.lbx_sapxep = new System.Windows.Forms.ListBox();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.btb_sapxep = new System.Windows.Forms.Button();
            this.btn_file = new System.Windows.Forms.Button();
            this.btb_xoa = new System.Windows.Forms.Button();
            this.txt_DaySo = new System.Windows.Forms.TextBox();
            this.lbl_DaySo = new System.Windows.Forms.Label();
            this.Btn_SapXepGiam = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.LBL_SelectionSort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 80);
            this.panel1.TabIndex = 0;
            // 
            // LBL_SelectionSort
            // 
            this.LBL_SelectionSort.AutoSize = true;
            this.LBL_SelectionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SelectionSort.Location = new System.Drawing.Point(176, 0);
            this.LBL_SelectionSort.Name = "LBL_SelectionSort";
            this.LBL_SelectionSort.Size = new System.Drawing.Size(960, 65);
            this.LBL_SelectionSort.TabIndex = 2;
            this.LBL_SelectionSort.Text = "Thuật Toán Sắp Xếp Selection Sort";
            // 
            // lbl_nhap
            // 
            this.lbl_nhap.AutoSize = true;
            this.lbl_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhap.Location = new System.Drawing.Point(220, 116);
            this.lbl_nhap.Name = "lbl_nhap";
            this.lbl_nhap.Size = new System.Drawing.Size(131, 32);
            this.lbl_nhap.TabIndex = 1;
            this.lbl_nhap.Text = "Nhập Số";
            // 
            // lbl_KetQua
            // 
            this.lbl_KetQua.AutoSize = true;
            this.lbl_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KetQua.Location = new System.Drawing.Point(220, 300);
            this.lbl_KetQua.Name = "lbl_KetQua";
            this.lbl_KetQua.Size = new System.Drawing.Size(125, 32);
            this.lbl_KetQua.TabIndex = 2;
            this.lbl_KetQua.Text = "Kết Quả";
            // 
            // txt_nhap
            // 
            this.txt_nhap.Location = new System.Drawing.Point(376, 116);
            this.txt_nhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nhap.Name = "txt_nhap";
            this.txt_nhap.Size = new System.Drawing.Size(151, 26);
            this.txt_nhap.TabIndex = 3;
            // 
            // txt_bang
            // 
            this.txt_bang.Location = new System.Drawing.Point(366, 308);
            this.txt_bang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_bang.Name = "txt_bang";
            this.txt_bang.ReadOnly = true;
            this.txt_bang.Size = new System.Drawing.Size(444, 26);
            this.txt_bang.TabIndex = 4;
            // 
            // lbl_buoc
            // 
            this.lbl_buoc.AutoSize = true;
            this.lbl_buoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buoc.Location = new System.Drawing.Point(220, 403);
            this.lbl_buoc.Name = "lbl_buoc";
            this.lbl_buoc.Size = new System.Drawing.Size(144, 32);
            this.lbl_buoc.TabIndex = 5;
            this.lbl_buoc.Text = "Các Bước";
            // 
            // lbx_sapxep
            // 
            this.lbx_sapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_sapxep.FormattingEnabled = true;
            this.lbx_sapxep.ItemHeight = 25;
            this.lbx_sapxep.Location = new System.Drawing.Point(376, 403);
            this.lbx_sapxep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbx_sapxep.Name = "lbx_sapxep";
            this.lbx_sapxep.Size = new System.Drawing.Size(473, 254);
            this.lbx_sapxep.TabIndex = 6;
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhap.Location = new System.Drawing.Point(558, 95);
            this.btn_Nhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(110, 49);
            this.btn_Nhap.TabIndex = 7;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // btb_sapxep
            // 
            this.btb_sapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_sapxep.Location = new System.Drawing.Point(720, 95);
            this.btb_sapxep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btb_sapxep.Name = "btb_sapxep";
            this.btb_sapxep.Size = new System.Drawing.Size(247, 49);
            this.btb_sapxep.TabIndex = 11;
            this.btb_sapxep.Text = "Sắp Xếp Tăng Dần";
            this.btb_sapxep.UseVisualStyleBackColor = true;
            this.btb_sapxep.Click += new System.EventHandler(this.btb_sapxep_Click);
            // 
            // btn_file
            // 
            this.btn_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_file.Location = new System.Drawing.Point(558, 162);
            this.btn_file.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(144, 50);
            this.btn_file.TabIndex = 12;
            this.btn_file.Text = "Nhập file";
            this.btn_file.UseVisualStyleBackColor = true;
            // 
            // btb_xoa
            // 
            this.btb_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_xoa.Location = new System.Drawing.Point(848, 288);
            this.btb_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btb_xoa.Name = "btb_xoa";
            this.btb_xoa.Size = new System.Drawing.Size(158, 48);
            this.btb_xoa.TabIndex = 13;
            this.btb_xoa.Text = "Xóa Kết Quả";
            this.btb_xoa.UseVisualStyleBackColor = true;
            this.btb_xoa.Click += new System.EventHandler(this.btb_xoa_Click);
            // 
            // txt_DaySo
            // 
            this.txt_DaySo.Location = new System.Drawing.Point(366, 261);
            this.txt_DaySo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DaySo.Name = "txt_DaySo";
            this.txt_DaySo.ReadOnly = true;
            this.txt_DaySo.Size = new System.Drawing.Size(440, 26);
            this.txt_DaySo.TabIndex = 14;
            // 
            // lbl_DaySo
            // 
            this.lbl_DaySo.AutoSize = true;
            this.lbl_DaySo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DaySo.Location = new System.Drawing.Point(159, 257);
            this.lbl_DaySo.Name = "lbl_DaySo";
            this.lbl_DaySo.Size = new System.Drawing.Size(201, 29);
            this.lbl_DaySo.TabIndex = 15;
            this.lbl_DaySo.Text = "Dãy Số Ban Đầu";
            // 
            // Btn_SapXepGiam
            // 
            this.Btn_SapXepGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SapXepGiam.Location = new System.Drawing.Point(720, 163);
            this.Btn_SapXepGiam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_SapXepGiam.Name = "Btn_SapXepGiam";
            this.Btn_SapXepGiam.Size = new System.Drawing.Size(247, 49);
            this.Btn_SapXepGiam.TabIndex = 16;
            this.Btn_SapXepGiam.Text = "Sắp Xếp Giảm Dần";
            this.Btn_SapXepGiam.UseVisualStyleBackColor = true;
            this.Btn_SapXepGiam.Click += new System.EventHandler(this.Btn_SapXepGiam_Click);
            // 
            // SelectionSort
            // 
            this.AcceptButton = this.btn_Nhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1248, 711);
            this.Controls.Add(this.Btn_SapXepGiam);
            this.Controls.Add(this.lbl_DaySo);
            this.Controls.Add(this.txt_DaySo);
            this.Controls.Add(this.btb_xoa);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.btb_sapxep);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.lbx_sapxep);
            this.Controls.Add(this.lbl_buoc);
            this.Controls.Add(this.txt_bang);
            this.Controls.Add(this.txt_nhap);
            this.Controls.Add(this.lbl_KetQua);
            this.Controls.Add(this.lbl_nhap);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectionSort";
            this.Text = "SelectionSort";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_SelectionSort;
        private System.Windows.Forms.Label lbl_nhap;
        private System.Windows.Forms.Label lbl_KetQua;
        private System.Windows.Forms.TextBox txt_nhap;
        private System.Windows.Forms.TextBox txt_bang;
        private System.Windows.Forms.Label lbl_buoc;
        private System.Windows.Forms.ListBox lbx_sapxep;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.Button btb_sapxep;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Button btb_xoa;
        private System.Windows.Forms.TextBox txt_DaySo;
        private System.Windows.Forms.Label lbl_DaySo;
        private System.Windows.Forms.Button Btn_SapXepGiam;
    }
}