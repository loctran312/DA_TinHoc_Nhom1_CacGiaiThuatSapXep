using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTinHoc
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
            button1.Hide();
        }
        private Form a;
        private void openForm(Form b)
        {
            a = b;
            b.TopLevel = false;
            b.FormBorderStyle = FormBorderStyle.None;
            b.Dock = DockStyle.Fill;
            panel3.Controls.Add(b);
            b.BringToFront();
            b.Show();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Hàm di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void CBB_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBB_Menu.Text == "Bubble Sort")
                openForm(new BubbleSort());
            else if (CBB_Menu.Text == "Selection Sort")
                openForm(new SelectionSort());
            else if (CBB_Menu.Text == "Insertion Sort")
                openForm(new InsertionSort());
            else if (CBB_Menu.Text == "Merge Sort")
                openForm(new MergeSort());
            else if (CBB_Menu.Text == "Quick Sort")
                openForm(new QuickSort());
            else if (CBB_Menu.Text == "Heap Sort")
                openForm(new HeapSort());
            else
                openForm(new CountingSort());
            CBB_Menu.Hide();
            label1.Hide();
            button1.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (a != null)
            {
                a.Close();
            }
            CBB_Menu.Text = "";
            CBB_Menu.Visible = true;
            label1.Visible = true;
            button1.Hide();
        }
    }
}
