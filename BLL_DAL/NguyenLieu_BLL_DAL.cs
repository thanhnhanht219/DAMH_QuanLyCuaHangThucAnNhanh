using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
   public class NguyenLieu_BLL_DAL
   {
       #region Properties
       DBlinqDataContext ff = new DBlinqDataContext();
       #endregion

       #region Init
       public NguyenLieu_BLL_DAL()
       {

       }

       #endregion

       #region Method

       public IQueryable loadNguyenLieu()
       {
           return ff.QL_NguyenLieus.Select(t => new { t.MaNL, t.TenNL, t.DVT });
       }

       // lấy tất cả thông tin nguyên liệu cho form kho
       public IQueryable loadNguyenLieuFormKho()
       {
           IQueryable c = from nl in ff.QL_NguyenLieus
                          from l in ff.QL_LoaiNguyenLieus
                          where l.MaLoaiNL == nl.MaLoaiNL
                          select new
                          {
                              nl.MaNL,
                              nl.TenNL,
                              nl.DVT,
                              nl.SoLuong,
                              nl.ThoiHan,
                              l.TenLoai
                          };
           return c;
       }

       // Thêm Nguyên liệu
       public void themNguyenLieu(string maNL, string tenNL, string donVi, int soLuong, DateTime hanSD, string maLoaiNL)
       {
           QL_NguyenLieu nl = new QL_NguyenLieu();
           nl.MaNL = maNL;
           nl.TenNL = tenNL;
           nl.DVT = donVi;
           nl.SoLuong = soLuong;
           nl.ThoiHan = hanSD;
           nl.MaLoaiNL = maLoaiNL;
           ff.QL_NguyenLieus.InsertOnSubmit(nl);
           ff.SubmitChanges();
       }

       // Xóa Nguyên liệu
       public void xoaNguyenLieu(string maNL)
       {
           QL_NguyenLieu xoaNL = ff.QL_NguyenLieus.Where(n => n.MaNL == maNL).FirstOrDefault();
           if (xoaNL != null)
           {
               ff.QL_NguyenLieus.DeleteOnSubmit(xoaNL);
               ff.SubmitChanges();
           }
       }

       // Sửa nguyên liệu
       public void suaNguyenLieu(string maNL, string tenNL, string donVi, int soLuong, DateTime hanSD, string maLoaiNL)
       {
           QL_NguyenLieu suaNL = ff.QL_NguyenLieus.Where(n => n.MaNL == maNL).FirstOrDefault();
           if (suaNL != null)
           {
               suaNL.TenNL = tenNL;
               suaNL.DVT = donVi;
               suaNL.SoLuong = soLuong;
               suaNL.ThoiHan = hanSD;
               suaNL.MaLoaiNL = maLoaiNL;
               ff.SubmitChanges();
           }
       }

       // load combobox MaLoaiNL
       public IQueryable load_cboMaLoai()
       {
           return ff.QL_LoaiNguyenLieus.Select(t => t);
       }

       // Tự sinh mã nguyên liệu mới 
       public String taoMaNguyenLieu()
       {
           int so = ff.QL_NguyenLieus.Select(t => t.MaNL).Count() + 1;

           if (so < 10)
           {
               return "NL0" + so;
           }
           else
               return "NL" + so;
       }

       //Loc dữ liệu
       public IQueryable loadGridViewTheoHangHetDate(DateTime ngayht)
       {
           IQueryable nguyenlieu = from nl in ff.QL_NguyenLieus
                                   from l in ff.QL_LoaiNguyenLieus
                                   where l.MaLoaiNL == nl.MaLoaiNL
                                   && (nl.ThoiHan < ngayht && nl.SoLuong > 0)
                                   select new
                                   {
                                       nl.MaNL,
                                       nl.TenNL,
                                       nl.DVT,
                                       nl.SoLuong,
                                       nl.ThoiHan,
                                       l.TenLoai
                                   };
           return nguyenlieu;
       }

       public IQueryable loadGridViewTheoHangHetTrongKho()
       {
           IQueryable nguyenlieu = from nl in ff.QL_NguyenLieus
                                   from l in ff.QL_LoaiNguyenLieus
                                   where l.MaLoaiNL == nl.MaLoaiNL
                                   && (nl.SoLuong == 0)
                                   select new
                                   {
                                       nl.MaNL,
                                       nl.TenNL,
                                       nl.DVT,
                                       nl.SoLuong,
                                       nl.ThoiHan,
                                       l.TenLoai
                                   };
           return nguyenlieu;
           //return ff.QL_NguyenLieus.Where(f => f.SoLuong == 0).Select(f => f);
       }

       public IQueryable<QL_NguyenLieu> loadGridViewTatCa()
       {
           return ff.QL_NguyenLieus.Select(f => f);
       }

       public int kiemtrakhoachinh(string manl)
       {
           var nguyenlieu = (from nl in ff.QL_NguyenLieus
                             where nl.MaNL.Equals(manl)
                             select nl).FirstOrDefault();

           if (nguyenlieu != null)
           {
               return -1;
           }
           return 1;

       }


       public IQueryable loadGridViewNguyenLieuTimKiem(string txtTimKiem)
       {
           IQueryable nguyenlieu = from nl in ff.QL_NguyenLieus
                                   from l in ff.QL_LoaiNguyenLieus
                                   where l.MaLoaiNL == nl.MaLoaiNL
                                   && (nl.MaNL.Contains(txtTimKiem) ||
                                  nl.MaLoaiNL.Contains(txtTimKiem) ||
                                  nl.TenNL.Contains(txtTimKiem))
                                   select new
                                   {
                                       nl.MaNL,
                                       nl.TenNL,
                                       nl.DVT,
                                       nl.SoLuong,
                                       nl.ThoiHan,
                                       l.TenLoai
                                   };
           return nguyenlieu;

       }

       #endregion

    }
}
