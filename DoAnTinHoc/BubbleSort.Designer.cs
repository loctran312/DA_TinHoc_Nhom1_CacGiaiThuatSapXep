namespace DoAnTinHoc
{
    partial class BubbleSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BubbleSort));
            this.Txt_Nhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Nhap = new System.Windows.Forms.Button();
            this.btnTapTin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Bang = new System.Windows.Forms.TextBox();
            this.Btn_SapXep = new System.Windows.Forms.Button();
            this.Lbx_SapXep = new System.Windows.Forms.ListBox();
            this.Lbl_KetQua = new System.Windows.Forms.Label();
            this.Lbl_BuocLam = new System.Windows.Forms.Label();
            this.Btn_xoa = new System.Windows.Forms.Button();
            this.txt_DaySo = new System.Windows.Forms.TextBox();
            this.lbl_DaySo = new System.Windows.Forms.Label();
            this.Btn_SapXepGiam = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.Lbl_sua = new System.Windows.Forms.Label();
            this.txt_Sua = new System.Windows.Forms.TextBox();
            this.BtnSua = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Nhap
            // 
            this.Txt_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nhap.Location = new System.Drawing.Point(405, 128);
            this.Txt_Nhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nhap.Name = "Txt_Nhap";
            this.Txt_Nhap.Size = new System.Drawing.Size(183, 30);
            this.Txt_Nhap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số";
            // 
            // Btn_Nhap
            // 
            this.Btn_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nhap.Location = new System.Drawing.Point(620, 122);
            this.Btn_Nhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Nhap.Name = "Btn_Nhap";
            this.Btn_Nhap.Size = new System.Drawing.Size(86, 35);
            this.Btn_Nhap.TabIndex = 2;
            this.Btn_Nhap.Text = "Nhập";
            this.Btn_Nhap.UseVisualStyleBackColor = true;
            this.Btn_Nhap.Click += new System.EventHandler(this.Btn_Nhap_Click);
            // 
            // btnTapTin
            // 
            this.btnTapTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTapTin.Location = new System.Drawing.Point(620, 186);
            this.btnTapTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTapTin.Name = "btnTapTin";
            this.btnTapTin.Size = new System.Drawing.Size(120, 35);
            this.btnTapTin.TabIndex = 3;
            this.btnTapTin.Text = "Tập Tin";
            this.btnTapTin.UseVisualStyleBackColor = true;
            this.btnTapTin.Click += new System.EventHandler(this.btnTapTin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 72);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(762, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thuật Toán Sắp Xếp Bubble Sort";
            // 
            // Txt_Bang
            // 
            this.Txt_Bang.Location = new System.Drawing.Point(404, 322);
            this.Txt_Bang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Bang.Name = "Txt_Bang";
            this.Txt_Bang.ReadOnly = true;
            this.Txt_Bang.Size = new System.Drawing.Size(440, 26);
            this.Txt_Bang.TabIndex = 6;
            // 
            // Btn_SapXep
            // 
            this.Btn_SapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SapXep.Location = new System.Drawing.Point(862, 122);
            this.Btn_SapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_SapXep.Name = "Btn_SapXep";
            this.Btn_SapXep.Size = new System.Drawing.Size(259, 35);
            this.Btn_SapXep.TabIndex = 7;
            this.Btn_SapXep.Text = "Sắp Xếp Tăng Dần";
            this.Btn_SapXep.UseVisualStyleBackColor = true;
            this.Btn_SapXep.Click += new System.EventHandler(this.Btn_SapXep_Click);
            // 
            // Lbx_SapXep
            // 
            this.Lbx_SapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbx_SapXep.FormattingEnabled = true;
            this.Lbx_SapXep.ItemHeight = 29;
            this.Lbx_SapXep.Location = new System.Drawing.Point(405, 412);
            this.Lbx_SapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lbx_SapXep.Name = "Lbx_SapXep";
            this.Lbx_SapXep.Size = new System.Drawing.Size(439, 236);
            this.Lbx_SapXep.TabIndex = 8;
            // 
            // Lbl_KetQua
            // 
            this.Lbl_KetQua.AutoSize = true;
            this.Lbl_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_KetQua.Location = new System.Drawing.Point(132, 318);
            this.Lbl_KetQua.Name = "Lbl_KetQua";
            this.Lbl_KetQua.Size = new System.Drawing.Size(102, 29);
            this.Lbl_KetQua.TabIndex = 9;
            this.Lbl_KetQua.Text = "Kết quả";
            // 
            // Lbl_BuocLam
            // 
            this.Lbl_BuocLam.AutoSize = true;
            this.Lbl_BuocLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BuocLam.Location = new System.Drawing.Point(132, 412);
            this.Lbl_BuocLam.Name = "Lbl_BuocLam";
            this.Lbl_BuocLam.Size = new System.Drawing.Size(122, 29);
            this.Lbl_BuocLam.TabIndex = 10;
            this.Lbl_BuocLam.Text = "Các bước";
            // 
            // Btn_xoa
            // 
            this.Btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_xoa.Location = new System.Drawing.Point(879, 311);
            this.Btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_xoa.Name = "Btn_xoa";
            this.Btn_xoa.Size = new System.Drawing.Size(180, 42);
            this.Btn_xoa.TabIndex = 11;
            this.Btn_xoa.Text = "Xóa Kết Quả";
            this.Btn_xoa.UseVisualStyleBackColor = true;
            this.Btn_xoa.Click += new System.EventHandler(this.Btn_xoa_Click);
            // 
            // txt_DaySo
            // 
            this.txt_DaySo.Location = new System.Drawing.Point(404, 267);
            this.txt_DaySo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DaySo.Name = "txt_DaySo";
            this.txt_DaySo.ReadOnly = true;
            this.txt_DaySo.Size = new System.Drawing.Size(440, 26);
            this.txt_DaySo.TabIndex = 12;
            // 
            // lbl_DaySo
            // 
            this.lbl_DaySo.AutoSize = true;
            this.lbl_DaySo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DaySo.Location = new System.Drawing.Point(132, 267);
            this.lbl_DaySo.Name = "lbl_DaySo";
            this.lbl_DaySo.Size = new System.Drawing.Size(201, 29);
            this.lbl_DaySo.TabIndex = 13;
            this.lbl_DaySo.Text = "Dãy Số Ban Đầu";
            // 
            // Btn_SapXepGiam
            // 
            this.Btn_SapXepGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SapXepGiam.Location = new System.Drawing.Point(862, 175);
            this.Btn_SapXepGiam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_SapXepGiam.Name = "Btn_SapXepGiam";
            this.Btn_SapXepGiam.Size = new System.Drawing.Size(259, 35);
            this.Btn_SapXepGiam.TabIndex = 14;
            this.Btn_SapXepGiam.Text = "Sắp Xếp Giảm Dần";
            this.Btn_SapXepGiam.UseVisualStyleBackColor = true;
            this.Btn_SapXepGiam.Click += new System.EventHandler(this.Btn_SapXepGiam_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // Lbl_sua
            // 
            this.Lbl_sua.AutoSize = true;
            this.Lbl_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sua.Location = new System.Drawing.Point(132, 192);
            this.Lbl_sua.Name = "Lbl_sua";
            this.Lbl_sua.Size = new System.Drawing.Size(267, 29);
            this.Lbl_sua.TabIndex = 20;
            this.Lbl_sua.Text = "Nhập Giá Trị Cần Sửa";
            this.Lbl_sua.Visible = false;
            // 
            // txt_Sua
            // 
            this.txt_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sua.Location = new System.Drawing.Point(405, 192);
            this.txt_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Sua.Name = "txt_Sua";
            this.txt_Sua.Size = new System.Drawing.Size(183, 30);
            this.txt_Sua.TabIndex = 21;
            this.txt_Sua.Visible = false;
            // 
            // BtnSua
            // 
            this.BtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.Location = new System.Drawing.Point(741, 123);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(115, 35);
            this.BtnSua.TabIndex = 22;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Visible = false;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(62, 33);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // BubbleSort
            // 
            this.AcceptButton = this.Btn_Nhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1248, 711);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.txt_Sua);
            this.Controls.Add(this.Lbl_sua);
            this.Controls.Add(this.Btn_SapXepGiam);
            this.Controls.Add(this.lbl_DaySo);
            this.Controls.Add(this.txt_DaySo);
            this.Controls.Add(this.Btn_xoa);
            this.Controls.Add(this.Lbl_BuocLam);
            this.Controls.Add(this.Lbl_KetQua);
            this.Controls.Add(this.Lbx_SapXep);
            this.Controls.Add(this.Btn_SapXep);
            this.Controls.Add(this.Txt_Bang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTapTin);
            this.Controls.Add(this.Btn_Nhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Nhap);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BubbleSort";
            this.Text = "BubbleSort";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Nhap;
        private System.Windows.Forms.Button btnTapTin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Bang;
        private System.Windows.Forms.Button Btn_SapXep;
        private System.Windows.Forms.ListBox Lbx_SapXep;
        private System.Windows.Forms.Label Lbl_KetQua;
        private System.Windows.Forms.Label Lbl_BuocLam;
        private System.Windows.Forms.Button Btn_xoa;
        private System.Windows.Forms.TextBox txt_DaySo;
        private System.Windows.Forms.Label lbl_DaySo;
        private System.Windows.Forms.Button Btn_SapXepGiam;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Label Lbl_sua;
        private System.Windows.Forms.TextBox txt_Sua;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}