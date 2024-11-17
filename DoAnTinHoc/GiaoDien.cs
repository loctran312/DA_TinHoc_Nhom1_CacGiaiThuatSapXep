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
        private void CBB_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (CBB_Menu.Text == "Bubble Sort")
            //    openForm(new BubbleSort());
            //else if (CBB_Menu.Text == "Selection Sort")
            //    openForm(new SelectionSort());
            //else if (CBB_Menu.Text == "Insertion Sort")
            //    openForm(new InsertionSort());
            //else
            //    openForm(new CountingSort());
            //CBB_Menu.Hide();
            //label1.Hide();
            //button1.Visible = true;
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
