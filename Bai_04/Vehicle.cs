using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_04
{
    public class Vehicle
    {
        private string chuXe;
        private string loaiXe;
        private double triGiaXe;
        private int xyLanh;
        public string getChuXe()
        {
            return chuXe;
        }
        public void setChuXe(string chuXe)
        {
            this.chuXe = chuXe;
        }
        public string getLoaiXe()
        {
            return loaiXe;
        }
        public void setLoaiXe(string loaiXe)
        {
            this.loaiXe = loaiXe;
        }
        public double getTriGiaXe()
        {
            return triGiaXe;
        }
        public void setTriGiaXe(double triGiaXe)
        {
            this.triGiaXe = triGiaXe;
        }
        public int getXyLanh()
        {
            return xyLanh;
        }
        public void setXyLanh(int xyLanh)
        {
            this.xyLanh = xyLanh;
        }
        public Vehicle()
        {

        }
        public Vehicle(string chuXe, string loaiXe, double triGiaXe, int xyLanh)
        {
            this.chuXe = chuXe;
            this.loaiXe = loaiXe;
            this.triGiaXe = triGiaXe;
            this.xyLanh = xyLanh;
        }

        public double Thue()
        {
            if (this.xyLanh < 100)
            {
                return triGiaXe * 0.01;
            }
            else
            {
                if (this.xyLanh < 200)
                {
                    return triGiaXe * 0.03;
                }
                else
                {
                    return triGiaXe * 0.05;
                }
            }
        }

        public void toString()
        {
            string result = string.Format("{0, -20}{1, 20}{2, 20}{3, 20}{4, 20}", this.chuXe, this.loaiXe, this.xyLanh, this.triGiaXe, this.Thue());
            Console.WriteLine(result);
        }
    }
}
