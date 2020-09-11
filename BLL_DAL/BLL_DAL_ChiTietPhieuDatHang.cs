using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_ChiTietPhieuDatHang
    {
        #region Properties
        DBlinqDataContext ff = new DBlinqDataContext();
        #endregion

        #region method

        public BLL_DAL_ChiTietPhieuDatHang()
        {
            //empty
        }

        // Load chi tiet phieu dat hang
        public IQueryable load_ChiTietPhieuDatHang()
        {
            return ff.QL_ChiTietNhapHangs.Select(t=>new { t.MAHDNH, t.MANL,t.DVT,t.SoLuong,t.DonGia});
        }

        // Load chi tiết phiếu đặt hàng theo mã
        public IQueryable load_chiTietPhieuDatHangTheoMa(string ma)
        {
            IQueryable ct = from c in ff.QL_ChiTietNhapHangs
                            where c.MAHDNH == ma
                            select new { c.MAHDNH, c.MANL, c.DVT, c.SoLuong, c.DonGia };
            return ct;
        }
        
        // Thêm chi tiết phiếu nhập
        public void themChiTietPhieuNhap(string maPN,string maNL, string dvt, int soLuong, int donGia)
        {
            QL_ChiTietNhapHang n = new QL_ChiTietNhapHang();
            n.MAHDNH = maPN;
            n.MANL = maNL;
            n.DVT = dvt;
            n.SoLuong = soLuong;
            n.DonGia = donGia;
            ff.QL_ChiTietNhapHangs.InsertOnSubmit(n);
            ff.SubmitChanges();
        }

        // Xóa chi tiết phiếu nhập 
        public void xoaChiTietPhieuDatHang(string maDH, string maNL)
        {
            QL_ChiTietNhapHang c = ff.QL_ChiTietNhapHangs.Where(t => t.MAHDNH == maDH && t.MANL == maNL).FirstOrDefault();
            ff.QL_ChiTietNhapHangs.DeleteOnSubmit(c);
            ff.SubmitChanges();
        }

        // kiểm tra trùng nguyên liệu
        public Boolean ktTrung(string maPhieu,string maNL)
        {
            if (ff.QL_ChiTietNhapHangs.Where(t => t.MANL == maNL && t.MAHDNH == maPhieu).Count() != 0)
                return false;
            else
                return true;
        }

        // Sửa chi tiết
        public void suaChiTiet(string maDH, string maNL, string dvt, int soLuong, int donGia)
        {
            QL_ChiTietNhapHang n = ff.QL_ChiTietNhapHangs.Where(t => t.MAHDNH == maDH && t.MANL == maNL).FirstOrDefault();
            n.DVT = dvt;
            n.SoLuong = soLuong;
            n.DonGia = donGia;
            ff.SubmitChanges();
        }
        #endregion 
    }
}
