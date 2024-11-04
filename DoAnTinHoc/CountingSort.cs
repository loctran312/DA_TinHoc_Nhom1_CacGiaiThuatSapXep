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
    public partial class CountingSort : Form
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
        public CountingSort()
        {
            InitializeComponent();
        }
        private void btn_Nhap_Click(object sender, EventArgs e)
        { 
            if (!string.IsNullOrWhiteSpace(txt_nhap.Text))
            {
                string input = null;
                txt_DaySo.Text += txt_nhap.Text + " ";
                input=txt_nhap.Text;
                string[] daySo = input.Split(' '); // 2 chữ có khoảng cách ở giữa thì tách làm 2 giá trị riêng rồi nhét vô list daySo

                foreach (string tungSo in daySo)
                {
                    double number = double.Parse(tungSo);
                    a.Add(number);
                }
                txt_nhap.Text = "";
                txt_nhap.Select();
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
            lbx_sapxep.Items.Add("KẾT QUẢ : " + string.Join(", ", a));
            txt_bang.Text = x.Text;
            x.Clear();
        }

        private void btb_sapxep_Click(object sender, EventArgs e)
        {
            k = 1;
            txt_bang.Text = "";
            lbx_sapxep.Items.Clear();
            int max = ((int)a.Max());
           
            for (int i = 1; i < a.Count; i++)
            {
                if (a[i] > max) max = (int)a[i];
            }

            int[] count = new int[max + 1];//hàm chứa số đếm
            for (int i = 0; i < a.Count; i++)
            {
                count[(int)a[i]]++;
            }
            lbx_sapxep.Items.Add("ĐẾM CÁC SỐ TRONG CHUỖI TỪ 0 ĐẾN " + max + ": " + string.Join(",",count) );

            int m = 0;// vì hàm đi từ max-0 nên cần biến phụ(a[0])
            for (int i = 0; i <= max; i++)//nếu số đó có tồn tại thì lưu đến khi nào hết số đó trong hàm đến (đi từ max đến 0)
            {
                while (count[i] > 0)
                {
                    a[m++] = i;
                    count[i]--;
                    lbx_sapxep.Items.Add("Bước "+k+++":" + string.Join(",", a));
                }
            }
            xuat();
        }

        private void Btn_SapXepGiam_Click(object sender, EventArgs e)
        {
            k = 1;
            txt_bang.Text = "";
            lbx_sapxep.Items.Clear();
            int max = ((int)a.Max());
          
            int[] count = new int[max + 1];//hàm chứa số đếm 
            for (int i = 0; i < a.Count; i++)
            {
                count[(int)a[i]]++;//đếm các số 
            }

            lbx_sapxep.Items.Add("ĐẾM CÁC SỐ TRONG CHUỖI TỪ 0 ĐẾN " + max+": " + string.Join(",", count));

            int m = 0;// vì hàm đi từ max-0 nên cần biến phụ(a[0])
            for (int i = max; i >= 0; i--)
            {
                while (count[i] > 0)//nếu số đó có tồn tại thì lưu đến khi nào hết số đó trong hàm đến (đi từ max đến 0)
                {
                    a[m++] = i;
                    count[i]--;
                    lbx_sapxep.Items.Add("Bước " + k++ + ":" + string.Join(",", a));
                }
            }
            xuat();

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
    }
}
