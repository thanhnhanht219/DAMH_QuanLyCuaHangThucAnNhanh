using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class HoaDon_BLL_DLL
    {
        DBlinqDataContext qlhd = new DBlinqDataContext();

        public HoaDon_BLL_DLL()
        {

        }

        public int demHD()
        {
            return qlhd.QL_HoaDon_BanHangs.Select(t => t).Count();
        }

        public bool ktKhoaChinhHD(string maHD)
        {
            return qlhd.QL_HoaDon_BanHangs.SingleOrDefault(t => t.MaHD == maHD) == null ? true : false;

        }

        public IQueryable<QL_HoaDon_BanHang> loadHoaDonTheoNgay(DateTime form, DateTime to)
        {
            var hoadon = from hd in qlhd.QL_HoaDon_BanHangs
                         where hd.NgayLap >= form && hd.NgayLap <= to
                         select hd;
            return hoadon;
        }

        public List<QL_HoaDon_BanHang> layDSHDTheoNgay(DateTime form, DateTime to)
        {
            var hoadon = from hd in qlhd.QL_HoaDon_BanHangs
                         where hd.NgayLap >= form && hd.NgayLap <= to
                         select hd;
            return hoadon.ToList();
        }

        public void xuatKho(DateTime from, DateTime to)
        {
            // so luong sp
            int slsp = 0;
            // so luong nguyen lieu de lam ra sp
            int slnl = 0;
            List<QL_HoaDon_BanHang> lstHD = layDSHDTheoNgay(from, to);

            foreach (QL_HoaDon_BanHang sp in lstHD)
            {
                if(sp.TinhTrang == true)
                {
                    continue;
                }
                else
                {
                    // lay tung san pham cua hoa don
                    foreach (QL_ChiTietHoaDon chitietHD in qlhd.QL_ChiTietHoaDons.Where(t => t.MaHD == sp.MaHD))
                    {                        

                        slsp = (int)chitietHD.Soluong;

                        // lay tung nguyen lieu cua san pham do
                        foreach(QL_NguyenLieu_SanPham nlsp in qlhd.QL_NguyenLieu_SanPhams.Where(t => t.MaSP == chitietHD.MaSP))
                        {
                            slnl = (int)nlsp.SoLuong;

                            QL_NguyenLieu nl = qlhd.QL_NguyenLieus.SingleOrDefault(t => t.MaNL == nlsp.MaNL);
                            nl.SoLuong -= slnl * slsp;
                            if(nl.SoLuong <= 0)
                            {
                                nl.SoLuong = 0;
                            }
                        }
                    }
                    sp.TinhTrang = true;
                }
                qlhd.SubmitChanges();
            }

        }

        public IQueryable<QL_HoaDon_BanHang> layHoaDon()
        {
            return qlhd.QL_HoaDon_BanHangs.Select(t => t);
        }

        public IQueryable<QL_ChiTietHoaDon> layChiTietHoaDon(string maHD)
        {
            return qlhd.QL_ChiTietHoaDons.Where(t => t.MaHD == maHD);
        }


        public IQueryable<QL_HoaDon_BanHang> loadGridViewTimKiemHoaDon(string txtTimKiem)
        {
            var hoadon = from hd in qlhd.QL_HoaDon_BanHangs
                            where hd.MaHD.Contains(txtTimKiem) ||
                            hd.MaND.Contains(txtTimKiem) ||
                            hd.MAKH.Contains(txtTimKiem) ||
                            hd.PhuongThuc.Contains(txtTimKiem)
                         select hd;
            return hoadon;

            //return qlkh.QL_KHACHHANGs.Where(kh => kh.HoTen.Contains(tenkh)).Select(kh => kh);
        }

        public string taoMaHD()
        {
            string maHD;

            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day.ToString();

            string random = new Random().Next(1, 10000).ToString();

            maHD = year + month + day + random;
            while (!ktKhoaChinhHD(maHD))
            {
                    maHD = taoMaHD();
            }
            return maHD;
        }

        public bool themHoaDon(List<QL_ChiTietHoaDon> lstCT,string maHD, string maND, string maKH, string PhuongThuc, string tienDua, string tienThua, double TongCong)
        {
            try
            {             

                QL_HoaDon_BanHang newHD = new QL_HoaDon_BanHang();
                newHD.MaHD = maHD;
                newHD.MaND = maND;

                newHD.MAKH = maKH.Length != 0 ? maKH : "NULL";
               
                newHD.NgayLap = DateTime.Now.Date;
                newHD.PhuongThuc = PhuongThuc;
                newHD.TienDua = Convert.ToInt32(tienDua);
                newHD.TienThua = Convert.ToInt32(tienThua);
                newHD.TongCong = Convert.ToInt32(TongCong);
                qlhd.QL_HoaDon_BanHangs.InsertOnSubmit(newHD);
                qlhd.SubmitChanges();
                foreach (QL_ChiTietHoaDon item in lstCT)
                {
                    item.MaHD = maHD;
                    qlhd.QL_ChiTietHoaDons.InsertOnSubmit(item);
                }
                qlhd.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public QL_KHACHHANG layKH(string maKH)
        {
            return qlhd.QL_KHACHHANGs.SingleOrDefault(t => t.MaKH == maKH);
        }

        public QL_NguoiDung layND(string mand)
        {
            return qlhd.QL_NguoiDungs.SingleOrDefault(t => t.MaND == mand);
        }

        public QL_HoaDon_BanHang layHD(string hd)
        {
            return qlhd.QL_HoaDon_BanHangs.SingleOrDefault(t => t.MaHD == hd);
        }

        // lay danh sach san pham theo ngay thang nam
        public List<SanPham_ThongKe> layDSSPTheo(DateTime fromday , DateTime today)
        {
            var dsChitiet = from hd in qlhd.QL_HoaDon_BanHangs
                        from chitiet in qlhd.QL_ChiTietHoaDons
                        where hd.MaHD == chitiet.MaHD
                        && hd.NgayLap >= fromday && hd.NgayLap <= today
                        select chitiet;

            List<SanPham_ThongKe> lstSP = new List<SanPham_ThongKe>();
            List<QL_ChiTietHoaDon> lstChiTiet = dsChitiet.ToList();

            foreach (QL_ChiTietHoaDon chitiet in lstChiTiet)
            {  
                // kiem tra sp trung
                if (lstSP.Count(t => t.Masp == chitiet.MaSP) == 0)
                {
                    SanPham_ThongKe sptk = new SanPham_ThongKe();
                    sptk.Masp = chitiet.MaSP;
                    sptk.Soluong += (int)chitiet.Soluong;
                    sptk.Dongia = (int)chitiet.DonGia;
                    lstSP.Add(sptk);
                }
                else
                {
                    SanPham_ThongKe sptk = lstSP.SingleOrDefault(t => t.Masp == chitiet.MaSP);
                    sptk.Soluong += (int)chitiet.Soluong;
                }
            }

            return lstSP;
        }
        
        public List<QL_SanPham> laySPhetNL()
        {
            List<QL_SanPham> sptk = new List<QL_SanPham>();
            foreach (QL_SanPham sp in qlhd.QL_SanPhams)
            {
                foreach (QL_NguyenLieu_SanPham nlsp in qlhd.QL_NguyenLieu_SanPhams.Where(t => t.MaSP == sp.MaSP))
                {
                    int soluong = (int)qlhd.QL_NguyenLieus.SingleOrDefault(t => t.MaNL == nlsp.MaNL).SoLuong;
                    if(soluong == 0)
                    {
                        sptk.Add(sp);
                    }
                }
            }
            return sptk;
        }
           
    }
}
