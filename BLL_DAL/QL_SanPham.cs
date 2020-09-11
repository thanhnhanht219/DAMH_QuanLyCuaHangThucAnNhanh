using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public partial class QL_SanPham
    {
        
        private string _TenLoai;

        public string TenLoai
        {
            get { return _TenLoai; }
            set { _TenLoai = value; }
        }
        public QL_SanPham(QL_SanPham sp, string tenloai)
        {
            
            this.MaSP = sp.MaSP;
            this.TenSanPham = sp.TenSanPham;
            this.TinhTrang = sp.TinhTrang;
            this.TenLoai = tenloai;
            this.Hinh = sp.Hinh;
            this.Gia = sp.Gia;
            this.MaLoaiSP = sp.MaLoaiSP;           
        }
    }
}
