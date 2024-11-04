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
    public partial class Radix : Form
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
        public Radix()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            TextBox x = new TextBox();
            for (int i = 0; i < a.Count; i++)
            {
                x.Text += a[i].ToString() + " ";
            }
            lbx_sapxep.Items.Add("Bước " + k++ + ": " + x.Text);
            txt_bang.Text = x.Text;
            x.Clear();
        }
        private void btb_sapxep_Click(object sender, EventArgs e)
        {
            k = 1;
            txt_bang.Text = "";
            lbx_sapxep.Items.Clear();
            int max = ((int)a.Max());
            for (int donVi = 1; max / donVi > 0; donVi *= 10)
            {
                int n = a.Count;
                double[] output = new double[n];// chứa số đã duyệt xong
                int[] count = new int[10];//chứa số đếm đang so sánh
                for (int i = 0; i < n; i++)
                {
                    double m = (a[i] / donVi % 10);// tìm đơn vị
                    count[(int)m]++;
                }

                for (int i = 1; i < 10; i++)
                {
                    count[i] += count[i - 1];//đổi lại đúng vị trí 
                }

                for (int i = n - 1; i >= 0; i--)//nhập vào hàm output
                {
                    double m = (int)(a[i] / donVi % 10);
                    output[--count[(int)m]] = a[i];
                }

                for (int i = 0; i < n; i++)
                {
                    a[i] = output[i];//nhập output vào a
                }
                xuat();
            }
        }
        private void Btn_SapXepGiam_Click(object sender, EventArgs e)
        {
            k = 1;
            txt_bang.Text = "";
            lbx_sapxep.Items.Clear();
            int max = ((int)a.Max());
            for (int donVi = 1; max / donVi > 0; donVi *= 10)
            {
                int n = a.Count;
                double[] output = new double[n];// chứa số đã duyệt xong
                int[] count = new int[10];//chứa số đếm đang so sánh

                for (int i = 0; i < n; i++)// tìm đơn vị
                {
                    double m = ((a[i] / donVi) % 10);
                    count[(int)m]++;
                }

                for (int i = 8; i >= 0; i--)//đổi lại đúng vị trí 
                {
                    count[i] += count[i + 1];
                }

                for (int i = n - 1; i >= 0; i--)//nhập vào hàm output
                {
                    double m = ((a[i] / donVi) % 10);
                    output[--count[(int)m]] = a[i];
                }

                for (int i = 0; i < n; i++)//nhập output vào a
                {
                    a[i] = output[i];
                }
                xuat();

            }
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
        

        private void btb_xoa_Click(object sender, EventArgs e)
        {
            a.Clear();
            k = 1;
            txt_DaySo.Text = "";
            txt_bang.Text = "";
            lbx_sapxep.Items.Clear();
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
