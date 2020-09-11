using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class SanPham_Kmean
    {
        DBlinqDataContext qlsv = new DBlinqDataContext();
        List<SanPham_ThongKe> lstsp;
        List<double> dsCum;
        int[] dstam;
        int max, min;

        public SanPham_Kmean(List<SanPham_ThongKe> lstsp, int max, int min)
        {
            this.lstsp = lstsp;
            this.max = max;
            this.min = min;
            ganTamCum();
        }

        public void ganTamCum()
        { 
            int mid = (max + min) / 2;
            dstam = new int[] { max, mid, min };
        }


        public void Xuly(int kcum)
        {
            dsCum = new List<double>();

            for (int i = 1; i <= kcum; i++)
            {
                Random rd = new Random();
                int index = rd.Next(0, lstsp.Count - 1);
                if (lstsp[index].Cum != 0)
                {
                    i--;
                    continue;
                }
                int vitri = layViTriNganNhat(lstsp[index].Soluong);
                lstsp[index].Cum = i;
                dsCum.Add(lstsp[index].Soluong);
            }
       

            for (int i = 0; i < lstsp.Count; i++)
            {               
                for (int j = 1; j <= dsCum.Count; j++)
			    {
			        dsCum[j - 1] = TamCum(j);
			    }
                if (lstsp[i].Cum == 0)
                {
                    // tính khoảng cách 
                    double Khoangcach_min = 0;
                    int cum_min = 0;

                    for (int j = 1; j <= dsCum.Count; j++)
                    {
                        double? giatritamcum = dsCum[j-1];

                        double khoangcach = Math.Sqrt(Math.Pow(2.0, (giatritamcum.Value - lstsp[i].Soluong)));

                        if (j == 1)
                        {
                            Khoangcach_min = khoangcach;
                            cum_min = j;
                        }
                        else
                        {
                            if (khoangcach < Khoangcach_min)
                            {
                                Khoangcach_min = khoangcach;
                                cum_min = j;
                            }
                            else
                            {

                            }
                        }
                        lstsp[i].Cum = cum_min;
                    }
                }
            }
        }

        private int layViTriNganNhat(int p)
        {
            List<double> lst = new List<double>();
            for (int i = 0; i < dstam.Count(); i++)
            {
               double khoangcach = Math.Sqrt(Math.Pow(2.0, (dstam[i] - p)));
               lst.Add(khoangcach);
            }
            return lst.IndexOf(lst.Min(t => t));
            
        }
        public double TamCum(int cumK)
        {
            return lstsp.Where(t => t.Cum == cumK).Select(t => t.Soluong).Average();
        }

        public List<SanPham_ThongKe> laydsSP()
        {
            return lstsp;
        }

        public List<double> laydsCum()
        {
            return dsCum;
        }
    }

}
