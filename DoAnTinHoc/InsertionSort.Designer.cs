namespace DoAnTinHoc
{
    partial class InsertionSort
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Btn_SapXepGiam = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_Sua = new System.Windows.Forms.TextBox();
            this.Lbl_sua = new System.Windows.Forms.Label();
            this.BtnSua = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.LBL_SelectionSort);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 64);
            this.panel1.TabIndex = 17;
            // 
            // LBL_SelectionSort
            // 
            this.LBL_SelectionSort.AutoSize = true;
            this.LBL_SelectionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SelectionSort.Location = new System.Drawing.Point(156, 0);
            this.LBL_SelectionSort.Name = "LBL_SelectionSort";
            this.LBL_SelectionSort.Size = new System.Drawing.Size(775, 54);
            this.LBL_SelectionSort.TabIndex = 2;
            this.LBL_SelectionSort.Text = "Thuật Toán Sắp Xếp Insertion Sort";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(204, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // lbl_DaySo
            // 
            this.lbl_DaySo.AutoSize = true;
            this.lbl_DaySo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DaySo.Location = new System.Drawing.Point(85, 220);
            this.lbl_DaySo.Name = "lbl_DaySo";
            this.lbl_DaySo.Size = new System.Drawing.Size(172, 25);
            this.lbl_DaySo.TabIndex = 29;
            this.lbl_DaySo.Text = "Dãy Số Ban Đầu";
            // 
            // txt_DaySo
            // 
            this.txt_DaySo.Location = new System.Drawing.Point(325, 224);
            this.txt_DaySo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DaySo.Name = "txt_DaySo";
            this.txt_DaySo.ReadOnly = true;
            this.txt_DaySo.Size = new System.Drawing.Size(392, 22);
            this.txt_DaySo.TabIndex = 28;
            // 
            // btb_xoa
            // 
            this.btb_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_xoa.Location = new System.Drawing.Point(754, 245);
            this.btb_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btb_xoa.Name = "btb_xoa";
            this.btb_xoa.Size = new System.Drawing.Size(140, 38);
            this.btb_xoa.TabIndex = 27;
            this.btb_xoa.Text = "Xóa Kết Quả";
            this.btb_xoa.UseVisualStyleBackColor = true;
            this.btb_xoa.Click += new System.EventHandler(this.btb_xoa_Click);
            // 
            // btn_file
            // 
            this.btn_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_file.Location = new System.Drawing.Point(496, 144);
            this.btn_file.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(128, 39);
            this.btn_file.TabIndex = 26;
            this.btn_file.Text = "Nhập file";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // btb_sapxep
            // 
            this.btb_sapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_sapxep.Location = new System.Drawing.Point(732, 90);
            this.btb_sapxep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btb_sapxep.Name = "btb_sapxep";
            this.btb_sapxep.Size = new System.Drawing.Size(220, 39);
            this.btb_sapxep.TabIndex = 25;
            this.btb_sapxep.Text = "Sắp Xếp Tăng Dần";
            this.btb_sapxep.UseVisualStyleBackColor = true;
            this.btb_sapxep.Click += new System.EventHandler(this.btb_sapxep_Click);
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhap.Location = new System.Drawing.Point(496, 91);
            this.btn_Nhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(98, 39);
            this.btn_Nhap.TabIndex = 24;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // lbx_sapxep
            // 
            this.lbx_sapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_sapxep.FormattingEnabled = true;
            this.lbx_sapxep.ItemHeight = 20;
            this.lbx_sapxep.Location = new System.Drawing.Point(334, 338);
            this.lbx_sapxep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbx_sapxep.Name = "lbx_sapxep";
            this.lbx_sapxep.Size = new System.Drawing.Size(422, 184);
            this.lbx_sapxep.TabIndex = 23;
            // 
            // lbl_buoc
            // 
            this.lbl_buoc.AutoSize = true;
            this.lbl_buoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buoc.Location = new System.Drawing.Point(85, 338);
            this.lbl_buoc.Name = "lbl_buoc";
            this.lbl_buoc.Size = new System.Drawing.Size(124, 29);
            this.lbl_buoc.TabIndex = 22;
            this.lbl_buoc.Text = "Các Bước";
            // 
            // txt_bang
            // 
            this.txt_bang.Location = new System.Drawing.Point(325, 261);
            this.txt_bang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_bang.Name = "txt_bang";
            this.txt_bang.ReadOnly = true;
            this.txt_bang.Size = new System.Drawing.Size(395, 22);
            this.txt_bang.TabIndex = 21;
            // 
            // txt_nhap
            // 
            this.txt_nhap.Location = new System.Drawing.Point(334, 107);
            this.txt_nhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nhap.Name = "txt_nhap";
            this.txt_nhap.Size = new System.Drawing.Size(135, 22);
            this.txt_nhap.TabIndex = 20;
            // 
            // lbl_KetQua
            // 
            this.lbl_KetQua.AutoSize = true;
            this.lbl_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KetQua.Location = new System.Drawing.Point(85, 254);
            this.lbl_KetQua.Name = "lbl_KetQua";
            this.lbl_KetQua.Size = new System.Drawing.Size(107, 29);
            this.lbl_KetQua.TabIndex = 19;
            this.lbl_KetQua.Text = "Kết Quả";
            // 
            // lbl_nhap
            // 
            this.lbl_nhap.AutoSize = true;
            this.lbl_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhap.Location = new System.Drawing.Point(85, 107);
            this.lbl_nhap.Name = "lbl_nhap";
            this.lbl_nhap.Size = new System.Drawing.Size(114, 29);
            this.lbl_nhap.TabIndex = 18;
            this.lbl_nhap.Text = "Nhập Số";
            // 
            // Btn_SapXepGiam
            // 
            this.Btn_SapXepGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SapXepGiam.Location = new System.Drawing.Point(732, 137);
            this.Btn_SapXepGiam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_SapXepGiam.Name = "Btn_SapXepGiam";
            this.Btn_SapXepGiam.Size = new System.Drawing.Size(220, 39);
            this.Btn_SapXepGiam.TabIndex = 17;
            this.Btn_SapXepGiam.Text = "Sắp Xếp Giảm Dần";
            this.Btn_SapXepGiam.UseVisualStyleBackColor = true;
            this.Btn_SapXepGiam.Click += new System.EventHandler(this.Btn_SapXepGiam_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // txt_Sua
            // 
            this.txt_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sua.Location = new System.Drawing.Point(333, 158);
            this.txt_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Sua.Name = "txt_Sua";
            this.txt_Sua.Size = new System.Drawing.Size(135, 26);
            this.txt_Sua.TabIndex = 44;
            this.txt_Sua.Visible = false;
            // 
            // Lbl_sua
            // 
            this.Lbl_sua.AutoSize = true;
            this.Lbl_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sua.Location = new System.Drawing.Point(85, 158);
            this.Lbl_sua.Name = "Lbl_sua";
            this.Lbl_sua.Size = new System.Drawing.Size(225, 25);
            this.Lbl_sua.TabIndex = 43;
            this.Lbl_sua.Text = "Nhập Giá Trị Cần Sửa";
            this.Lbl_sua.Visible = false;
            // 
            // BtnSua
            // 
            this.BtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.Location = new System.Drawing.Point(615, 101);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(102, 28);
            this.BtnSua.TabIndex = 45;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Visible = false;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // InsertionSort
            // 
            this.AcceptButton = this.btn_Nhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.txt_Sua);
            this.Controls.Add(this.Lbl_sua);
            this.Controls.Add(this.Btn_SapXepGiam);
            this.Controls.Add(this.panel1);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InsertionSort";
            this.Text = "InsertionSort";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_SelectionSort;
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
        private System.Windows.Forms.Button Btn_SapXepGiam;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Sua;
        private System.Windows.Forms.Label Lbl_sua;
        private System.Windows.Forms.Button BtnSua;
    }
}