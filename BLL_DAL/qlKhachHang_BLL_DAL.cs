using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class qlKhachHang_BLL_DAL
    {
        #region Properties
        DBlinqDataContext qlkh = new DBlinqDataContext();
        #endregion

        #region Method
        
       



        public IQueryable<QL_KHACHHANG> loadGridViewKhachHang()
        {
            return qlkh.QL_KHACHHANGs.Select(kh => kh);
        }

        public IQueryable<QL_KHACHHANG> loadGridViewKhachHangTheoTen(string txtTimKiem)
        {
            var khachhang = from kh in qlkh.QL_KHACHHANGs
                            where kh.MaKH.Contains(txtTimKiem) ||
                            kh.HoTen.Contains(txtTimKiem) ||
                            kh.SDT.Contains(txtTimKiem) ||
                            kh.CMND.Contains(txtTimKiem)
                            select kh;
            return khachhang;

            //return qlkh.QL_KHACHHANGs.Where(kh => kh.HoTen.Contains(tenkh)).Select(kh => kh);
        }

        public QL_KHACHHANG loadGridViewTimKiemPOSKhachHang(string txtTimKiem)
        {
            var khachhang = (from kh in qlkh.QL_KHACHHANGs
                            where kh.MaKH.Contains(txtTimKiem) ||
                            kh.HoTen.Contains(txtTimKiem) ||
                            kh.SDT.Contains(txtTimKiem) ||
                            kh.CMND.Contains(txtTimKiem)
                            select kh).FirstOrDefault();
            return khachhang;

            //return qlkh.QL_KHACHHANGs.Where(kh => kh.HoTen.Contains(tenkh)).Select(kh => kh);
        }

        public int demSoLuongKhachHang()
        {
            return qlkh.QL_KHACHHANGs.Select(kh => kh).Count();
        }

        public int kiemtrakhoachinh(string makh)
        {
            var khachhang = (from kh in qlkh.QL_KHACHHANGs
                             where kh.MaKH.Equals(makh)
                             select kh).FirstOrDefault();

            if (khachhang != null)
            {
                return -1;
            }
            return 1;

        }

        public int kiemtraSoDienThoaiTonTai(string sdt)
        {
            var khachhang = (from kh in qlkh.QL_KHACHHANGs
                             where kh.SDT.Equals(sdt)
                             select kh).FirstOrDefault();

            if (khachhang != null)
            {
                return -1;
            }
            return 1;

        }

        public void themKhachHang(string makh, string hoten, string sodt, string cmnd)
        {
            QL_KHACHHANG insertkh = new QL_KHACHHANG();
            insertkh.MaKH = makh;
            insertkh.HoTen = hoten;
            insertkh.SDT = sodt;
            insertkh.CMND = cmnd;
            insertkh.DiemSo = 0;
            qlkh.QL_KHACHHANGs.InsertOnSubmit(insertkh);
            qlkh.SubmitChanges();
        }

        public void suaKhachHang(string makh, string hoten, string sodt, string cmnd, int diem)
        {
            QL_KHACHHANG updateKhachHang = qlkh.QL_KHACHHANGs.Where(t => t.MaKH== makh).FirstOrDefault();
            if(updateKhachHang != null)
            {
                updateKhachHang.HoTen = hoten;
                updateKhachHang.SDT = sodt;
                updateKhachHang.CMND = cmnd;
                updateKhachHang.DiemSo = diem;
                
            }
            qlkh.SubmitChanges();
            
        }

        public void CapNhapDiem(string makh, int diem)
        {
            QL_KHACHHANG updateKhachHang = qlkh.QL_KHACHHANGs.Where(t => t.MaKH == makh).FirstOrDefault();
            if (updateKhachHang != null)
            {
                updateKhachHang.DiemSo = diem;
            }
            qlkh.SubmitChanges();

        }

        public void xoaKhachHang(string makh)
        {
            QL_KHACHHANG deleteKhachHang = qlkh.QL_KHACHHANGs.Where(t => t.MaKH == makh).FirstOrDefault();
            if (deleteKhachHang != null)
            {
                qlkh.QL_KHACHHANGs.DeleteOnSubmit(deleteKhachHang);
            }
            qlkh.SubmitChanges();

        }


        public IQueryable<QL_HoaDon_BanHang> loadDonHangTheoKhachHang(string makh)
        {
            return qlkh.QL_HoaDon_BanHangs.Where(kh => kh.MAKH==makh).Select(kh => kh);
           
        }


        public IQueryable<QL_SanPham> loadSanPham(string makh)
        {
            var sanpham = (from sp in qlkh.QL_SanPhams
                          join ct_hd in qlkh.QL_ChiTietHoaDons on sp.MaSP equals ct_hd.MaSP
                          join hd_kh in qlkh.QL_HoaDon_BanHangs on ct_hd.MaHD equals hd_kh.MaHD
                          where hd_kh.MAKH == makh
                          select sp).Distinct();
            return sanpham;


        }



        #endregion



    }
}
