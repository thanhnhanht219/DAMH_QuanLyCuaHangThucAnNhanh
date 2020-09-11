using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL_DAL
{
    public class QL_NhanSu_BLL_DAL
    {

        #region Properties
        DBlinqDataContext ch = new DBlinqDataContext();
        #endregion

        #region Init
        public QL_NhanSu_BLL_DAL()
        {

        }

        #endregion

          

       

        #region Method

        public IQueryable loadDataGridViewNhanVien()
        {
            return ch.QL_NguoiDungs.Select(t => t);
        }
           
        public IQueryable<QL_NhomNguoiDung> layNhomND()
        {
            return ch.QL_NhomNguoiDungs.Select(t => t);
        }
        
        // xoa nguoi dung
        public bool xoaNhomND(string manhom)
        {
            QL_NhomNguoiDung nnd = ch.QL_NhomNguoiDungs.SingleOrDefault(t => t.MaNhom == manhom);
           	        
		        if(ch.QL_PhanQuyens.Count(t => t.MaNhom == nnd.MaNhom) == 0 )
                {
                    foreach (QL_NguoiDung item in ch.QL_NguoiDungs.Where(t => t.MaNhom == nnd.MaNhom))
                    {
                        item.MaNhom = null;
                    }
                    ch.QL_NhomNguoiDungs.DeleteOnSubmit(nnd);                
                }

                else
                {
                    foreach (QL_PhanQuyen item in ch.QL_PhanQuyens.Where(t => t.MaNhom == nnd.MaNhom))
                    {
                        ch.QL_PhanQuyens.DeleteOnSubmit(item);
                    }

                    foreach (QL_NguoiDung item in ch.QL_NguoiDungs.Where(t => t.MaNhom == nnd.MaNhom))
                    {
                        item.MaNhom = null;
                    }
                    ch.QL_NhomNguoiDungs.DeleteOnSubmit(nnd);
                    submitChange();
                }
                return true;
	    
           
        }

        public bool themNhomND(QL_NhomNguoiDung nnd , List<QL_PhanQuyen> lstPQ)
        {
            try
            {
                ch.QL_NhomNguoiDungs.InsertOnSubmit(nnd);
                foreach (QL_PhanQuyen item in lstPQ)
                {
                  ch.QL_PhanQuyens.InsertOnSubmit(item);
                }
                
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool suaNhomND(QL_NhomNguoiDung nnd, List<QL_PhanQuyen> lstPQ)
        {
            try
            {
                QL_NhomNguoiDung nhom = ch.QL_NhomNguoiDungs.SingleOrDefault(t => t.MaNhom == nnd.MaNhom);
                nhom = nnd;
                if(lstPQ.Count == 0)
                {
                    submitChange();
                    return true;                    
                }
                else
                {
                    foreach (QL_PhanQuyen item in ch.QL_PhanQuyens.Where(t => t.MaNhom == nnd.MaNhom))
                    {
                        ch.QL_PhanQuyens.DeleteOnSubmit(item);
                    }
                    foreach (QL_PhanQuyen pq in lstPQ)
                    {
                        ch.QL_PhanQuyens.InsertOnSubmit(pq);
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public IQueryable<QL_ManHinh> layMH()
        {
            //return (from mh in ch.QL_ManHinhs
            //        from pq in ch.QL_PhanQuyens
            //        where mh.MaMH == pq.MaMH
            //        select new {mh.MaMH,mh.TenMH,p});
            return ch.QL_ManHinhs.Select(t => t);
        }
        public List<QL_PhanQuyen> layMH(string maNhom)
        {
            List<QL_ManHinh> lst = layMH().ToList<QL_ManHinh>() ;
            List<QL_PhanQuyen> lstPQ = ch.QL_PhanQuyens.Where(t=>t.MaNhom == maNhom).ToList<QL_PhanQuyen>();
            foreach (QL_ManHinh item in lst)
            {
                QL_PhanQuyen pq = lstPQ.SingleOrDefault(t => t.MaMH == item.MaMH);
                if (pq == null)
                    continue;
                pq.TenManHinh = item.TenMH;
            }
            return lstPQ;
        }
        public void submitChange()
        {
            ch.SubmitChanges();
        }

        public List<QL_NguoiDung> loadListNhanVien()
        {
            return ch.QL_NguoiDungs.Select(t => t).ToList<QL_NguoiDung>();
        }

        public IQueryable loadCboNhomNhanVien()
        {
            return ch.QL_NhomNguoiDungs.Select(t => t);
        }

        public void themNhanVien(string ma, string tennguoidung, string sdt, string cmnd, string diachi, string email,
            DateTime ngaysinnh, DateTime ngayVL, string manhom, bool hoatdong, string matkhau)
        {
            QL_NguoiDung nd = new QL_NguoiDung();
            nd.MaND = ma;
            nd.TenNguoiDung = tennguoidung;
            nd.SoDienThoai = sdt;
            nd.CMND = cmnd;
            nd.DiaChi = diachi;
            nd.Email = email;
            nd.NgaySinh = Convert.ToDateTime(ngaysinnh);
            nd.NgayVL = Convert.ToDateTime(ngayVL);
            nd.MaNhom = manhom;
            //nd.HoatDong = Convert.ToBoolean(hoatdong);
            nd.Password = matkhau;
            ch.QL_NguoiDungs.InsertOnSubmit(nd);
            ch.SubmitChanges();
        }

        public void suaNhanVien(string ma, string tennguoidung, string sdt, string cmnd, string diachi, string email,
           DateTime ngaysinnh, DateTime ngayVL, string manhom, bool hoatdong, string matkhau)
        {
            QL_NguoiDung nd = ch.QL_NguoiDungs.Where(t => t.MaND == ma).FirstOrDefault();
            if (nd != null)
            {
                nd.MaND = ma;
                nd.TenNguoiDung = tennguoidung;
                nd.SoDienThoai = sdt;
                nd.CMND = cmnd;
                nd.DiaChi = diachi;
                nd.Email = email;
                nd.NgaySinh = Convert.ToDateTime(ngaysinnh);
                nd.NgayVL = Convert.ToDateTime(ngayVL);
                nd.MaNhom = manhom;
                //nd.HoatDong = Convert.ToBoolean(hoatdong);
                nd.Password = matkhau;
            }
            ch.SubmitChanges();
        }

        public void xoaNhanVien(string ma)
        {
            QL_NguoiDung nd = ch.QL_NguoiDungs.Where(t => t.MaND == ma).FirstOrDefault();
            if (nd != null)
            {
                ch.QL_NguoiDungs.DeleteOnSubmit(nd);
            }
            ch.SubmitChanges();
        }

        public IQueryable<QL_NguoiDung> loadGridViewTimKiemNhanVien(string txtTimKiem)
        {
            var nguoidung = from nd in ch.QL_NguoiDungs
                            where nd.MaND.Contains(txtTimKiem) ||
                            nd.TenNguoiDung.Contains(txtTimKiem) ||
                            nd.SoDienThoai.Contains(txtTimKiem) ||
                            nd.CMND.Contains(txtTimKiem) ||
                            nd.Email.Contains(txtTimKiem) ||
                            nd.DiaChi.Contains(txtTimKiem)
                            select nd;
            return nguoidung;
        }


        public int demSoLuong()
        {
            return ch.QL_NguoiDungs.Select(kh => kh).Count();
        }

        public int kiemTraKhoaChinh(string s)
        {
            return ch.QL_NguoiDungs.Where(a => a.MaND == s).Select(nd => nd).Count();
        }

        public QL_NhomNguoiDung layNhomtheoMa(string manhom)
        {
            return ch.QL_NhomNguoiDungs.SingleOrDefault(t => t.MaNhom == manhom);
        }
        #endregion  
    }
}
