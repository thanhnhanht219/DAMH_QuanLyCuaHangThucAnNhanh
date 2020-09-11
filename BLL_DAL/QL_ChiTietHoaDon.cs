using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public partial class QL_ChiTietHoaDon
    {
        string _STT;
        string _TenSanPham; 

        public string TenSanPham
        {
            get { return _TenSanPham; }
            set { _TenSanPham = value; }
        }

        public string STT
        {
            get { return _STT; }
            set { _STT = value; }
        }
    }
}
