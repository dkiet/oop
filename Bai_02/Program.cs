using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Sinh viên mặc định 1
            SinhVien sv_01 = new SinhVien(1, "Dương Văn Kiệt", 8.2, 9.3);
            //Sinh viên mặc định 2
            SinhVien sv_02 = new SinhVien(2, "Nguyễn Văn Long", 9, 7.2);
            //Sinh viên nhập từ bàn phím
            int maSinhVien;
            string tenSinhVien;
            double diemLT, diemTH;
            Console.Write("Mời bạn nhập mã sinh viên: ");           
            bool successMaSV = int.TryParse(Console.ReadLine(), out maSinhVien);
            while (!successMaSV)
            {
                Console.Write("Mã sinh viên phải là số nguyên. Mời bạn nhập mã sinh viên: ");
                successMaSV = int.TryParse(Console.ReadLine(), out maSinhVien);
            }
            Console.Write("Mời bạn nhập tên sinh viên: ");
            tenSinhVien = Console.ReadLine();
            Console.Write("Mời bạn nhập điểm LT: ");
            bool successDiemLT = double.TryParse(Console.ReadLine(), out diemLT);
            while (!successDiemLT)
            {
                Console.Write("Điểm LT phải là số thực. Mời bạn nhập điểm LT: ");
                successDiemLT = double.TryParse(Console.ReadLine(), out diemLT);
            }
            Console.Write("Mời bạn nhập điểm TH: ");
            bool successDiemTH = double.TryParse(Console.ReadLine(), out diemTH);
            while (!successDiemTH)
            {
                Console.Write("Điểm TH phải là số thực. Mời bạn nhập điểm TH: ");
                successDiemTH = double.TryParse(Console.ReadLine(), out diemTH);
            }
            SinhVien sv_03 = new SinhVien();
            sv_03.setMaSinhVien(maSinhVien);
            sv_03.setTenSinhVien(tenSinhVien);
            sv_03.setDiemLyThuyet(diemLT);
            sv_03.setDiemThucHanh(diemTH);
            string result = string.Format("{0, -10}{1, 15}{2, 20}{3, 20}{4, 20}", "Mã SV", "Tên SV", "Điểm LT", "Điểm TH", "Điểm TB");
            Console.WriteLine(result);
            sv_01.toString();
            sv_02.toString();
            sv_03.toString();
            Console.ReadKey();
        }
    }
}
