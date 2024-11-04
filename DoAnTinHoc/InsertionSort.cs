using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTinHoc
{
    public partial class InsertionSort : Form
    {
        List<double> a = new List<double>();
        int k = 1;
        public string DocTapTin(string tentaptin)
        {
            string noidung = "";
            try
            {
                StreamReader sr = new StreamReader(tentaptin);
                noidung = sr.ReadToEnd();
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Không đọc được tập tin");
            }
            return noidung;
        }
        public void ThemPhanTuVaoList(string tentaptin)
        {
            string noidung = DocTapTin(tentaptin);
            string[] phanTu = noidung.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in phanTu)
            {
                if (double.TryParse(s, out double giaTri))
                {
                    a.Add(giaTri);
                }
            }
        }
        public InsertionSort()
        {
            InitializeComponent();
        }
        private int tim(int b)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (b == a[i])
                {
                    return i;
                }
            }
            return -1;

        }
        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_nhap.Text))
            {
                if (tim(int.Parse(txt_nhap.Text)) == -1)
                {
                    txt_DaySo.Text += txt_nhap.Text + " ";
                    a.Add(int.Parse(txt_nhap.Text));
                    txt_nhap.Text = "";
                    txt_nhap.Select();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một giá trị khac ");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập một giá trị");
            }

        }
        private void xuat()
        {
            TextBox x = new TextBox();
            for (int i = 0; i < a.Count; i++)
            {
                x.Text += a[i].ToString() + " ";
            }
            lbx_sapxep.Items.Add("Bước " + k++ + ": " + x.Text);
            x.Clear();
        }

        private void btb_sapxep_Click(object sender, EventArgs e)
        {
            if (a.Count == 0)
            {
                MessageBox.Show("Danh sách trống, không thể sắp xếp.");
                return;
            }
            k = 1;
            txt_bang.Text = "";
            lbx_sapxep.Items.Clear();
            xuat();
            for (int i = 0; i <= a.Count - 1; i++)
            {
                bool swap = false;
                var key = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                    swap = true;
                }
                a[j + 1] = key;
                if (swap == true)
                    xuat();
            }
        }

        

        private void btb_xoa_Click(object sender, EventArgs e)
        {
            a.Clear();
            k = 1;
            txt_DaySo.Text = "";
            txt_bang.Text = "";
            lbx_sapxep.Items.Clear();
            txt_nhap.Select();
        }

        private void Btn_SapXepGiam_Click(object sender, EventArgs e)
        {
            if (a.Count == 0)
            {
                MessageBox.Show("Danh sách trống, không thể sắp xếp.");
                return;
            }
            k = 1;
            txt_bang.Text = "";
            lbx_sapxep.Items.Clear();
            xuat();
            for (int i = 0; i <= a.Count - 1; i++)
            {
                bool swap = false;
                var key = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] < key)
                {
                    a[j + 1] = a[j];
                    j--;
                    swap = true;
                }
                a[j + 1] = key;
                if (swap == true)
                    xuat();
            }
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "All Files(*.*)|*.*|Text Files(*.txt;*.docx)|" + "*.txt;*.docx";
            ofd1.FilterIndex = 0;
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                txt_DaySo.Text = DocTapTin(ofd1.FileName);
                ThemPhanTuVaoList(ofd1.FileName);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lbl_sua.Visible = true;
            txt_Sua.Visible = true;
            BtnSua.Visible = true;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Sua.Text))
            {
                TextBox tam = new TextBox();
                int tam1 = 0;
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] == int.Parse(txt_Sua.Text))
                    {
                        a[i] = int.Parse(txt_nhap.Text);
                        tam1 = 1;
                    }
                }
                if (tam1 == 0)
                {
                    MessageBox.Show("Không có giá tri cần thay thế");
                    Lbl_sua.Visible = true;
                    txt_Sua.Visible = true;
                    BtnSua.Visible = true;
                }
                else
                {
                    for (int i = 0; i < a.Count; i++)
                    {
                        tam.Text += a[i].ToString() + " ";
                    }
                    txt_nhap.Clear();
                    txt_nhap.Select();
                    txt_Sua.Clear();
                    txt_DaySo.Text = "";
                    txt_DaySo.Text = tam.Text;
                    Lbl_sua.Visible = false;
                    txt_Sua.Visible = false;
                    BtnSua.Visible = false;
                }
            }
        }
    }
}
