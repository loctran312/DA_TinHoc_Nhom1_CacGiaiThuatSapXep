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
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập chuỗi giá trị");
            }
        }
        private void SapXepMang(bool tangDan)
        {
            int[] mangSapXep =  new int[mang.Length];
            lbxSapXep.Items.Clear();
            TextBox[] txtArray = new TextBox[mangSapXep.Length];
            Label[] lblArray = new Label[mangSapXep.Length];
            for (int i = 0; i < mang.Length; i++)
            {
                txtArray[i] = (TextBox)this.Controls.Find("txt" + i, true)[0];
                lblArray[i] = (Label)this.Controls.Find("lbl" + i, true)[0];
                mangSapXep[i] = int.Parse(txtArray[i].Text);
            }
            switch (cbbGiaiThuat.SelectedItem.ToString())
            {
                case "Bubble Sort":
                    if (tangDan)
                        CGiaiThuat.BubbleSort(mangSapXep,lbxSapXep, txtArray, lblArray);
                    else
                        CGiaiThuat.BubbleSortDescending(mangSapXep, lbxSapXep, txtArray, lblArray);
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
                    else
                        CGiaiThuat.InsertionSortDescending(mangSapXep, lbxSapXep);
                    break;
            }
            for (int i = 0; i < mang.Length; i++)
            {
                txtArray[i].Text = mangSapXep[i].ToString();
            }
           
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
