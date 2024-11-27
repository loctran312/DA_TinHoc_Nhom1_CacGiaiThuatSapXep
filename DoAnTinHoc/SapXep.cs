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
using System.Diagnostics.Eventing.Reader;

namespace DoAnTinHoc
{
    public partial class SapXep : Form
    {
        private int[] mang;
        public static int delay;
        public static bool pause;
        public static bool clear;
        public static bool running;
        public SapXep()
        {

            InitializeComponent();
            delay = 6000 - 1000 * (int)numericUpDown.Value;
            pause = false;
        }
        private void SapXep_Load(object sender, EventArgs e)
        {
            cbbGiaiThuat.SelectedIndex = 0;
        }
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            delay = 6000 - 1000 * (int)numericUpDown.Value;
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
                    var values = fileContent.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    if (values.Distinct().Count() != values.Length)
                    {
                        MessageBox.Show("Dữ liệu trong tập tin có giá trị trùng lặp. Vui lòng kiểm tra lại.");
                        return;
                    }
                    mang = values;
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
                        var values = txtNhap.Text.Split(' ').Select(int.Parse).ToArray();
                        if (values.Distinct().Count() != values.Length)
                        {
                            MessageBox.Show("Dữ liệu nhập vào có giá trị trùng lặp. Vui lòng nhập lại.");
                            return;
                        }
                        mang = values;
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
                    MessageBox.Show("Vui lòng nhập chuỗi giá trị hợp lệ");
                }

            }
            else
            {
                MessageBox.Show("Đã có dữ liệu");
            }
        }
        private void KhoiTaoMoPhongSapXep(int[] mang, TextBox[] txtArray, Label[] lblArray)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                txtArray[i] = (TextBox)this.Controls.Find("txt" + i, true)[0];
                lblArray[i] = (Label)this.Controls.Find("lbl" + i, true)[0];
            }
        }
        private void SapXepMang(bool tangDan)
        {
            running = true;
            int[] mangSapXep = (int[])mang.Clone();
            TextBox[] txtArray = new TextBox[mangSapXep.Length];
            Label[] lblArray = new Label[mangSapXep.Length];
            lbxSapXep.Items.Clear();
            clear = false;
            KhoiTaoMoPhongSapXep(mangSapXep, txtArray, lblArray);
            switch (cbbGiaiThuat.SelectedItem.ToString())
            {
                case "Bubble Sort":
                    if (tangDan)
                        CGiaiThuat.BubbleSort(mangSapXep, lbxSapXep, txtArray, lblArray, true);
                    else
                        CGiaiThuat.BubbleSort(mangSapXep, lbxSapXep, txtArray, lblArray, false);
                    break;
                case "Selection Sort":
                    if (tangDan)
                        CGiaiThuat.SelectionSort(mangSapXep, lbxSapXep, txtArray, lblArray, true);
                    else
                        CGiaiThuat.SelectionSort(mangSapXep, lbxSapXep, txtArray, lblArray, false);
                    break;
                case "Insertion Sort":
                    if (tangDan)
                        CGiaiThuat.InsertionSort(mangSapXep, lbxSapXep, txtArray, lblArray, true);
                    else
                        CGiaiThuat.InsertionSort(mangSapXep, lbxSapXep, txtArray, lblArray, false);
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
            if (running == true)
            {
                MessageBox.Show("Chương trình đang chạy vui lòng đợi!");
            }   
            else
            {
                txtNhap.Clear();
                txtBanDau.Clear();
                lbxSapXep.Items.Clear();
                clear = true;
                pause = false;
                btnDung.Text = " Dừng ";
                running = false;
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

        private void btnDung_Click(object sender, EventArgs e)
        {
            if (running == true)
            {
                if (pause == false)
                {
                    pause = true;
                    btnDung.Text = " Tiếp Tục ";

                }
                else
                {
                    pause = false;
                    btnDung.Text = " Dừng ";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhấn chọn sắp xếp");
            }    
        }

        private void btnNgauNhien_Click(object sender, EventArgs e)
        {
            if (mang == null || mang.Length == 0)
            {
                Random rand = new Random();
                int lenght = rand.Next(7, 14);
                HashSet<int> randArr = new HashSet<int>();
                for (int i = 0; i < lenght; i++)
                {
                    randArr.Add(rand.Next(1, 50));

                }
                txtNhap.Text = string.Join(" ", randArr);
            }
            else
            {
                MessageBox.Show("Đã có dữ liệu");
            }
        }
    }
}