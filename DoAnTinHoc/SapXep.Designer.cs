namespace DoAnTinHoc
{
    partial class SapXep
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTapTin = new System.Windows.Forms.Button();
            this.lbxSapXep = new System.Windows.Forms.ListBox();
            this.Lbl_BuocLam = new System.Windows.Forms.Label();
            this.txtBanDau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSortAsc = new System.Windows.Forms.Button();
            this.btnSortDesc = new System.Windows.Forms.Button();
            this.cbbGiaiThuat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập số";
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(291, 49);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(610, 30);
            this.txtNhap.TabIndex = 3;
            this.txtNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhap_KeyPress);
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(907, 46);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(135, 51);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnTapTin
            // 
            this.btnTapTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTapTin.Location = new System.Drawing.Point(907, 118);
            this.btnTapTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTapTin.Name = "btnTapTin";
            this.btnTapTin.Size = new System.Drawing.Size(135, 51);
            this.btnTapTin.TabIndex = 5;
            this.btnTapTin.Text = "Tập Tin";
            this.btnTapTin.UseVisualStyleBackColor = true;
            this.btnTapTin.Click += new System.EventHandler(this.btnTapTin_Click);
            // 
            // lbxSapXep
            // 
            this.lbxSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSapXep.FormattingEnabled = true;
            this.lbxSapXep.ItemHeight = 29;
            this.lbxSapXep.Location = new System.Drawing.Point(166, 308);
            this.lbxSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxSapXep.Name = "lbxSapXep";
            this.lbxSapXep.Size = new System.Drawing.Size(1181, 236);
            this.lbxSapXep.TabIndex = 9;
            // 
            // Lbl_BuocLam
            // 
            this.Lbl_BuocLam.AutoSize = true;
            this.Lbl_BuocLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BuocLam.Location = new System.Drawing.Point(38, 308);
            this.Lbl_BuocLam.Name = "Lbl_BuocLam";
            this.Lbl_BuocLam.Size = new System.Drawing.Size(122, 29);
            this.Lbl_BuocLam.TabIndex = 11;
            this.Lbl_BuocLam.Text = "Các bước";
            // 
            // txtBanDau
            // 
            this.txtBanDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanDau.Location = new System.Drawing.Point(236, 228);
            this.txtBanDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBanDau.Name = "txtBanDau";
            this.txtBanDau.ReadOnly = true;
            this.txtBanDau.Size = new System.Drawing.Size(1111, 30);
            this.txtBanDau.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dãy số ban đầu";
            // 
            // btnSortAsc
            // 
            this.btnSortAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortAsc.Location = new System.Drawing.Point(1105, 37);
            this.btnSortAsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortAsc.Name = "btnSortAsc";
            this.btnSortAsc.Size = new System.Drawing.Size(242, 46);
            this.btnSortAsc.TabIndex = 14;
            this.btnSortAsc.Text = "Sắp xếp tăng dần";
            this.btnSortAsc.UseVisualStyleBackColor = true;
            this.btnSortAsc.Click += new System.EventHandler(this.btnSortAsc_Click);
            // 
            // btnSortDesc
            // 
            this.btnSortDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortDesc.Location = new System.Drawing.Point(1105, 85);
            this.btnSortDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortDesc.Name = "btnSortDesc";
            this.btnSortDesc.Size = new System.Drawing.Size(242, 46);
            this.btnSortDesc.TabIndex = 15;
            this.btnSortDesc.Text = "Sắp xếp giảm dần";
            this.btnSortDesc.UseVisualStyleBackColor = true;
            this.btnSortDesc.Click += new System.EventHandler(this.btnSortDesc_Click);
            // 
            // cbbGiaiThuat
            // 
            this.cbbGiaiThuat.FormattingEnabled = true;
            this.cbbGiaiThuat.Items.AddRange(new object[] {
            "Bubble Sort",
            "Selection Sort",
            "Insertion Sort",
            "Counting Sort"});
            this.cbbGiaiThuat.Location = new System.Drawing.Point(291, 125);
            this.cbbGiaiThuat.Name = "cbbGiaiThuat";
            this.cbbGiaiThuat.Size = new System.Drawing.Size(610, 28);
            this.cbbGiaiThuat.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Chọn giải thuật";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 589);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kết quả cuối cùng";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(265, 589);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(1082, 30);
            this.txtKetQua.TabIndex = 19;
            // 
            // SapXep
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 721);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbGiaiThuat);
            this.Controls.Add(this.btnSortDesc);
            this.Controls.Add(this.btnSortAsc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBanDau);
            this.Controls.Add(this.Lbl_BuocLam);
            this.Controls.Add(this.lbxSapXep);
            this.Controls.Add(this.btnTapTin);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Name = "SapXep";
            this.Text = "Sắp Xếp";
            this.Load += new System.EventHandler(this.SapXep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTapTin;
        private System.Windows.Forms.ListBox lbxSapXep;
        private System.Windows.Forms.Label Lbl_BuocLam;
        private System.Windows.Forms.TextBox txtBanDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSortAsc;
        private System.Windows.Forms.Button btnSortDesc;
        private System.Windows.Forms.ComboBox cbbGiaiThuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}