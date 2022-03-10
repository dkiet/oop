using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_03
{
    public class TamGiac
    {
        private int ma;
        private int mb;
        private int mc;

        public int getMA()
        {
            return ma;
        }
        public void setMA(int ma)
        {
            if (ma > 0)
            {
                this.ma = ma;
            }
        }
        public int setMB()
        {
            return mb;
        }
        public void setMB(int mb)
        {
            if (mb > 0)
            {
                this.mb = mb;
            }
        }
        public int getMC()
        {
            return mc;
        }
        public void setMC(int mc)
        {
            if (mc > 0)
            {
                this.mc = mc;
            }
        }

        public TamGiac()
        {

        }

        public TamGiac(int ma, int mb, int mc)
        {
            if (ma < 0 || mb < 0 || mc < 0)
            {
                this.ma = 0;
                this.mb = 0;
                this.mc = 0;
            }
            else
            {
                if (ma + mb < mc || ma + mc < mb || mb + mc < ma)
                {
                    this.ma = 0;
                    this.mb = 0;
                    this.mc = 0;
                }
                else
                {
                    this.ma = ma;
                    this.mb = mb;
                    this.mc = mc;
                }
            }
        }

        public int ChuVi()
        {
            return ma + mb + mc;
        }

        public double DienTich()
        {
            double nuaChuVi = (ma + mb + mc) * 1.0 / 2;
            return Math.Sqrt(nuaChuVi * (nuaChuVi - ma) * (nuaChuVi - mb) * (nuaChuVi - mc));
        }

        public int ThongTinTamGiac()
        {
            if (ma + mb < mc || ma + mc < mb || mb + mc < ma)
            {
                //Không phải tam giác
                return 0;
            }
            else
            {
                if (ma == mb && mb == mc)
                {
                    //Tam giác đều
                    return 1;
                }
                else if (ma == mb || mb == mc || mc == ma)
                {
                    //Tam giác cân
                    return 2;
                }
                else
                {
                    //Tam giác thường
                    return 3;
                }
            }
        }

        public void toString()
        {
            string thongTinTG = "";           
            if (ThongTinTamGiac() == 0)
            {
                thongTinTG = "Không phải tam giác";
            }
            if (ThongTinTamGiac() == 1)
            {
                thongTinTG = "Tam giác đều";
            }
            if (ThongTinTamGiac() == 2)
            {
                thongTinTG = "Tam giác cân";
            }
            if (ThongTinTamGiac() == 3)
            {
                thongTinTG = "Tam giác thường";
            }
            if (ma == 0 || mb == 0 || mc == 0)
            {
                thongTinTG = "Không phải tam giác";
            }
            string result = string.Format("{0, -10}{1, 10}{2, 10}{3, 30}{4, 20}{5, 20}", this.ma, this.mb, this.mc, thongTinTG, this.ChuVi(), this.DienTich());
            Console.WriteLine(result);
        }
    }
}
