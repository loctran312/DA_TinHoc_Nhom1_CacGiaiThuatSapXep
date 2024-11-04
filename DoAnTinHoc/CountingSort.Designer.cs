namespace DoAnTinHoc
{
    partial class CountingSort
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
            this.Btn_SapXepGiam = new System.Windows.Forms.Button();
            this.lbl_DaySo = new System.Windows.Forms.Label();
            this.txt_DaySo = new System.Windows.Forms.TextBox();
            this.btb_xoa = new System.Windows.Forms.Button();
            this.btn_file = new System.Windows.Forms.Button();
            this.btb_sapxep = new System.Windows.Forms.Button();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.lbx_sapxep = new System.Windows.Forms.ListBox();
            this.lbl_buoc = new System.Windows.Forms.Label();
            this.txt_bang = new System.Windows.Forms.TextBox();
            this.txt_nhap = new System.Windows.Forms.TextBox();
            this.lbl_KetQua = new System.Windows.Forms.Label();
            this.lbl_nhap = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.LBL_SelectionSort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 30;
            // 
            // LBL_SelectionSort
            // 
            this.LBL_SelectionSort.AutoSize = true;
            this.LBL_SelectionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SelectionSort.Location = new System.Drawing.Point(176, 0);
            this.LBL_SelectionSort.Name = "LBL_SelectionSort";
            this.LBL_SelectionSort.Size = new System.Drawing.Size(919, 65);
            this.LBL_SelectionSort.TabIndex = 2;
            this.LBL_SelectionSort.Text = "Thuật Toán Sắp Xếp Couting Sort";
            // 
            // Btn_SapXepGiam
            // 
            this.Btn_SapXepGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SapXepGiam.Location = new System.Drawing.Point(720, 189);
            this.Btn_SapXepGiam.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_SapXepGiam.Name = "Btn_SapXepGiam";
            this.Btn_SapXepGiam.Size = new System.Drawing.Size(248, 49);
            this.Btn_SapXepGiam.TabIndex = 31;
            this.Btn_SapXepGiam.Text = "Sắp Xếp Giảm Dần";
            this.Btn_SapXepGiam.UseVisualStyleBackColor = true;
            this.Btn_SapXepGiam.Click += new System.EventHandler(this.Btn_SapXepGiam_Click);
            // 
            // lbl_DaySo
            // 
            this.lbl_DaySo.AutoSize = true;
            this.lbl_DaySo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DaySo.Location = new System.Drawing.Point(159, 285);
            this.lbl_DaySo.Name = "lbl_DaySo";
            this.lbl_DaySo.Size = new System.Drawing.Size(201, 29);
            this.lbl_DaySo.TabIndex = 43;
            this.lbl_DaySo.Text = "Dãy Số Ban Đầu";
            // 
            // txt_DaySo
            // 
            this.txt_DaySo.Location = new System.Drawing.Point(366, 289);
            this.txt_DaySo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DaySo.Name = "txt_DaySo";
            this.txt_DaySo.ReadOnly = true;
            this.txt_DaySo.Size = new System.Drawing.Size(440, 26);
            this.txt_DaySo.TabIndex = 42;
            // 
            // btb_xoa
            // 
            this.btb_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_xoa.Location = new System.Drawing.Point(848, 315);
            this.btb_xoa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btb_xoa.Name = "btb_xoa";
            this.btb_xoa.Size = new System.Drawing.Size(158, 48);
            this.btb_xoa.TabIndex = 41;
            this.btb_xoa.Text = "Xóa Kết Quả";
            this.btb_xoa.UseVisualStyleBackColor = true;
            this.btb_xoa.Click += new System.EventHandler(this.btb_xoa_Click);
            // 
            // btn_file
            // 
            this.btn_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_file.Location = new System.Drawing.Point(558, 189);
            this.btn_file.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(144, 49);
            this.btn_file.TabIndex = 40;
            this.btn_file.Text = "Nhập file";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // btb_sapxep
            // 
            this.btb_sapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_sapxep.Location = new System.Drawing.Point(720, 123);
            this.btb_sapxep.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btb_sapxep.Name = "btb_sapxep";
            this.btb_sapxep.Size = new System.Drawing.Size(248, 49);
            this.btb_sapxep.TabIndex = 39;
            this.btb_sapxep.Text = "Sắp Xếp Tăng Dần";
            this.btb_sapxep.UseVisualStyleBackColor = true;
            this.btb_sapxep.Click += new System.EventHandler(this.btb_sapxep_Click);
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhap.Location = new System.Drawing.Point(558, 123);
            this.btn_Nhap.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(110, 49);
            this.btn_Nhap.TabIndex = 38;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // lbx_sapxep
            // 
            this.lbx_sapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_sapxep.FormattingEnabled = true;
            this.lbx_sapxep.ItemHeight = 25;
            this.lbx_sapxep.Location = new System.Drawing.Point(376, 431);
            this.lbx_sapxep.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbx_sapxep.Name = "lbx_sapxep";
            this.lbx_sapxep.Size = new System.Drawing.Size(474, 229);
            this.lbx_sapxep.TabIndex = 37;
            // 
            // lbl_buoc
            // 
            this.lbl_buoc.AutoSize = true;
            this.lbl_buoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buoc.Location = new System.Drawing.Point(220, 431);
            this.lbl_buoc.Name = "lbl_buoc";
            this.lbl_buoc.Size = new System.Drawing.Size(144, 32);
            this.lbl_buoc.TabIndex = 36;
            this.lbl_buoc.Text = "Các Bước";
            // 
            // txt_bang
            // 
            this.txt_bang.Location = new System.Drawing.Point(366, 335);
            this.txt_bang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_bang.Name = "txt_bang";
            this.txt_bang.ReadOnly = true;
            this.txt_bang.Size = new System.Drawing.Size(444, 26);
            this.txt_bang.TabIndex = 35;
            // 
            // txt_nhap
            // 
            this.txt_nhap.Location = new System.Drawing.Point(376, 143);
            this.txt_nhap.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_nhap.Name = "txt_nhap";
            this.txt_nhap.Size = new System.Drawing.Size(151, 26);
            this.txt_nhap.TabIndex = 34;
            // 
            // lbl_KetQua
            // 
            this.lbl_KetQua.AutoSize = true;
            this.lbl_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KetQua.Location = new System.Drawing.Point(220, 328);
            this.lbl_KetQua.Name = "lbl_KetQua";
            this.lbl_KetQua.Size = new System.Drawing.Size(125, 32);
            this.lbl_KetQua.TabIndex = 33;
            this.lbl_KetQua.Text = "Kết Quả";
            // 
            // lbl_nhap
            // 
            this.lbl_nhap.AutoSize = true;
            this.lbl_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhap.Location = new System.Drawing.Point(220, 143);
            this.lbl_nhap.Name = "lbl_nhap";
            this.lbl_nhap.Size = new System.Drawing.Size(131, 32);
            this.lbl_nhap.TabIndex = 32;
            this.lbl_nhap.Text = "Nhập Số";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // CountingSort
            // 
            this.AcceptButton = this.btn_Nhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CountingSort";
            this.Text = "CoutingSort";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_SelectionSort;
        private System.Windows.Forms.Button Btn_SapXepGiam;
        private System.Windows.Forms.Label lbl_DaySo;
        private System.Windows.Forms.TextBox txt_DaySo;
        private System.Windows.Forms.Button btb_xoa;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Button btb_sapxep;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.ListBox lbx_sapxep;
        private System.Windows.Forms.Label lbl_buoc;
        private System.Windows.Forms.TextBox txt_bang;
        private System.Windows.Forms.TextBox txt_nhap;
        private System.Windows.Forms.Label lbl_KetQua;
        private System.Windows.Forms.Label lbl_nhap;
        private System.Windows.Forms.OpenFileDialog ofd1;
    }
}