using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_02
{
    public class SinhVien
    {
		private int maSinhVien;
		private string tenSinhVien;
		private double diemLyThuyet;
		private double diemThucHanh;
		public int getMaSinhVien()
		{
			return maSinhVien;
		}
		public void setMaSinhVien(int maSinhVien)
		{
            if (maSinhVien <= 0)
            {
				this.maSinhVien = 0;
            }
            else
            {
				this.maSinhVien = maSinhVien;
			}
		}

		public string getTenSinhVien()
		{
			return tenSinhVien;
		}
		public void setTenSinhVien(string tenSinhVien)
		{
			if (string.IsNullOrEmpty(tenSinhVien))
			{
				this.tenSinhVien = "Nguyễn Văn A";
			}
            else
            {
				this.tenSinhVien = tenSinhVien;
			}			
		}

		public double getDiemLyThuyet()
		{
			return diemLyThuyet;
		}
		public void setDiemLyThuyet(double diemLyThuyet)
		{
            if (diemLyThuyet < 0.0 || diemLyThuyet > 10.0)
            {
				diemLyThuyet = 0.0;
            }
            else
            {
				this.diemLyThuyet = diemLyThuyet;
			}
		}

		public double getDiemThucHanh()
		{
			return diemThucHanh;
		}
		public void setDiemThucHanh(double diemThucHanh)
		{
			if (diemThucHanh < 0.0 || diemThucHanh > 10.0)
			{
				diemThucHanh = 0.0;
			}
			else
			{
				this.diemThucHanh = diemThucHanh;
			}
		}

		public SinhVien()
        {
			this.maSinhVien = 0;
			this.tenSinhVien = "Nguyễn Văn B";
			this.diemLyThuyet = 0.0;
			this.diemThucHanh = 0.0;
		}

		public SinhVien(int maSinhVien, string tenSinhVien, double diemLyThuyet, double diemThucHanh)
		{
			this.maSinhVien = maSinhVien;
			this.tenSinhVien = tenSinhVien;
			this.diemLyThuyet = diemLyThuyet;
			this.diemThucHanh = diemThucHanh;
		}

		public double TinhDiemTrungBinh()
        {
			return (this.diemLyThuyet + this.diemThucHanh) / 2;
        }

		public void toString()
        {
			string result = string.Format("{0, -10}{1, 15}{2, 20}{3, 20}{4, 20}", this.maSinhVien, this.tenSinhVien, this.diemLyThuyet, this.diemThucHanh, this.TinhDiemTrungBinh());
			Console.WriteLine(result);
		}
	}
}
