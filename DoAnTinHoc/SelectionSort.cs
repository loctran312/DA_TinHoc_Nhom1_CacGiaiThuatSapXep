using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTinHoc
{
    public partial class SelectionSort : Form
    {
        public SelectionSort()
        {
            InitializeComponent();
        }

        List <double> a = new List<double>();
        int k = 1;
        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            txt_DaySo.Text += txt_nhap.Text + " ";
            a.Add(double.Parse(txt_nhap.Text));
            txt_nhap.Text = "";
            txt_nhap.Select();
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
            k = 1;
            txt_bang.Text = "";
            lbx_sapxep.Items.Clear();
            for (int i = 0; i <= a.Count-1; i++)
            {
                int min = i;
                for (int j = i + 1; j < a.Count; j++)
                    if (a[j] < a[min])
                    {
                        min = j;
                        double temp = a[min];
                        a[min] = a[i];
                        a[i] = temp;
                    }   
                 xuat();
                 txt_bang.Text += a[i] + " ";
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

        private void Btn_SapXepGiam_Click(object sender, EventArgs e)
        {
            k = 1;
            txt_bang.Text = "";
            lbx_sapxep.Items.Clear();
            for (int i = 0; i <= a.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < a.Count; j++)
                    if (a[j] > a[min])
                    {
                        min = j;
                        double temp = a[min];
                        a[min] = a[i];
                        a[i] = temp;
                    }
                xuat();
                txt_bang.Text += a[i] + " ";
            }
        }
    }
}
