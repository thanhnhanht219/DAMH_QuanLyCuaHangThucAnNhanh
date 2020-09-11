using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class qlNhaCungCap_BLL_DAL
    {

        #region properties
        DBlinqDataContext data = new DBlinqDataContext();
        #endregion

        #region method
        public IQueryable<QL_NhaCungCap> loadDataGridViewNhaCungCap()
        {
            return data.QL_NhaCungCaps.Select(ncc => ncc);
        }


        public int kiemtrakhoachinh(string mancc)
        {
            var nhacc = (from kh in data.QL_NhaCungCaps
                             where kh.MaNCC.Equals(mancc)
                             select kh).FirstOrDefault();

            if (nhacc != null)
            {
                return -1;
            }
            return 1;
        }


        public void themNhaCungCap(string mancc, string tenncc, string diachi, string sdt, string email)
        {
            QL_NhaCungCap insert = new QL_NhaCungCap();
            insert.MaNCC= mancc;
            insert.TenNCC = tenncc;
            insert.DiaChi = diachi;
            insert.SDT = sdt;
            insert.Email = email;
            data.QL_NhaCungCaps.InsertOnSubmit(insert);
            data.SubmitChanges();
        }


        public void suaKhachHang(string mancc, string tenncc, string diachi, string sdt, string email)
        {
            QL_NhaCungCap update = data.QL_NhaCungCaps.Where(t => t.MaNCC == mancc).FirstOrDefault();
            if (update != null)
            {
                update.TenNCC = tenncc;
                update.DiaChi = diachi;
                update.SDT = sdt;
                update.Email = email;
            }
            data.SubmitChanges();
        }

        public void xoaKhachHang(string mancc)
        {
            QL_NhaCungCap delete = data.QL_NhaCungCaps.Where(t => t.MaNCC == mancc).FirstOrDefault();
            if (delete != null)
            {
                data.QL_NhaCungCaps.DeleteOnSubmit(delete);
            }
           data.SubmitChanges();

        }


        public IQueryable<QL_NhaCungCap> loadTimKiemGridViewNhaCungCap(string txtTimKiem)
        {
            var nhacungcap = from ncc in data.QL_NhaCungCaps
                            where ncc.MaNCC.Contains(txtTimKiem) ||
                            ncc.TenNCC.Contains(txtTimKiem) ||
                            ncc.SDT.Contains(txtTimKiem) ||
                            ncc.DiaChi.Contains(txtTimKiem) ||
                            ncc.Email.Contains(txtTimKiem)
                            select ncc;
            return nhacungcap;


        }
        #endregion
    }
}
