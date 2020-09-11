using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_PhieuDatHang
    {
        #region properties
        DBlinqDataContext ff = new DBlinqDataContext();
        #endregion

        #region method
        public BLL_DAL_PhieuDatHang()
        {
            //empty
        }

        // Kiểm tra mã phiếu
        public bool kT(string ma)
        {
            if (ff.QL_HoaDon_NhapHangs.Where(t => t.MaHDNH == ma).Count() != 0)
            {
                return false;
            }
            else
                return true;
        }

        // load tất cả phiếu đặt hàng
        public IQueryable loadPhieuDatHang()
        {
            return ff.QL_HoaDon_NhapHangs.Select(t => new { t.MaHDNH, t.MANCC, t.NgayNhap,t.TongTien, t.MAND, t.PhuongThuc, t.TinhTrang });
        }

        // Tạo mã hóa đơn
        public String taoMaPhieuDatHang()
        {
            int so = ff.QL_HoaDon_NhapHangs.Select(t => t.MaHDNH).Count() + 1;

            if (so < 10)
            {
                return "PDH0" + so;
            }
            else
                return "PHD" + so;
        }

        // thêm hóa đơn nhập hàng
        public void themPhieuDatHang(string maPDH, string maNCC, DateTime ngayNhap, int tongTien, string maND, string phuongThuc, string tinhTrang)
        {
            QL_HoaDon_NhapHang nh = new QL_HoaDon_NhapHang();
            nh.MaHDNH = maPDH;
            nh.MANCC = maNCC;
            nh.NgayNhap = ngayNhap;
            nh.TongTien = tongTien;
            nh.MAND = maND;
            nh.PhuongThuc = phuongThuc;
            nh.TinhTrang = tinhTrang;
            ff.QL_HoaDon_NhapHangs.InsertOnSubmit(nh);
            ff.SubmitChanges();
        }

        //Sửa hóa đơn nhập hàng
        public void suaPhieuDatHang(string maPDH, string maNCC, DateTime ngayNhap, int tongTien, string maND, string phuongThuc, string tinhTrang)
        {
            QL_HoaDon_NhapHang nh = ff.QL_HoaDon_NhapHangs.Where(t => t.MaHDNH == maPDH).FirstOrDefault();
            nh.MANCC = maNCC;
            nh.NgayNhap = ngayNhap;
            nh.TongTien = tongTien;
            nh.MAND = maND;
            nh.PhuongThuc = phuongThuc;
            nh.TinhTrang = tinhTrang;
            ff.SubmitChanges();
        }

        // Cập nhật tổng tiền cho phiếu đặt hàng
        public void capNhatTongTien(string maPDH,int tong)
        {
            QL_HoaDon_NhapHang nh = ff.QL_HoaDon_NhapHangs.Where(t => t.MaHDNH == maPDH).FirstOrDefault();
            nh.TongTien = tong;
            ff.SubmitChanges();
        }

        // Xóa phiếu đặt hàng
        public void xoaPhieuDathang(string maPDH)
        {
            QL_HoaDon_NhapHang nh = ff.QL_HoaDon_NhapHangs.Where(t => t.MaHDNH == maPDH).FirstOrDefault();
            ff.QL_HoaDon_NhapHangs.DeleteOnSubmit(nh);
            ff.SubmitChanges();
        }
        #endregion 
    }
}
