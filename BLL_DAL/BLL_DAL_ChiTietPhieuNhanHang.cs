using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_ChiTietPhieuNhanHang
    {
        #region properties
        DBlinqDataContext ff = new DBlinqDataContext();
        #endregion

        #region method      

        public BLL_DAL_ChiTietPhieuNhanHang()
        {
            //empty
        }
        
        // load data chi tiết phiếu nhận theo mã
        public IQueryable chiTietPhieuNhan(string maPN)
        {
            IQueryable ct = from c in ff.QL_ChiTietPhieuNhans
                            where c.MaPhieuNhan == maPN
                            select new { c.MaPhieuNhan, c.MaNL, c.Soluong, c.DonGia, c.DonViTinh };
            return ct;
        }

        // thêm chi tiết phiếu nhận
        public void themCTPhieuNhan(string maPN, string maNL, int soLuong,int donGia,string dvt )
        {
            QL_ChiTietPhieuNhan ct = new QL_ChiTietPhieuNhan();
            ct.MaPhieuNhan = maPN;
            ct.MaNL = maNL;
            ct.Soluong = soLuong;
            ct.DonGia = donGia;
            ct.DonViTinh = dvt;
            ff.QL_ChiTietPhieuNhans.InsertOnSubmit(ct);
            ff.SubmitChanges();
        }


        // xóa chi tiết phiếu nhận
        public void xoaCTPhieuNhan(string maPN,string maNL)
        {
            QL_ChiTietPhieuNhan ct = ff.QL_ChiTietPhieuNhans.Where(t=>t.MaPhieuNhan==maPN & t.MaNL == maNL).FirstOrDefault();
            ff.QL_ChiTietPhieuNhans.DeleteOnSubmit(ct);
            ff.SubmitChanges();
        }
        // sửa chi tiết phiếu nhận

        public void suaCTPhieuNhan(string maPN, string maNL, int soLuong, int donGia, string dvt)
        {
            QL_ChiTietPhieuNhan ct = ff.QL_ChiTietPhieuNhans.Where(t => t.MaPhieuNhan == maPN & t.MaNL == maNL).FirstOrDefault();;
            ct.Soluong = soLuong;
            ct.DonGia = donGia;
            ct.DonViTinh = dvt;
            ff.SubmitChanges();
        }

        // kiểm tra trùng nguyên liệu
        public Boolean ktTrung(string maNL, string maPN)
        {
            if (ff.QL_ChiTietPhieuNhans.Where(t => t.MaNL == maNL && t.MaPhieuNhan ==maPN).Count() != 0)
                return false;
            else
                return true;
        }
        #endregion
    }
}
