using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoAnTinHoc
{
    public partial class SapXep : Form
    {
        private int[] mang;
        public SapXep()
        {
            InitializeComponent();
        }
        private void SapXep_Load(object sender, EventArgs e)
        {
            cbbGiaiThuat.SelectedIndex = 0;
        }
        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            else 
            {
                TextBox txt = sender as TextBox;
                if (e.KeyChar == ' ' && (txt.Text.Length == 0 || txt.Text.EndsWith(" ")))
                {
                    e.Handled = true;
                }
            }
        }
        private void btnTapTin_Click(object sender, EventArgs e)
        {
            
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(ofd.FileName);
                try
                {
                    mang = fileContent.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    if (mang.Length > 15)
                    {
                        mang = null;
                        MessageBox.Show("Mảng quá nhiều");
                        return;
                    }
                    txtBanDau.Text = string.Join(" ", mang);
                    TextBox[] txtArray = new TextBox[mang.Length];
                    Label[] lblArray = new Label[mang.Length];
                    for (int i = 0; i < mang.Length; i++)
                    {
                        TextBox txt = new TextBox();
                        txt.Name = "txt" + i;
                        txt.Text = mang[i].ToString();
                        txt.TextAlign = HorizontalAlignment.Center;
                        txt.Font = new Font("Times New Roman", 12);
                        txt.Location = new Point(60 * i, 220);
                        txt.Size = new Size(50, 30);
                        txt.BackColor = Color.White;
                        txt.ReadOnly = true;
                        this.Controls.Add(txt);
                        txtArray[i] = txt;
                        Label lbl = new Label();
                        lbl.Name = "lbl" + i;
                        lbl.Text = "[" + i + "]".ToString();
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Font = new Font("Times New Roman", 12);
                        lbl.Location = new Point(60 * i, 260);
                        lbl.Size = new Size(50, 30);
                        this.Controls.Add(lbl);
                        lblArray[i] = lbl;
                    }
                }
                catch
                {
                    MessageBox.Show("Nội dung tập tin không hợp lệ. Vui lòng kiểm tra lại.");
                }
            }
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (mang == null || mang.Length == 0)
            {
                try
                {
                    if (txtNhap.Text != "")
                    {
                        mang = txtNhap.Text.Split(' ').Select(int.Parse).ToArray();
                        TextBox[] txtArray = new TextBox[mang.Length];
                        Label[] lblArray = new Label[mang.Length];
                        if (mang != null && mang.Length > 15)
                        {
                            mang = null;
                            MessageBox.Show("Mảng quá nhiều");
                            return;
                        }
                        else
                        {
                            txtBanDau.Text = string.Join(" ", mang);
                            for (int i = 0; i < mang.Length; i++)
                            {
                                TextBox txt = new TextBox();
                                txt.Name = "txt" + i;
                                txt.Text = mang[i].ToString();
                                txt.TextAlign = HorizontalAlignment.Center;
                                txt.Font = new Font("Times New Roman", 12);
                                txt.Location = new Point(60 * i, 220);
                                txt.Size = new Size(50, 30);
                                txt.BackColor = Color.White;
                                txt.ReadOnly = true;
                                this.Controls.Add(txt);
                                txtArray[i] = txt;
                                Label lbl = new Label();
                                lbl.Name = "lbl" + i;
                                lbl.Text = "[" + i + "]".ToString();
                                lbl.TextAlign = ContentAlignment.MiddleCenter;
                                lbl.Font = new Font("Times New Roman", 12);
                                lbl.Location = new Point(60 * i, 260);
                                lbl.Size = new Size(50, 30);
                                this.Controls.Add(lbl);
                                lblArray[i] = lbl;
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập chuỗi giá trị");
                }

            }
            else
            {
                MessageBox.Show("Đã có dữ liệu");
            }
        }
        private void KhoiTaoMoPhongSapXep(int[] a, TextBox[] b, Label[]c)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                b[i] = (TextBox)this.Controls.Find("txt" + i, true)[0];
                c[i] = (Label)this.Controls.Find("lbl" + i, true)[0];
            }
        }
        private void SapXepMang(bool tangDan)
        {
            int[] mangSapXepbbs=(int[])mang.Clone();
            int[] mangSapXepsls = (int[])mang.Clone();
            int[] mangSapXepiss = (int[])mang.Clone();
            TextBox[] txtArray1= new TextBox[mangSapXepbbs.Length];
            TextBox[] txtArray2= new TextBox[mangSapXepsls.Length];
            TextBox[] txtArray3= new TextBox[mangSapXepiss.Length];
            Label[] lblArray1 = new Label[mangSapXepbbs.Length];
            Label[] lblArray2 = new Label[mangSapXepsls.Length];
            Label[] lblArray3 = new Label[mangSapXepiss.Length];
            lbxSapXep.Items.Clear();
            KhoiTaoMoPhongSapXep(mangSapXepbbs,txtArray1,lblArray1);
            KhoiTaoMoPhongSapXep(mangSapXepsls,txtArray2,lblArray2);
            KhoiTaoMoPhongSapXep(mangSapXepiss, txtArray3, lblArray3);
            switch (cbbGiaiThuat.SelectedItem.ToString())
            {
                case "Bubble Sort":
                    if (tangDan)
                        CGiaiThuat.BubbleSort(mangSapXepbbs, lbxSapXep,txtArray1,lblArray1);
                    else
                        CGiaiThuat.BubbleSortDescending(mangSapXepbbs, lbxSapXep, txtArray1, lblArray1);
                    break;
                case "Selection Sort":
                    if (tangDan)
                        CGiaiThuat.SelectionSort(mangSapXepsls, lbxSapXep, txtArray2, lblArray2);
                    else
                        CGiaiThuat.SelectionSortDescending(mangSapXepsls, lbxSapXep, txtArray2, lblArray2);
                    break;
                case "Insertion Sort":
                    if (tangDan)
                        CGiaiThuat.InsertionSort(mangSapXepiss, lbxSapXep, txtArray3, lblArray3);
                    else
                        CGiaiThuat.InsertionSortDescending(mangSapXepiss, lbxSapXep, txtArray3, lblArray3);
                    break;
            }
            for (int i = 0; i < mang.Length; i++)
            {
                txtArray1[i].Text = mangSapXepbbs[i].ToString();
                txtArray2[i].Text = mangSapXepsls[i].ToString();    
                txtArray3[i].Text = mangSapXepiss[i].ToString();    
            }
        }
        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            if (mang != null && mang.Length > 0)
            {
                int[] mangTam = (int[])mang.Clone();
                Array.Sort(mangTam);
                int dem = 0;
                for (int i = 0; i < mang.Length; i++)
                {
                    if (mangTam[i] == mang[i])
                        dem++;
                }
                if (dem == mang.Length)
                    MessageBox.Show("Mảng đã được sắp xếp tăng dần");
                else
                    SapXepMang(true);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập chuỗi giá trị");
            }

        }
        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            if (mang != null && mang.Length > 0)
            {
                int[] mangTam = (int[])mang.Clone();
                Array.Sort(mangTam);
                Array.Reverse(mangTam);
                int dem = 0;
                for (int i = 0; i < mang.Length; i++)
                {
                    if (mangTam[i] == mang[i])
                        dem++;
                }
                if (dem == mang.Length)
                    MessageBox.Show("Mảng đã được sắp xếp giảm dần");
                else
                    SapXepMang(false);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập chuỗi giá trị");
            }
        }
        private void btnxXoa_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtBanDau.Clear();
            lbxSapXep.Items.Clear();
            if (mang != null && mang.Length > 0)
            {
                TextBox[] txtArray = new TextBox[mang.Length];
                Label[] lblArray = new Label[mang.Length];
                for (int i = 0; i < mang.Length; i++)
                {
                    this.Controls.Remove(txtArray[i] = (TextBox)this.Controls.Find("txt" + i, true)[0]);
                    this.Controls.Remove(lblArray[i] = (Label)this.Controls.Find("lbl" + i, true)[0]);
                }
                mang = null;
            }
            else
            {
                MessageBox.Show("Đã xóa hết các phần tử");
            }
        }
    }
}