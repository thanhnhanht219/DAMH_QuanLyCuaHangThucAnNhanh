using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clb_GUI
{
    public partial class usSanPham : UserControl
    {
        Boolean check = true;
        public usSanPham()
        {
            InitializeComponent();

        }

        public void setValueSP(int gia, string path, string ten)
        {
            lbgia.Text = ChucNang.convertGia(gia);
            try
            {
                this.pictureBox1.Image = Image.FromFile(path);
            }
            catch
            {
                this.pictureBox1.Image = Image.FromFile("../../img/img_sanpham/" + "no-image.jpg");
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
            pnLine.Click += pnLine_Click;

           

            lbTenSanPham.Text = ten;
        }

        private void usSanPham_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
        }

        private void pnLine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTenSanPham_Click(object sender, EventArgs e)
        {

        }

        public void setEventForALL()
        {
            foreach (Control item in pnMain.Controls)
            {
                item.Click += lbgia_Click;
            }
            pnLine.Click += pnLine_Click;
        }

        void lbgia_Click(object sender, EventArgs e)
        {
            if (pnLine.Visible == false)
            {
                //btnchon.Visible = true;
                pnLine.Visible = true;
                check = false;
            }
            else
            {
                //btnchon.Visible = false;
                pnLine.Visible = false;
                check = true;
            }

        }

        void pnLine_Click(object sender, EventArgs e)
        {
            //  btnchon.Visible = false;
            pnLine.Visible = false;
            check = false;
        }

        void pnMain_Click(object sender, EventArgs e)
        {

        }

        private void lbTenSanPham_Click_1(object sender, EventArgs e)
        {

        }
    }
}
