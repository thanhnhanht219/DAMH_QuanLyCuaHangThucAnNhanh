using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_NhaCungCap
    {
        DBlinqDataContext ff = new DBlinqDataContext();
        public BLL_DAL_NhaCungCap()
        {
            //empty
        }

        // load tất cả nhà cung cấp
        public IQueryable loadNhaCungCap()
        {
            return ff.QL_NhaCungCaps.Select(t=>t);
        }
    }
}
