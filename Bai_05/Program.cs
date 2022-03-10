using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string ngaySanXuat_01_str = "01/09/2000";
            DateTime ngaySanXuat_01_date =
                DateTime.ParseExact(ngaySanXuat_01_str, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string ngayHetHan_01_str = "01/10/2000";
            DateTime ngayHetHan_01_date =
                DateTime.ParseExact(ngayHetHan_01_str, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            HangThucPham hangThucPham_01 = new HangThucPham("01", "Pepsi", 10000, ngaySanXuat_01_date, ngayHetHan_01_date);

            //Ngày hết hạn trước ngày sản xuất
            string ngaySanXuat_02_str = "01/09/2000";
            DateTime ngaySanXuat_02_date =
                DateTime.ParseExact(ngaySanXuat_02_str, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string ngayHetHan_02_str = "01/08/2000";
            DateTime ngayHetHan_02_date =
                DateTime.ParseExact(ngayHetHan_02_str, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            HangThucPham hangThucPham_02 = new HangThucPham("02", "Cocacola", 15000, ngaySanXuat_02_date, ngayHetHan_02_date);

            string ngaySanXuat_03_str = "01/09/2000";
            DateTime ngaySanXuat_03_date =
                DateTime.ParseExact(ngaySanXuat_03_str, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string ngayHetHan_03_str = "25/10/2022";
            DateTime ngayHetHan_03_date =
                DateTime.ParseExact(ngayHetHan_03_str, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            HangThucPham hangThucPham_03 = new HangThucPham("03", "7UP", 20000, ngaySanXuat_03_date, ngayHetHan_03_date);

            string result = string.Format("{0, -10}{1, 15}{2, 30}{3, 20}{4, 20}{5, 20}", "Mã hàng", "Tên hàng", "Đơn giá", "Ngày sản xuất", "Ngày hết hạn", "Ghi chú");
            Console.WriteLine(result);

            hangThucPham_01.toString();
            hangThucPham_02.toString();
            hangThucPham_03.toString();
            Console.ReadKey();
        }
    }
}
