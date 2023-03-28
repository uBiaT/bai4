using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                    Console.Write("Tinh tong giai thua cac so tu 1 den n: (n)= ");
                    uint n = uint.Parse(Console.ReadLine());

                Console.Clear();
                    Console.WriteLine($"-> Tong giai thua cac so tu 1 den {n} la: {TongGiaiThua(n)}");
                Console.WriteLine();

                Console.WriteLine("<----------------------END------------------------>");
                Console.WriteLine("Nhan phim BAT KY de tiep tuc / phim ESC de ket thuc");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
        }
        static uint TongGiaiThua(uint soNguyen)
        {
            uint tich = 1;
            uint tong = 0;
            for (uint i = 1; i <= soNguyen; i++)
            {
                tich *= i;
                tong += tich;
            }
            return tong;
        }
    }
}
