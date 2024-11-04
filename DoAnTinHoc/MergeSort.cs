﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTinHoc
{
    public partial class MergeSort : Form
    {
        public MergeSort()
        {
            InitializeComponent();
        }
        List<int> a = new List<int>();
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
                if (int.TryParse(s, out int giaTri))
                {
                    a.Add(giaTri);
                }
            }
        }
        private int tim ( int b)
        {
            for (int i = 0; i < a.Count; i++) 
            {
                if (b == a[i] )
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
                if(tim(int.Parse(txt_nhap.Text))==-1 )
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
        
        private void btb_sapxep_Click(object sender, EventArgs e)
        {
            k = 1;
            lbx_sapxep.Items.Clear();
            int[] m = new int[a.Count];
            for (int i = 0;i<a.Count;i++)
            {
                m[i] = int.Parse(a[i].ToString());
            }
            Mergesort( m, 0, a.Count - 1);
            
        }
        private void doi(int []m)
        {
            for (int i = 0; i<a.Count ;i++)
            {
                a[i] = m[i];
            }
        }
        
        private void Mergesort(int[] a, int left, int right)
        {

            if (left < right)
            {
                int mid = (left + right) / 2;   
                Mergesort(a, left, mid);
                Mergesort(a, mid + 1, right);   
                Merge(a, left, mid, right);
            }

        }
        private void Merge(int[] a, int left, int mid, int right)
        {
            int n1 = mid - left + 1; 
            int n2 = right - mid;

            int[] lefta = new int[n1];
            int[] righta = new int[n2];

            Array.Copy(a, left, lefta, 0, n1);
            Array.Copy(a, mid + 1, righta, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (lefta[i] <= righta[j])
                {
                    a[k] = lefta[i];
                    i++;
                }
                else
                {
                    a[k] = righta[j];
                    j++;
                }
                k++;
                doi(a);
                xuat();

            }

            while (i < n1)
            {
                a[k] = lefta[i];
                i++;
                k++;
                doi(a);
                xuat();
            }
            while (j < n2)
            {
                a[k] = righta[j];
                j++;
                k++;
                doi(a);
                xuat();

            }
            


        }
        private void Mergedown(int[] a, int left, int mid, int right)
        {
            
            
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] lefta = new int[n1];
            int[] righta = new int[n2];

            Array.Copy(a, left, lefta, 0, n1);
            Array.Copy(a, mid + 1, righta, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (lefta[i] > righta[j])
                {
                    a[k] = lefta[i];
                    i++;
                }
                else
                {
                    a[k] = righta[j];
                    j++;
                }
                k++;
                doi(a);
                xuat();

            }

            while (i < n1)
            {
                a[k] = lefta[i];
                i++;
                k++;
                doi(a);
                xuat();
            }
            while (j < n2)
            {
                a[k] = righta[j];
                j++;
                k++;
                doi(a);
                xuat();

            }
        }
        private void Mergesortdown(int[] a, int left, int right)
        {

            if (left < right)
            {
                int mid = (left + right) / 2;
                Mergesortdown(a, left, mid);
                Mergesortdown(a, mid + 1, right);
                Mergedown(a, left, mid, right);
            }

        }

        private void Btn_SapXepGiam_Click(object sender, EventArgs e)
        {
            k = 1;
            lbx_sapxep.Items.Clear();
            int[] m = new int[a.Count];
            for (int i = 0; i < a.Count; i++)
            {
                m[i] = int.Parse(a[i].ToString());
            }
            Mergesortdown(m, 0, a.Count - 1);

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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lbl_sua.Visible = true;
            txt_Sua.Visible = true;
            BtnSua.Visible = true;
        }

        
    }
}
