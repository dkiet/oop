using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Tam giác vi phạm ràng buộc 1: có một cạnh là số âm
            TamGiac tamGiac_01 = new TamGiac(-10, 30, 12);
            //Tam giác vi phạm ràng buộc 2: không phải ba cạnh của một tam giác
            TamGiac tamGiac_02 = new TamGiac(5, 10, 22);
            //Tam giác thường
            TamGiac tamGiac_03 = new TamGiac(5, 10, 12);
            //Tam giác cân
            TamGiac tamGiac_04 = new TamGiac(5, 5, 7);
            //Tam giác đều
            TamGiac tamGiac_05 = new TamGiac(10, 10, 10);
            string result = string.Format("{0, -10}{1, 10}{2, 10}{3, 30}{4, 20}{5, 20}", "Cạnh 1", "Cạnh 2", "Cạnh 3", "Thông tin TG", "Chu vi", "Diện tích");
            Console.WriteLine(result);
            tamGiac_01.toString();
            tamGiac_02.toString();
            tamGiac_03.toString();
            tamGiac_04.toString();
            tamGiac_05.toString();
            Console.ReadKey();
        }
    }
}
