using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Toạ độ mặc định
            ToaDo toaDo_01 = new ToaDo(1, 3, "X");
            //Toạ độ do người dùng nhập
            ToaDo toaDo_02 = new ToaDo();
            Console.Write("Mời bạn nhập toạ độ x: ");
            int toaDoX, toaDoY;
            bool successToaDoX = int.TryParse(Console.ReadLine(), out toaDoX);
            while (!successToaDoX)
            {
                Console.Write("Toạ độ x phải là số nguyên. Mời bạn nhập toạ độ x: ");
                successToaDoX = int.TryParse(Console.ReadLine(), out toaDoX);
            }
            Console.Write("Mời bạn nhập toạ độ y: ");
            bool successToaDoY = int.TryParse(Console.ReadLine(), out toaDoY);
            while (!successToaDoY)
            {
                Console.Write("Toạ độ y phải là số nguyên. Mời bạn nhập toạ độ y: ");
                successToaDoY = int.TryParse(Console.ReadLine(), out toaDoX);
            }
            Console.Write("Mời bạn nhập tên toạ độ: ");
            toaDo_02.setToaDoX(toaDoX);
            toaDo_02.setToaDoY(toaDoY);
            toaDo_02.setTenToaDo(Console.ReadLine());
            Console.WriteLine("Các toạ độ là: ");
            Console.WriteLine("\t" + toaDo_01.toString());
            Console.WriteLine("\t" + toaDo_02.toString());
            Console.ReadKey();
        }
    }
}
