using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Xe 1 mặc định
            Vehicle vehicle_01 = new Vehicle("Dương Văn Kiệt", "Honda Civic", 500000000, 250);
            //Xe 2 mặc định
            Vehicle vehicle_02 = new Vehicle("Nguyễn Văn A", "Toyota Camry", 1200000000, 300);
            //Xe 3 do người dùng nhập
            Vehicle vehicle_03 = new Vehicle();
            int xyLanh;
            double triGiaXe;
            Console.Write("Nhập tên chủ xe: ");
            vehicle_03.setChuXe(Console.ReadLine());
            Console.Write("Nhập loại xe: ");
            vehicle_03.setLoaiXe(Console.ReadLine());
            Console.Write("Nhập giá trị xe: ");
            bool successTriGiaXe = double.TryParse(Console.ReadLine(), out triGiaXe);
            while (!successTriGiaXe)
            {
                Console.Write("Giá trị xe là một số thực. Mời bạn nhập giá trị xe: ");
                successTriGiaXe = double.TryParse(Console.ReadLine(), out triGiaXe);
            }
            Console.Write("Nhập dung tích xe: ");
            bool successXyLanh = int.TryParse(Console.ReadLine(), out xyLanh);
            while (!successXyLanh)
            {
                Console.Write("Dung tích xe là một số nguyên. Nhập dung tích xe: ");
                successXyLanh = int.TryParse(Console.ReadLine(), out xyLanh);
            }
            vehicle_03.setXyLanh(xyLanh);
            vehicle_03.setTriGiaXe(triGiaXe);
            string result = string.Format("{0, -20}{1, 20}{2, 20}{3, 20}{4, 20}", "Tên chủ xe", "Loại xe", "Dung tích", "Trị giá xe", "Thuế phải nộp");
            Console.WriteLine(result);
            vehicle_01.toString();
            vehicle_02.toString();
            vehicle_03.toString();
            Console.ReadKey();
        }
    }
}
