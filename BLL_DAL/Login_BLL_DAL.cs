using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Login_BLL_DAL
    {
        #region Properties

        DBlinqDataContext ql = new DBlinqDataContext();

        #endregion

        #region Init
        public Login_BLL_DAL()
        {

        }

        #endregion

        #region method

        // kiem tra tai khoan
        
        public QL_NguoiDung layND(string mand)
        {
            return ql.QL_NguoiDungs.SingleOrDefault(t => t.MaND == mand);
        }

        public int ktTaiKhoan( string user , string password)
        {
            QL_NguoiDung nd = ql.QL_NguoiDungs.SingleOrDefault(t => t.MaND == user);

            if (nd != null)
            {
                if(nd.Password.Trim() == password.Trim())
                {
                    return 1;
                }
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public List<QL_PhanQuyen> lstPQ(string manhom)
        {
            return ql.QL_PhanQuyens.Where(t => t.MaNhom == manhom).ToList();
        }

        #endregion 
    }
}
