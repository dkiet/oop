using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_05
{
    public class HangThucPham
    {
        private string maHang;
        private string tenHang;
        private double donGia;
        private DateTime ngaySanXuat;
        private DateTime ngayHetHan;

        public string getMaHang()
        {
            return maHang;
        }

        private void setMaHang(string maHang)
        {
            if (!string.IsNullOrEmpty(maHang))
            {
                this.maHang = maHang;
            }
            else
            {
                throw new Exception("Lỗi: Mã hàng rỗng!");
            }
        }

        public string getTenHang()
        {
            return tenHang;
        }

        public void setTenHang(string tenHang)
        {
            if (!string.IsNullOrEmpty(tenHang))
            {
                this.tenHang = tenHang;
            }
            else
            {
                this.tenHang = "xxx";
            }
        }

        public double getDonGia()
        {
            return donGia;
        }

        public void setDongGia(double donGia)
        {
            if (donGia > 0)
            {
                this.donGia = donGia;
            }
            else
            {
                this.donGia = 0;
            }
        }

        public DateTime getNgaySanXuat()
        {
            return ngaySanXuat;
        }

        public void setNgaySanXuat(DateTime ngaySanXuat)
        {
            if (DateTime.Compare(ngaySanXuat, DateTime.Now) < 0)
            {
                this.ngaySanXuat = ngaySanXuat;
            }
            else
            {
                this.ngaySanXuat = DateTime.Now;
            }
        }

        public DateTime getNgayHetHan()
        {
            return ngayHetHan;
        }

        public void setNgayHetHan(DateTime ngayHetHan)
        {
            if (DateTime.Compare(ngayHetHan, ngaySanXuat) > 0)
            {
                this.ngayHetHan = ngayHetHan;
            }
            else
            {
                this.ngayHetHan = this.ngaySanXuat;
            }
        }

        public HangThucPham(string maHang, string tenHang, double donGia, DateTime ngaySanXuat, DateTime ngayHetHan)
        {
            if (!string.IsNullOrEmpty(maHang))
            {
                this.maHang = maHang;
            }
            else
            {
                throw new Exception("Lỗi: Mã hàng rỗng!");
            }
            if (!string.IsNullOrEmpty(tenHang))
            {
                this.tenHang = tenHang;
            }
            else
            {
                this.tenHang = "xxx";
            }
            if (donGia > 0)
            {
                this.donGia = donGia;
            }
            else
            {
                this.donGia = 0;
            }
            if (DateTime.Compare(ngaySanXuat, DateTime.Now) < 0)
            {
                this.ngaySanXuat = ngaySanXuat;
            }
            else
            {
                this.ngaySanXuat = DateTime.Now;
            }
            if (DateTime.Compare(ngayHetHan, ngaySanXuat) > 0)
            {
                this.ngayHetHan = ngayHetHan;
            }
            else
            {
                this.ngayHetHan = this.ngaySanXuat;
            }
        }

        public HangThucPham(string maHang)
        {
            if (!string.IsNullOrEmpty(maHang))
            {
                this.maHang = maHang;
            }
            else
            {
                throw new Exception("Lỗi: Mã hàng rỗng!");
            }
        }

        public bool KiemTraHetHan()
        {
            if (DateTime.Compare(this.ngayHetHan, DateTime.Now) < 0)
            {
                //Đã hết hạn
                return false;
            }
            else
            {
                //chưa hết hạn
                return true;
            }
        }
        public void toString()
        {
            string kiemTraHetHan = "";
            if (KiemTraHetHan() == true)
            {
                kiemTraHetHan = "Chưa hết hạn";
            }
            else
            {
                kiemTraHetHan = "Đã hết hạn";
            }
            string result = string.Format("{0, -10}{1, 15}{2, 30}{3, 20}{4, 20}{5, 20}", this.maHang, this.tenHang, String.Format("{0:n}", this.donGia) + " VND", this.ngaySanXuat.ToString("dd/MM/yyyy"), this.getNgayHetHan().ToString("dd/MM/yyyy"), kiemTraHetHan);
            Console.WriteLine(result);
        }
    }
}
