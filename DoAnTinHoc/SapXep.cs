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
        }
        private void btnTapTin_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(ofd.FileName);
                int[] mang = fileContent.Split(' ').Select(int.Parse).ToArray();
                txtKetQua.Text = string.Join(" ", mang);
            }
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNhap.Text != "")
                {
                    mang = txtNhap.Text.Split(' ').Select(int.Parse).ToArray();
                    txtBanDau.Text = string.Join(" ", mang);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập chuỗi giá trị");
            }
        }
        private void SapXepMang(bool tangDan)
        {
            int[] mangSapXep = (int[])mang.Clone();
            lbxSapXep.Items.Clear();
            switch (cbbGiaiThuat.SelectedItem.ToString())
            {
                case "Bubble Sort":
                    if (tangDan)
                        CGiaiThuat.BubbleSort(mangSapXep, lbxSapXep);
                    else CGiaiThuat.BubbleSortDescending(mangSapXep, lbxSapXep);
                    break;
                case "Selection Sort":
                    if (tangDan)
                        CGiaiThuat.SelectionSort(mangSapXep, lbxSapXep);
                    else
                        CGiaiThuat.SelectionSortDescending(mangSapXep, lbxSapXep);
                    break;
                case "Insertion Sort":
                    if (tangDan)
                        CGiaiThuat.InsertionSort(mangSapXep, lbxSapXep);
                    else CGiaiThuat.InsertionSortDescending(mangSapXep, lbxSapXep);
                    break;
                case "Counting Sort":
                    if (tangDan)
                        CGiaiThuat.CountingSort(mangSapXep, lbxSapXep);
                    else
                        CGiaiThuat.CountingSortDescending(mangSapXep, lbxSapXep);
                    break;
            }
            txtKetQua.Text = string.Join(" ", mangSapXep);
        }
        private void btnSortAsc_Click(object sender, EventArgs e)
        {

            if (mang != null && mang.Length > 0)
            {
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
                SapXepMang(false);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập chuỗi giá trị");
            }
        }
    }
}
