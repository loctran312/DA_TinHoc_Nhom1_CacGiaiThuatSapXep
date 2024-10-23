using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTinHoc
{
    public partial class BubbleSort : Form
    {
        List<double> a = new List<double>();
        int k = 1;
        public BubbleSort()
        {
            InitializeComponent();
        }
        private void Btn_Nhap_Click(object sender, EventArgs e)
        {
            txt_DaySo.Text += Txt_Nhap.Text + " ";
            a.Add(double.Parse(Txt_Nhap.Text));  
            Txt_Nhap.Text = "";
            Txt_Nhap.Select();
        }
        private void XuatMang()
        {
            TextBox x = new TextBox();
            for (int i = 0; i < a.Count; i++)
            {
                x.Text += a[i].ToString() + " ";
            }
            Lbx_SapXep.Items.Add("Bước " + k++ + ": " + x.Text);
            x.Clear();
        }
        private void Btn_SapXep_Click(object sender, EventArgs e)
        {
            k = 1;
            Txt_Bang.Text = "";
            Lbx_SapXep.Items.Clear();
            for (int i = 0; i <= a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                    if (a[i] > a[j])
                    {
                        var tempVar = a[i];
                        a[i] = a[j];
                        a[j] = tempVar;                        
                    }
                XuatMang();
                Txt_Bang.Text += a[i] + " ";
            }
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            a.Clear();
            k = 1;
            Txt_Bang.Text = "";
            txt_DaySo.Text = "";
            Lbx_SapXep.Items.Clear();
        }
        private void Btn_SapXepGiam_Click(object sender, EventArgs e)
        {
            k = 1;
            Txt_Bang.Text = "";
            Lbx_SapXep.Items.Clear();
            for (int i = 0; i <= a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                    if (a[i] < a[j])
                    {
                        var tempVar = a[i];
                        a[i] = a[j];
                        a[j] = tempVar;
                    }
                XuatMang();
                Txt_Bang.Text += a[i] + " ";
            }
        }
    }
}
