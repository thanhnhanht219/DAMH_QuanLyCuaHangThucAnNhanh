using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace clb_GUI
{
    public partial class usChiTietHD : UserControl
    {
        public int TongTien;
        public int soluong;
        private int dongia;
        public usChiTietHD()
        {
            InitializeComponent();
            TongTien = 0;
            soluong = 1;

        }
        public void setValue(string masp)
        {
            SanPham_BLL_DAL qlsp = new SanPham_BLL_DAL();
            QL_SanPham sp = qlsp.laySP(masp);
            lbTen.Text = sp.TenSanPham;
            lbGia.Text = ChucNang.convertGia((int)sp.Gia);
            lbTongTien.Text = ChucNang.convertGia((int)sp.Gia);
            soluong = (int)btnTangGiam.Value;
            dongia = (int)sp.Gia;
            TongTien = dongia * soluong;
        }

        public void capnhapTongTien(int soluong)
        {
            TongTien = dongia * soluong;
            this.lbTongTien.Text = ChucNang.convertGia(TongTien);
        }
    }
}
