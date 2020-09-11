using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class SanPham_ThongKe
    {
        string masp;
        int soluong;
        int dongia;
        string tensp;
        int _Cum;

        public int Cum
        {
            get { return _Cum; }
            set { _Cum = value; }
        }

        public string Tensp
        {
            get { return tensp; }       
        }
        SanPham_BLL_DAL spbll = new SanPham_BLL_DAL();
        public SanPham_ThongKe()
        {

        }
        public SanPham_ThongKe(string masp, int soluong, int dongia)
        {
            this.masp = masp;
            this.tensp = spbll.laySP(masp).TenSanPham;
            this.dongia = dongia;
            this.soluong = soluong;
        }
        
        public string Masp
        {
            get { return masp; }
            set { masp = value; tensp = spbll.laySP(value).TenSanPham; }
        }        

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }        
        public int Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }


    }
}
