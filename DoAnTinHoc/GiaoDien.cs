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
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            SapXep f = new SapXep();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelBody.Controls.Add(f);
            panelBody.Tag = f;
            f.BringToFront();
            f.Show();
            Button btnMenu = new Button();
            btnMenu.Location = new Point(0,0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(100, 50);
            btnMenu.Font = new Font("Times New Roman", 12,FontStyle.Bold);
            btnMenu.BackgroundImage = btnStart.BackgroundImage;
            btnMenu.Text = "MENU";
            panelTop.Controls.Add(btnMenu);
            btnMenu.Click += new EventHandler(btnMenu_Click);
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!SapXep.running)
            {
                foreach (Control control in panelBody.Controls)
                {
                    if (control is SapXep)
                    {
                        panelBody.Controls.Remove(control);
                        control.Dispose();
                        break;
                    }
                }
                panelTop.Controls.Remove((Button)sender);
            }
            else
            {
                MessageBox.Show("Chương trình đang thực hiện sắp xếp, vui lòng đợi!");
            }    
        }
            private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình không?","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
