using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                    Console.Write("Tinh tong cac so le tu 1 den n: (n)= ");
                    uint n = uint.Parse(Console.ReadLine());

                Console.Clear();
                    Console.WriteLine($"-> Tong cac so le tu 1 den {n} la: {TinhTongSoLe(n)}");
                Console.WriteLine();

                Console.WriteLine("<----------------------END------------------------>");
                Console.WriteLine("Nhan phim BAT KY de tiep tuc / phim ESC de ket thuc");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
        }
        static uint TinhTongSoLe(uint soNguyen)
        {
            uint tong = 0;
            for (uint i = 1; i <= soNguyen; i++)
            {
                if (i % 2 != 0)
                {
                    tong += i;
                }        
            }
            return tong;
        }
    }
}
