using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public partial class QL_HoaDon_BanHang
    {
        int _DiemDung;
        int _TongTienThat;

        public int TongTienThat
        {
            get { return _TongTienThat; }
            set { _TongTienThat = value; }
        }
        public int DiemDung
        {
            get { return _DiemDung; }
            set { _DiemDung = value; }
        }
    }
}
