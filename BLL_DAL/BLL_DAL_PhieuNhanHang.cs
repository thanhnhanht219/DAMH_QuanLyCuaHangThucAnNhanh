using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_PhieuNhanHang
    {
        #region properties
        DBlinqDataContext ff = new DBlinqDataContext();
        #endregion

        #region method
        public BLL_DAL_PhieuNhanHang()
        {
            //empty
        }

        // Kiểm tra mã phiếu
        public bool kT(string ma)
        {
            if (ff.QL_PhieuNhans.Where(t => t.MaPhieuNhan == ma).Count() != 0)
            {
                return false;
            }
            else
                return true;
        }

        // cập nhật tổng tiền
        public void capNhatTong(string maPhieuNhan,int tong)
        {
            QL_PhieuNhan p = ff.QL_PhieuNhans.Where(t => t.MaPhieuNhan == maPhieuNhan).SingleOrDefault();
            p.TongTien = tong;
            ff.SubmitChanges();
        }

        // load phiếu nhận hàng
        public IQueryable load_PhieuNhan()
        {
            return ff.QL_PhieuNhans.Select(t => new {t.MaPhieuNhan,t.MaHDNH,t.NgayNhan,t.TongTien });
        }

        // tự sinh mã phiếu nhận
        public String taoMaPhieuNhanHang()
        {
            int so = ff.QL_PhieuNhans.Select(t => t.MaPhieuNhan).Count() + 1;

            if (so < 10)
            {
                return "PNH0" + so;
            }
            else
                return "PNHD" + so;
        }

        // thêm phiếu nhận
        public void themPhieuNhan(string maPhieuNhan, string maPhieuDH, DateTime ngay, int tong)
        {
            QL_PhieuNhan p = new QL_PhieuNhan();
            p.MaPhieuNhan = maPhieuNhan;
            p.MaHDNH = maPhieuDH;
            p.NgayNhan = ngay;
            p.TongTien = tong;
            ff.QL_PhieuNhans.InsertOnSubmit(p);
            ff.SubmitChanges();
        }

        // xóa phiếu nhận
        public void xoaPhieuNhan(string maPhieuNhan)
        {
            QL_PhieuNhan p = ff.QL_PhieuNhans.Where(t => t.MaPhieuNhan == maPhieuNhan).SingleOrDefault();
            ff.QL_PhieuNhans.DeleteOnSubmit(p);
            ff.SubmitChanges();
        } 

        // sửa phiếu nhận
        public void suaPhieuNhan(string maPhieuNhan, string maPhieuDH, DateTime ngay, int tong)
        {
            QL_PhieuNhan p = ff.QL_PhieuNhans.Where(t => t.MaPhieuNhan == maPhieuNhan).SingleOrDefault();
            p.TongTien = tong;
            p.NgayNhan = ngay;
            p.MaHDNH = maPhieuDH;
            ff.SubmitChanges();
        }
        #endregion
    }
}
