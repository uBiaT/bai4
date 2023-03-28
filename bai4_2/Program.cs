using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                    Console.Write("Xuat bang cuu chuong tu 1 den n: (n)= ");
                    uint n = uint.Parse(Console.ReadLine());

                Console.Clear();
                    VietBangCuuChuong(n);
                Console.WriteLine();

                Console.WriteLine("<----------------------END------------------------>");
                Console.WriteLine("Nhan phim BAT KY de tiep tuc / phim ESC de ket thuc");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
        }
        static void VietBangCuuChuong(uint soNguyen)
        {
            for (uint i = 1; i <= soNguyen; i++)
            {
                Console.WriteLine($"Bang cuu chuong {i}:");
                for (uint j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"\t{i} × {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
